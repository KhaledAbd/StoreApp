using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Store.API.Models;

namespace Store.API.Data
{
    public class DataContext: IdentityDbContext<User, Role,
    int, IdentityUserClaim<int>, UserRole, IdentityUserLogin<int>,
    IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public DataContext(DbContextOptions<DataContext>  options) : base (options) {}
        public DbSet<Photo> Photos{get; set;}
        public DbSet<Employee> Employees {get; set;}

        public DbSet<Distributor>Distributor{get; set;}

        public DbSet<OwnerFactory> OwnerFactories {get; set;}

        public DbSet<Cleint> Cleints {get; set;}
        public DbSet<Category>Categories {get; set;}

        public DbSet<Size> Sizes {get; set;}

        public DbSet<TypeCloth> typeClothes{get; set;}

        public DbSet<CategoryPrefered> CategoryPrefereds{get; set;}

        public DbSet<TypeClothPrefered> TypeClothPrefereds{get; set;}

        public DbSet<SizePrefered> SizePrefereds{get; set;}

        public DbSet<Cloth> Clothes{get; set;}

        public DbSet<BillsClothes> BillsClothes {get; set;}

        public DbSet<Bill> Bills {get; set;}

        public DbSet<ClientBill> clientBills{get; set;}

        public DbSet<ClientBillClothes> clientBillClothes {get; set;}
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<UserRole>(userRole => {
                userRole.HasKey(ur => new{ur.UserId, ur.RoleId});

                userRole.HasOne(ur =>ur.Role).WithMany(r => r.UserRoles).
                HasForeignKey(ur => ur.RoleId).IsRequired();
                userRole.HasOne(ur => ur.User).WithMany(r => r.UserRoles)
                .HasForeignKey(r => r.UserId).IsRequired();
                builder.Entity<Photo>().HasQueryFilter(p => p.IsApproved);
            });
             builder.Entity<Photo>().HasQueryFilter(p => p.IsApproved);
        }
    }
}
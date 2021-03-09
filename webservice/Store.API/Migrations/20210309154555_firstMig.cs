using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Store.API.Migrations
{
    public partial class firstMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    KnownAs = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastActive = table.Column<DateTime>(nullable: false),
                    Introduction = table.Column<string>(nullable: true),
                    LookingFor = table.Column<string>(nullable: true),
                    Interests = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "clientBills",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DateOfBills = table.Column<DateTime>(nullable: false),
                    Location = table.Column<string>(nullable: true),
                    TypePaid = table.Column<bool>(nullable: false),
                    paid = table.Column<double>(nullable: false),
                    isRecieved = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientBills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "typeClothes",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_typeClothes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cleints",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    DateLastPurchase = table.Column<DateTime>(nullable: true),
                    Activities = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cleints", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Cleints_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Distributor",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    CarNumbers = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Percantage = table.Column<double>(nullable: false),
                    Salary = table.Column<double>(nullable: false),
                    NumOfgears = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Distributor", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Distributor_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    Salary = table.Column<double>(nullable: false),
                    Incentives = table.Column<double>(nullable: false),
                    Allowances = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Employees_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Url = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    PublicId = table.Column<string>(nullable: true),
                    IsApproved = table.Column<bool>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photos_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Clothes",
                columns: table => new
                {
                    Code = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MainPhoto = table.Column<bool>(nullable: false),
                    PhotoUrl = table.Column<string>(nullable: true),
                    PublicId = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Color = table.Column<long>(nullable: false),
                    SizeId = table.Column<int>(nullable: true),
                    Quentity = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Sale = table.Column<double>(nullable: false),
                    isApproved = table.Column<bool>(nullable: false),
                    ModelName = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: true),
                    TypeClothId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clothes", x => x.Code);
                    table.ForeignKey(
                        name: "FK_Clothes_Categories_Categoryid",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Clothes_Sizes_Sizeid",
                        column: x => x.SizeId,
                        principalTable: "Sizes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Clothes_typeClothes_TypeClothid",
                        column: x => x.TypeClothId,
                        principalTable: "typeClothes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CategoryPrefereds",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false),
                    ClientId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryPrefereds", x =>new {x.CategoryId, x.ClientId});
                    table.ForeignKey(
                        name: "FK_CategoryPrefereds_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryPrefereds_Cleints_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Cleints",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SizePrefereds",
                columns: table => new
                {
                    SizeId = table.Column<int>(nullable: false),
                    CleintId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SizePrefereds", x =>new {x.SizeId,x.CleintId});
                    table.ForeignKey(
                        name: "FK_SizePrefereds_Cleints_CleintId",
                        column: x => x.CleintId,
                        principalTable: "Cleints",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SizePrefereds_Sizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "Sizes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TypeClothPrefereds",
                columns: table => new
                {
                    TypeClothId = table.Column<int>(nullable: false),
                    CleintId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeClothPrefereds", x => new{x.TypeClothId, x.CleintId});
                    table.ForeignKey(
                        name: "FK_TypeClothPrefereds_Cleints_CleintId",
                        column: x => x.CleintId,
                        principalTable: "Cleints",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TypeClothPrefereds_typeClothes_TypeClothId",
                        column: x => x.TypeClothId,
                        principalTable: "typeClothes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OwnerFactories",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true),
                    LogoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OwnerFactories", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_OwnerFactories_Photos_LogoId",
                        column: x => x.LogoId,
                        principalTable: "Photos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OwnerFactories_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "clientBillClothes",
                columns: table => new
                {
                    ClientBillId = table.Column<int>(nullable: false),
                    ClothId = table.Column<int>(nullable: false),
                    Quentity = table.Column<int>(nullable: false),
                    Sale = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientBillClothes", x => new {x.ClientBillId, x.ClothId});
                    table.ForeignKey(
                        name: "FK_clientBillClothes_clientBills_ClientBillId",
                        column: x => x.ClientBillId,
                        principalTable: "clientBills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_clientBillClothes_Clothes_ClothId",
                        column: x => x.ClothId,
                        principalTable: "Clothes",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DateOfBills = table.Column<DateTime>(nullable: false),
                    payed = table.Column<double>(nullable: false),
                    PhotoUrlId = table.Column<int>(nullable: true),
                    OwnerFactoryUserId = table.Column<int>(nullable: true),
                    regiteredIdUser = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.id);
                    table.ForeignKey(
                        name: "FK_Bills_OwnerFactories_OwnerFactoryUserId",
                        column: x => x.OwnerFactoryUserId,
                        principalTable: "OwnerFactories",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bills_Photos_PhotoUrlId",
                        column: x => x.PhotoUrlId,
                        principalTable: "Photos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bills_Employees_regiteredIdUser",
                        column: x => x.regiteredIdUser,
                        principalTable: "Employees",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BillsClothes",
                columns: table => new
                {
                    ClothesCode = table.Column<int>(nullable: false),
                    BillsId = table.Column<int>(nullable: false),
                    Quentity = table.Column<int>(nullable: false),
                    PriceFactory = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillsClothes", x => new {x.ClothesCode, x.BillsId});
                    table.ForeignKey(
                        name: "FK_BillsClothes_Bills_BillsId",
                        column: x => x.BillsId,
                        principalTable: "Bills",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BillsClothes_Clothes_ClothesCode",
                        column: x => x.ClothesCode,
                        principalTable: "Clothes",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bills_OwnerFactoryUserId",
                table: "Bills",
                column: "OwnerFactoryUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_PhotoUrlId",
                table: "Bills",
                column: "PhotoUrlId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_regiteredIdUser",
                table: "Bills",
                column: "regiteredIdUser");

            migrationBuilder.CreateIndex(
                name: "IX_BillsClothes_BillsId",
                table: "BillsClothes",
                column: "BillsId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryPrefereds_ClientId",
                table: "CategoryPrefereds",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_clientBillClothes_ClothId",
                table: "clientBillClothes",
                column: "ClothId");

            migrationBuilder.CreateIndex(
                name: "IX_Clothes_Categoryid",
                table: "Clothes",
                column: "Categoryid");

            migrationBuilder.CreateIndex(
                name: "IX_Clothes_Sizeid",
                table: "Clothes",
                column: "Sizeid");

            migrationBuilder.CreateIndex(
                name: "IX_Clothes_TypeClothid",
                table: "Clothes",
                column: "TypeClothid");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerFactories_LogoId",
                table: "OwnerFactories",
                column: "LogoId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_UserId",
                table: "Photos",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SizePrefereds_CleintId",
                table: "SizePrefereds",
                column: "CleintId");

            migrationBuilder.CreateIndex(
                name: "IX_TypeClothPrefereds_CleintId",
                table: "TypeClothPrefereds",
                column: "CleintId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BillsClothes");

            migrationBuilder.DropTable(
                name: "CategoryPrefereds");

            migrationBuilder.DropTable(
                name: "clientBillClothes");

            migrationBuilder.DropTable(
                name: "Distributor");

            migrationBuilder.DropTable(
                name: "SizePrefereds");

            migrationBuilder.DropTable(
                name: "TypeClothPrefereds");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "clientBills");

            migrationBuilder.DropTable(
                name: "Clothes");

            migrationBuilder.DropTable(
                name: "Cleints");

            migrationBuilder.DropTable(
                name: "OwnerFactories");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropTable(
                name: "typeClothes");

            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}

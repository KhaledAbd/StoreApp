using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Store.API.Models
{
    public class Role:IdentityRole<int>
    {
        public virtual ICollection<UserRole> UserRoles{get; set;}
    }
}
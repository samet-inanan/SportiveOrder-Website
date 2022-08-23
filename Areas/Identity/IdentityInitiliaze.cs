using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SportiveOrder.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportiveOrder.Areas.Identity
{
    public  class IdentityInitiliaze
    {
        public static void CreateAdmin(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            AppUser appUser = new AppUser
            {
                UserName = "b191210102@sakarya.edu.tr",

            };

            if (userManager.FindByNameAsync("b191210102@sakarya.edu.tr").Result == null)
            {
                var result = userManager.CreateAsync(appUser, "123").Result;
            }
            if (roleManager.FindByNameAsync("Admin").Result == null)
            {
                IdentityRole role = new IdentityRole
                {
                    Name = "Admin"
                };
                IdentityRole roleMember = new IdentityRole
                {
                    Name = "Member"
                };
                var resultRoleAdmin = roleManager.CreateAsync(role).Result;
                var resultRoleMember = roleManager.CreateAsync(roleMember).Result;
                var reslut2 = userManager.AddToRoleAsync(appUser, "Admin").Result;
                
            }
        }
    
        
    }
}

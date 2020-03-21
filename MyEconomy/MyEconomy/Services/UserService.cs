using MyEconomy.Models;
using MyEconomy.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEconomy.Services
{
    public class UserService
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public List<ApplicationUser> GetAllUsers()
        {
            return db.Users.ToList();
        }

        public ApplicationUser GetUserById(Guid id)
        {
            return db.Users.Find(id);
        }

        public async Task<bool> AddUser(ApplicationUserManager userManager, CreateUserViewModel userView)
        {
            var userDb = new ApplicationUser()
            {
                UserName = userView.UserName,
                FirsName = userView.FirsName,
                LastName = userView.LastName,
                Email = userView.Email,
            };

            var result = await userManager.CreateAsync(userDb, userView.Password);

            return result.Succeeded;
        }
    }
}
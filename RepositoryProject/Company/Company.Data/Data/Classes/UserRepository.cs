using Company.Data.Data.Interfaces;
using Company.Data.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Data.Data.Classes
{
    public class UserRepository : IUserRepository
    {
        public void AddUser(User user)
        {
            using (AppDbContext context = new AppDbContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }

        public void DeleteUser(User user)
        {
            using (AppDbContext context = new AppDbContext())
            {
                context.Users.Remove(user);
                context.SaveChanges();
            }
        }

        public void UpdateUser(User user)
        {
            using (AppDbContext context = new AppDbContext())
            {
                context.Users.Update(user);
                context.SaveChanges();
            }
        }
    }
}

using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    internal class UserRepository
    {
        private void CreateUser(string username, string password)
        {
            using (var context = new TaskyContext())
            {
                var user = new User
                {
                    Username = username,
                    Password = password,
                    DateCreated = DateTime.Now,
                    Tasks = new List<UserTask>()
                };

                context.Users.Add(user);
                context.SaveChanges();
            }
        }

        private void UpdateUser(string username, string password)
        {
            using (var context = new TaskyContext())
            {
                var user = context.Users.Find(username);
                if (user != null)
                {
                    user.Password = password;
                    context.SaveChanges();
                }

            }
        }

        private void DeleteUser(string username)
        {
            using (var context = new TaskyContext())
            {
                var user = context.Users.Find(username);
                if (user != null)
                {
                    context.Users.Remove(user);
                    context.SaveChanges();
                }
            }
        }

        private List<UserTask> GetTasksByUsername(string username)
        {
            using (var context = new TaskyContext())
            {
                return context.Tasks.Where(t => t.Username.Equals(username)).ToList();
            }
        }
    }
}

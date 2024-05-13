using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    internal class UserTaskRepository
    {
        private void CreateTask(string username, string title, string description,
            DateTime startDate, DateTime endDate)
        {
            using (var context = new TaskyContext())
            {
                var user = context.Users.SingleOrDefault(u => u.Username == username);

                var newTask = new UserTask
                {
                    Title = title,
                    Description = description,
                    StartDate = startDate,
                    EndDate = endDate,
                    User = user
                };

                context.Tasks.Add(newTask);
                context.SaveChanges();
            }

        }

        private void ChangeTaskTitle(int taskId, string newTitle)
        {
            using (var context = new TaskyContext())
            {
                var task = context.Tasks.Find(taskId);
                if (task != null)
                {
                    task.Title = newTitle;
                }
                context.SaveChanges();
            }
        }

        private void ChangeTaskDescription(int taskId, string newDescription)
        {
            using (var context = new TaskyContext())
            {
                var task = context.Tasks.Find(taskId);
                if (task != null)
                {
                    task.Description = newDescription;
                }
                context.SaveChanges();
            }
        }

        private void ChangeTaskStartDate(int taskId, DateTime newStartDate)
        {
            using (var context = new TaskyContext())
            {
                var task = context.Tasks.Find(taskId);
                if (task != null)
                {
                    task.StartDate = newStartDate;
                }
                context.SaveChanges();
            }
        }

        private void ChangeTaskEndDate(int taskId, DateTime newEndDate)
        {
            using (var context = new TaskyContext())
            {
                var task = context.Tasks.Find(taskId);
                if (task != null)
                {
                    task.EndDate = newEndDate;
                }
                context.SaveChanges();
            }
        }
    }
}

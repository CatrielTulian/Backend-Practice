using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Persistence;

namespace Infrastructure.Data
{
    public class TaskRepository : ITaskRepository
    {
        private readonly TasksDbContext _context;

        public TaskRepository(TasksDbContext context)
        {
            _context = context;
        }

        public void AddTask(Tasks task)
        {
            _context.tasks.Add(task);
            _context.SaveChanges();
        }

        public List<Tasks> GetTasks()
        {
            return _context.tasks.ToList();
        }

        public Tasks? GetTaskById(int id)
        {
            return _context.tasks.FirstOrDefault(x => x.Id.Equals(id));
        }

        public void UpdateTask(Tasks task)
        {
            _context.tasks.Update(task);
            _context.SaveChanges();
        }

        public void DeleteTask(Tasks task) 
        {
            _context.tasks.Remove(task); 
            _context.SaveChanges();
        }




    }
}

using Domain.Entities;

namespace Domain.Interfaces
{
    public interface ITaskRepository
    {
        void AddTask(Tasks task);
        List<Tasks> GetTasks();
        Tasks? GetTaskById(int taskId);
        void UpdateTask(Tasks taskId);
        void DeleteTask(Tasks taskId);
        List<Tasks> GetTasksByPersonId(int personId);
        List<Tasks> GetCompletedTasks();
        List<Tasks> GetPendingTasks();
    }
}

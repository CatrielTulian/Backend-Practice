using Domain.Entities

namespace Domain.Interfaces
{
    public interface ITaskRepository
    {
        void AddTask(Tasks task);
        List<Tasks> GetAllTasks();
        Tasks? GetTaskById(int taskId);
        void UpdateTask(Tasks task);
        void DeleteTask(int taskId);
        List<Tasks> GetTasksByPersonId(int personId);
        List<Tasks> GetCompletedTasks();
        List<Tasks> GetPendingTasks();
    }
}

using Domain.Entities;

namespace Domain.Interfaces
{
    public interface ITaskRepository
    {
        void AddTask(Tasks Task);
        List<Tasks> GetTasks();
        Tasks? GetTaskById(int TaskId);
        void UpdateTask(Tasks TaskId);
        void DeleteTask(Tasks TaskId);
        List<Tasks> GetTasksByPersonId(int TaskId);
        List<Tasks> GetCompletedTasks();
        List<Tasks> GetPendingTasks();
    }
}

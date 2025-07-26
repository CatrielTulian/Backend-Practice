using Contract.Tasks.Request;
using Contract.Tasks.Response;

namespace Application.Interfaces
{
    public interface ITaskService
    {
        void CreateTask(TaskRequest request);
        List<TaskResponse> GetAllTasks();
        TaskResponse? GetTaskById(int taskId);
        bool UpdateTask(int taskId, TaskRequest request);
        bool DeleteTask(int taskId);
    }
}

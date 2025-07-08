using Application.Interfaces;
using Contract.Mappings;
using Contract.Tasks.Request;
using Contract.Tasks.Response;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;

        public TaskService(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public void CreateTask(TaskRequest request)
        {
            var taskEntity = MapTasks.ToTaskEntity(request);
            _taskRepository.AddTask(taskEntity);
        }

        public List<TaskResponse> GetAllTasks()
        {
            var tasks = _taskRepository.GetTasks();
            var taskResponse = new List<TaskResponse>();

            foreach (var task in tasks)
            {
                var taskResp = MapTasks.ToTaskResponse(task);

                taskResponse.Add(taskResp);
            }
            return taskResponse;
        }

        public bool UpdateTask(int taskId, TaskRequest task)
        {
            var taskEntity = _taskRepository.GetTaskById(taskId);

            if (taskEntity != null)
            {
                MapTasks.ToTaskEntityUpdate(taskEntity, task);
                _taskRepository.UpdateTask(taskEntity);
                return true;
            }
            return false;
        }

        public TaskResponse? GetTaskById(int id)
        {
            var task = _taskRepository.GetTaskById(id);
            if (task != null)
            {
                return MapTasks.ToTaskResponse(task);
            }
            return null;
        }

        public bool DeleteTask(int taskId)
        {
            var task = _taskRepository.GetTaskById(taskId);
            if (task != null)
            {
                _taskRepository.DeleteTask(task);
                return true;
            }
            return false;

        }

        void ITaskService.UpdateTask(int taskId, TaskRequest request)
        {
            throw new NotImplementedException();
        }

        void ITaskService.DeleteTask(int taskId)
        {
            throw new NotImplementedException();
        }
    }
}

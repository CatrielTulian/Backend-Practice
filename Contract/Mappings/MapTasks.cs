using DomainEntity = Domain.Entities;
using Contract.Tasks.Request;
using Contract.Tasks.Response;

namespace Contract.Mappings
{
    public static class MapTasks
    {
        public static DomainEntity.Tasks ToTaskEntity(TaskRequest Request)
        {
            return new DomainEntity.Tasks()
            {
                Title = Request.Title,
                Description = Request.Description,
                HourAndDate = Request.HourAndDate,
                IsCompleted = Request.IsCompleted,

            };
        }
        public static TaskResponse ToTaskResponse(DomainEntity.Tasks Task)
        {
            return new TaskResponse()
            {
                TaskId = Task.TaskId,
                Title = Task.Title,
                Description = Task.Description,
                HourAndDate = Task.HourAndDate,
                IsCompleted = Task.IsCompleted,
            };
        }

        public static void ToTaskEntityUpdate(DomainEntity.Tasks Task, TaskRequest Request)
        {
            Task.Title = Request.Title;
            Task.Description = Request.Description;
            Task.HourAndDate = Request.HourAndDate;
            Task.IsCompleted = Request.IsCompleted;
        }
    }
}

using DomainEntity = Domain.Entities;
using Contract.Tasks.Request;
using Contract.Tasks.Response;

namespace Contract.Mappings
{
    public static class MapTasks
    {
        public static DomainEntity.Tasks ToTaskEntity(TaskRequest request)
        {
            return new DomainEntity.Tasks()
            {
                title = request.title,
                description = request.description,
                hourAndDate = request.hourAndDate,
                isCompleted = request.isCompleted,

            };
        }
        public static TaskResponse ToTaskResponse(DomainEntity.Tasks task)
        {
            return new TaskResponse()
            {
                taskId = task.taskId,
                title = task.title,
                description = task.description,
                hourAndDate = task.hourAndDate,
                isCompleted = task.isCompleted,
            };
        }

        public static void ToTaskEntityUpdate(DomainEntity.Tasks task, TaskRequest request)
        {
            task.title = request.title;
            task.description = request.description;
            task.hourAndDate = request.hourAndDate;
            task.isCompleted = request.isCompleted;
        }
    }
}

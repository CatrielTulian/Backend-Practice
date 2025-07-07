namespace Contract.Tasks.Response
{
    public class TaskResponse
    {
        public int taskId { get; set; }
        public string? title { get; set; } 
        public string? description { get; set; } 
        public DateTime hourAndDate { get; set; }
        public bool isCompleted { get; set; } = false;
        
    }
}

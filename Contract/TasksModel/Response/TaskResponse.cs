namespace Contract.Tasks.Response
{
    public class TaskResponse
    {
        public int Id { get; set; }
        public string? Title { get; set; } 
        public string? Description { get; set; } 
        public DateTime HourAndDate { get; set; }
        public bool IsCompleted { get; set; } = false;
        
    }
}

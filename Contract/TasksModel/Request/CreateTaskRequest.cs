namespace Contract.Tasks.Request
{
    public class TaskRequest
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime HourAndDate { get; set; }
        public bool IsCompleted { get; set; } = false;
    }
}

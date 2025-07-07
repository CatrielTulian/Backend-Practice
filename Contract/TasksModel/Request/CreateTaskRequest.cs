namespace Contract.Tasks.Request
{
    public class TaskRequest
    {
        public string title { get; set; } = string.Empty;
        public string description { get; set; } = string.Empty;
        public DateTime hourAndDate { get; set; }
        public bool isCompleted { get; set; } = false;
    }
}

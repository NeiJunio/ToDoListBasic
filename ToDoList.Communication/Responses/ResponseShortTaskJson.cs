using ToDoList.Communication.Enums;

namespace ToDoList.Communication.Responses
{
    public class ResponseShortTaskJson
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        // public string Description { get; set; } = string.Empty;
        public TaskPriority Priority { get; set; }
        public DateTime Date { get; set; }
        public TaskStatusProgress Status { get; set; }
    }
}

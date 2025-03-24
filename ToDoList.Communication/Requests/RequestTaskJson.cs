using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Communication.Enums;



namespace ToDoList.Communication.Requests
{
    public class RequestTaskJson
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public TaskPriority Priority { get; set; }
        public DateTime Date { get; set; }
        public TaskStatusProgress Status { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Communication.Enums;

namespace ToDoList.Communication.Responses
{
    public class ResponseRegisterTaskJson
    {
        public int Id {get;set;}
        public string Name { get; set; } = string.Empty;
        
    }
}

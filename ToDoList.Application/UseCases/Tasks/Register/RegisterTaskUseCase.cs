using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Communication.Requests;
using ToDoList.Communication.Responses;

namespace ToDoList.Application.UseCases.Tasks.Register
{
    public class RegisterTaskUseCase
    {
        public ResponseRegisterTaskJson Execute(RequestTaskJson request)
        {
            return new ResponseRegisterTaskJson
            {
                Id = 1,
                Name = request.Name
            };
        }
    }

}

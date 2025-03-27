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

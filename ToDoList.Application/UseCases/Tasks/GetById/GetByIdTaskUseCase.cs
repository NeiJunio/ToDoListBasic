using ToDoList.Communication.Responses;

namespace ToDoList.Application.UseCases.Tasks.GetById
{
    public class GetByIdTaskUseCase
    {
        public ResponseTaskJson Execute(int id)
        {
            return new ResponseTaskJson
            {
                Id = id,
                Name = "Teste Get By Id",
                Description = "Testando endpoint de busca por id",
                Priority = Communication.Enums.TaskPriority.Medium,
                Date = new DateTime(year: 2025, month: 02, day: 10),
                Status = Communication.Enums.TaskStatusProgress.Pending
            };
        }
    }
}

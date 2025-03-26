using ToDoList.Communication.Responses;

namespace ToDoList.Application.UseCases.Tasks.GetAll
{
    public class GetAllTaskUseCase
    {
        public ResponseAllTaskJson Execute()
        {
            return new ResponseAllTaskJson
            {
                Tasks = new List<ResponseShortTaskJson>
                {
                    new ResponseShortTaskJson
                    {
                        Id = 1,
                        Name = "Teste 1",
                        Priority = Communication.Enums.TaskPriority.High,
                        Date = new DateTime(year: 2025, month: 03, day:25),
                        Status = Communication.Enums.TaskStatusProgress.Progress
                    },
                    new ResponseShortTaskJson
                    {
                        Id = 2,
                        Name = "Teste 2",
                        Priority = Communication.Enums.TaskPriority.Low,
                        Date = new DateTime(year: 2025, month: 03, day:27),
                        Status = Communication.Enums.TaskStatusProgress.Completed
                    },
                }
            };
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using ToDoList.Application.UseCases.Tasks.Register;
using ToDoList.Application.UseCases.Tasks.Update;
using ToDoList.Communication.Requests;
using ToDoList.Communication.Responses;

namespace ToDoList.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisterTaskJson), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
        public IActionResult Register([FromBody] RequestTaskJson request)
        {
            var useCase = new RegisterTaskUseCase();

            var response = useCase.Execute(request);

            return Created(string.Empty, response);
        }


        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]

        public IActionResult Update([FromRoute]int id, [FromBody]RequestTaskJson request)
        {
            var useCase = new UpdateTaskUseCase();

            useCase.Execute(id, request);

            return NoContent();
        }
    }
}

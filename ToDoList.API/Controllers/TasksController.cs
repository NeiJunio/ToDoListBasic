using Microsoft.AspNetCore.Mvc;
using ToDoList.Application.UseCases.Tasks.Delete;
using ToDoList.Application.UseCases.Tasks.GetAll;
using ToDoList.Application.UseCases.Tasks.GetById;
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

        public IActionResult Update([FromRoute] int id, [FromBody] RequestTaskJson request)
        {
            var useCase = new UpdateTaskUseCase();

            useCase.Execute(id, request);

            return NoContent();
        }


        [HttpGet]
        [ProducesResponseType(typeof(ResponseAllTaskJson), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult GetAll()
        {
            var useCase = new GetAllTaskUseCase();

            var response = useCase.Execute();

            if (response.Tasks.Any())
            {
                return Ok(response);
            }

            return NoContent();

        }


        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(ResponseTaskJson), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
        public IActionResult GetById(int id)
        {
            var useCase = new GetByIdTaskUseCase();

            var response = useCase.Execute(id);

            return Ok(response);
        }

        [HttpDelete]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
        public IActionResult Delete(int id)
        {
            var useCase = new DeleteTaskByIdUseCase();

            useCase.Execute(id);

            return NoContent();
        }
    }
}

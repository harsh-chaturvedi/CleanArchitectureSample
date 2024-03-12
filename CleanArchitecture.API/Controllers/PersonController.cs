using CleanArchitecture.Application;
using CleanArchitecture.Application.Commands;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IMediator _mediator;
        public PersonController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetPersonById([FromQuery] GetPersonByIdQuery getPersonById)
        {
            try
            {
                var result = await _mediator.Send(getPersonById);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreatePerson([FromBody] CreatePerson createPerson)
        {
            try
            {
                var result = await _mediator.Send(createPerson);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}

using Application;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace Api_Scratch
{
    [ApiController]
    [Route("/Students")]
    public class Controllers : ControllerBase
    {   
        private readonly IMediator _mediator;
        // Constructeur 
        // To avoid NullReferenceException
        public Controllers(IMediator mediator )
        {
            _mediator = mediator;
        }

        [HttpGet("/AllStudent")]
        public async Task<IActionResult> GetAllStudents(CancellationToken cancellationtoken) {
            
            var query = new GetStudentQuery {};
            var result = await _mediator.Send(query, cancellationtoken);
            return Ok(result);

        }

        [HttpPost("/AddStudent")]
        public async Task<IActionResult> CreateStudent([FromBody] CreateStudentCommand cmd, CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(cmd, cancellationToken);
            return Ok(result);
        }

    }
 
}

using LibraryApp.Application.CQRS.Commands.AuthorsCommands;
using LibraryApp.Shared.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using LibraryApp.Application.CQRS.Queries.AuthorsQueries;

namespace LibraryApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthorsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<Author>> PostAuthor(AuthorCreateCommand command)
        {
            var result = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetAuthorById), new { id = result.Id }, result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteAuthor(int id)
        {
            var command = new AuthorDeleteCommand { Id = id };
            var result = await _mediator.Send(command);
            return result ? Ok() : NotFound();
        }

        [HttpPut]
        public async Task<ActionResult<Author>> UpdateAuthor(AuthorUpdateCommand command)
        {

            var result = await _mediator.Send(command);
            return result != null ? Ok(result) : NotFound();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Author>> GetAuthorById(int id)
        {
            var query = new GetAuthorByIdQuery(id);
            var result = await _mediator.Send(query);
            return result != null ? Ok(result) : NotFound();
        }

        [HttpGet]
        public async Task<ActionResult<List<Author>>> GetAuthors()
        {
            var query = new GetAuthorsQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }
    }
}

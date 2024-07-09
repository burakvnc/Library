using MediatR;
using LibraryApp.Application.DTO;

namespace LibraryApp.Application.CQRS.Commands.AuthorsCommands
{
    public class AuthorCreateCommand : IRequest<AuthorDto>
    {
        public string? Name { get; set; }
    }
}

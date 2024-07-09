using MediatR;
using LibraryApp.Application.DTO;

namespace LibraryApp.Application.CQRS.Commands.AuthorsCommands
{
    public class AuthorUpdateCommand : IRequest<AuthorDto>
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}

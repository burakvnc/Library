using MediatR;

namespace LibraryApp.Application.CQRS.Commands.AuthorsCommands
{
    public class AuthorDeleteCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}

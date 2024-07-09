using MediatR;

namespace LibraryApp.Application.CQRS.Commands.BooksCommands
{
    public class BookDeleteCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}

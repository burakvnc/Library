using MediatR;

namespace LibraryApp.Application.CQRS.Commands.LİbraryCommands
{
    public class RemoveBookFromLibraryCommand : IRequest<bool>
    {
        public int LibraryId { get; set; }
        public int BookId { get; set; }
    }
}

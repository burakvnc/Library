using MediatR;

namespace LibraryApp.Application.CQRS.Commands.LİbraryCommands
{
    public class LibraryDeleteCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}

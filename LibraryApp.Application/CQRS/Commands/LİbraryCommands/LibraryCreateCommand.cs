using MediatR;
using LibraryApp.Application.DTO;

namespace LibraryApp.Application.CQRS.Commands.LİbraryCommands
{
    public class LibraryCreateCommand : IRequest<LibraryDto>
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
    }
}

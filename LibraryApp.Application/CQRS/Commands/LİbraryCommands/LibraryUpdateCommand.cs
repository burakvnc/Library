using MediatR;
using LibraryApp.Application.DTO;

namespace LibraryApp.Application.CQRS.Commands.LİbraryCommands
{
    public class LibraryUpdateCommand : IRequest<LibraryDto>
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
    }
}

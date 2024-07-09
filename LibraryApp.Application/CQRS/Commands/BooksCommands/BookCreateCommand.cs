using MediatR;
using LibraryApp.Application.DTO;

namespace LibraryApp.Application.CQRS.Commands.BooksCommands
{
    public class BookCreateCommand : IRequest<BookDto>
    {
        public string? Title { get; set; }
        public string? ISBN { get; set; }
        public DateTime PublishedDate { get; set; }
        public List<int>? AuthorIds { get; set; }
    }
}

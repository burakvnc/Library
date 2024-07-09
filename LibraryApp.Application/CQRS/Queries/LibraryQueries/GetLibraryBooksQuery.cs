using MediatR;
using LibraryApp.Application.DTO;

namespace LibraryApp.Application.CQRS.Queries.LibraryQueries
{
    public class GetLibraryBooksQuery : IRequest<List<BookDto>>
    {
        public int LibraryId { get; set; }

        public GetLibraryBooksQuery(int libraryId)
        {
            LibraryId = libraryId;
        }
    }
}

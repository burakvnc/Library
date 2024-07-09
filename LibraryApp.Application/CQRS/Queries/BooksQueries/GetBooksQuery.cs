using MediatR;
using LibraryApp.Application.DTO;

namespace LibraryApp.Application.CQRS.Queries.BooksQueries
{
    public class GetBooksQuery : IRequest<List<BookDto>>
    {
    }
}

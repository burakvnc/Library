using MediatR;
using LibraryApp.Application.DTO;

namespace LibraryApp.Application.CQRS.Queries.AuthorsQueries
{
    public class GetAuthorsQuery : IRequest<List<AuthorDto>>
    {
    }
}

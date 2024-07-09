using MediatR;
using LibraryApp.Application.DTO;

namespace LibraryApp.Application.CQRS.Queries.AuthorsQueries
{
    public class GetAuthorByIdQuery : IRequest<AuthorDto>
    {
        public int Id { get; set; }

        public GetAuthorByIdQuery(int id)
        {
            Id = id;
        }
    }
}

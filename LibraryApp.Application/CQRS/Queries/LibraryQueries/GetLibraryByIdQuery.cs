using MediatR;
using LibraryApp.Application.DTO;

namespace LibraryApp.Application.CQRS.Queries.LibraryQueries
{
    public class GetLibraryByIdQuery : IRequest<LibraryDto>
    {
        public int Id { get; set; }

        public GetLibraryByIdQuery(int id)
        {
            Id = id;
        }
    }
}

using MediatR;
using LibraryApp.Application.DTO;

namespace LibraryApp.Application.CQRS.Queries.LibraryQueries
{
    public class GetLibrariesQuery : IRequest<List<LibraryDto>>
    {
    }
}

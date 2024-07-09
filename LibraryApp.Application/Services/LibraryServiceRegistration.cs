using MediatR;
using Microsoft.Extensions.DependencyInjection;
using LibraryApp.Application.CQRS.Commands.LİbraryCommands;
using LibraryApp.Application.DTO;
using LibraryApp.Application.CQRS.Queries.LibraryQueries;

namespace LibraryApp.Application.Services
{
    public static class LibraryServiceRegistration
    {
        public static IServiceCollection AddLibraryServices(this IServiceCollection services)
        {
            services.AddTransient<IRequestHandler<LibraryCreateCommand, LibraryDto>, LibraryCommandHandlers>();
            services.AddTransient<IRequestHandler<LibraryDeleteCommand, bool>, LibraryCommandHandlers>();
            services.AddTransient<IRequestHandler<LibraryUpdateCommand, LibraryDto>, LibraryCommandHandlers>();
            services.AddTransient<IRequestHandler<GetLibraryByIdQuery, LibraryDto>, LibraryQueryHandlers>();
            services.AddTransient<IRequestHandler<GetLibrariesQuery, List<LibraryDto>>, LibraryQueryHandlers>();
            services.AddTransient<IRequestHandler<AddBookToLibraryCommand, bool>, LibraryCommandHandlers>();
            services.AddTransient<IRequestHandler<RemoveBookFromLibraryCommand, bool>, LibraryCommandHandlers>();

            return services;
        }
    }
}

using MediatR;
using Microsoft.Extensions.DependencyInjection;
using LibraryApp.Application.CQRS.Commands.AuthorsCommands;
using LibraryApp.Application.DTO;
using LibraryApp.Application.CQRS.Queries.AuthorsQueries;

namespace LibraryApp.Application.Services
{
    public static class AuthorServiceRegistration
    {
        public static IServiceCollection AddAuthorServices(this IServiceCollection services)
        {
            services.AddTransient<IRequestHandler<AuthorCreateCommand, AuthorDto>, AuthorCommandHandlers>();
            services.AddTransient<IRequestHandler<AuthorDeleteCommand, bool>, AuthorCommandHandlers>();
            services.AddTransient<IRequestHandler<AuthorUpdateCommand, AuthorDto>, AuthorCommandHandlers>();
            services.AddTransient<IRequestHandler<GetAuthorByIdQuery, AuthorDto>, AuthorQueryHandlers>();
            services.AddTransient<IRequestHandler<GetAuthorsQuery, List<AuthorDto>>, AuthorQueryHandlers>();
            return services;
        }
    }
}

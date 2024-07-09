using MediatR;
using Microsoft.Extensions.DependencyInjection;
using LibraryApp.Application.CQRS.Commands.BooksCommands;
using LibraryApp.Application.DTO;
using LibraryApp.Application.CQRS.Queries.BooksQueries;

namespace LibraryApp.Application.Services
{
    public static class BookServiceRegistration
    {
        public static IServiceCollection AddBookServices(this IServiceCollection services)
        {
            services.AddTransient<IRequestHandler<BookCreateCommand, BookDto>, BookCommandHandlers>();
            services.AddTransient<IRequestHandler<BookDeleteCommand, bool>, BookCommandHandlers>();
            services.AddTransient<IRequestHandler<BookUpdateCommand, BookDto>, BookCommandHandlers>();
            services.AddTransient<IRequestHandler<GetBookByIdQuery, BookDto>, BookQueryHandlers>();
            services.AddTransient<IRequestHandler<GetBooksQuery, List<BookDto>>, BookQueryHandlers>();
            return services;
        }
    }
}

using MediatR;
using LibraryApp.Infrastructure.Data;
using LibraryApp.Shared.Models;
using LibraryApp.Application.DTO;
using LibraryApp.Application.CQRS.Commands;
using LibraryApp.Infrastructure.Data.Context;


namespace LibraryApp.Application.CQRS.Commands.AuthorsCommands
{
    public class AuthorCommandHandlers :
        IRequestHandler<AuthorCreateCommand, AuthorDto>,
        IRequestHandler<AuthorDeleteCommand, bool>,
        IRequestHandler<AuthorUpdateCommand, AuthorDto>
    {
        private readonly LibraryContext _context;

        public AuthorCommandHandlers(LibraryContext context)
        {
            _context = context;
        }

        public async Task<AuthorDto> Handle(AuthorCreateCommand request, CancellationToken cancellationToken)
        {
            var author = new Author { Name = request.Name };
            _context.Authors.Add(author);
            await _context.SaveChangesAsync(cancellationToken);

            return new AuthorDto { Id = author.Id, Name = author.Name };
        }

        public async Task<bool> Handle(AuthorDeleteCommand request, CancellationToken cancellationToken)
        {
            var author = await _context.Authors.FindAsync(request.Id);
            if (author == null) return false;

            _context.Authors.Remove(author);
            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }

        public async Task<AuthorDto> Handle(AuthorUpdateCommand request, CancellationToken cancellationToken)
        {
            var author = await _context.Authors.FindAsync(request.Id);
            if (author == null) return null;

            author.Name = request.Name;
            await _context.SaveChangesAsync(cancellationToken);

            return new AuthorDto { Id = author.Id, Name = author.Name };
        }
    }
}

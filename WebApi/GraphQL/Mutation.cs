using HotChocolate.AspNetCore.Authorization;
using WebApi.Entities;
using WebApi.Repository;

namespace WebApi.GraphQL
{


    public class Mutation
    {
        [Authorize(Policy = "Librarian")]
        public async Task<AuthorPayload> AddAuthor(AuthorInput input, [Service] IAuthorRepository repository)
        {
            var author = new Author(Guid.NewGuid(), input.name);
            await repository.AddAsync(author);
            return new AuthorPayload(author);
        }

        public async Task<BookPayload> AddBook(BookInput input, [Service] IBookRepository bookRepository, [Service] IAuthorRepository authorRepository)
        {
            var author = await authorRepository.GetByNameAsync(input.author) ??
                            throw new Exception("Author not found");
            var book = new Book(Guid.NewGuid(), input.title, author);
            await bookRepository.AddAsync(book);
            return new BookPayload(book);
        }
    }
}


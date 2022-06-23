using WebApi.Entities;

namespace WebApi.GraphQL
{
    public record BookPayload(Book? record, string? error = null);

    public record BookInput(string title, string author);

    public record AuthorPayload(Author record, string? error = null);

    public record AuthorInput(string name);



}

using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OrderDispatch.WebApi.Endpoints
{
    public record Todo(int Id, string? Title, DateOnly? DueBy = null, bool IsComplete = false);

    public static class ToDoEndpoint
    {
        static readonly Todo[] sampleTodos =
        [
            new(1, "Walk the dog"),
            new(2, "Do the dishes", DateOnly.FromDateTime(DateTime.Now)),
            new(3, "Do the laundry", DateOnly.FromDateTime(DateTime.Now.AddDays(1))),
            new(4, "Clean the bathroom"),
            new(5, "Clean the car", DateOnly.FromDateTime(DateTime.Now.AddDays(2)))
        ];

        public static RouteGroupBuilder MapTodoApiEndpoints(this RouteGroupBuilder builder)
        {
            builder.MapGet("/", GetAllTodoItems).Produces<IEnumerable<Todo>>(200).ProducesProblem(401).Produces(429);
            builder.MapGet("/{id}", GetTodoItem).Produces<Todo>(200).ProducesProblem(401).Produces(429);
            return builder;
        }


        private static async Task<IResult> GetAllTodoItems() => Results.Ok(sampleTodos);

        private static async Task<IResult> GetTodoItem(int id) => Results.Ok(sampleTodos[id]);
    }
}

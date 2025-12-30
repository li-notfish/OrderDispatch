using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OrderDispatch.WebApi
{
    public static class ToDoApi
    {
        static Todo[] sampleTodos =
        [
            new(1, "Walk the dog"),
            new(2, "Do the dishes", DateOnly.FromDateTime(DateTime.Now)),
            new(3, "Do the laundry", DateOnly.FromDateTime(DateTime.Now.AddDays(1))),
            new(4, "Clean the bathroom"),
            new(5, "Clean the car", DateOnly.FromDateTime(DateTime.Now.AddDays(2)))
        ];

        public static RouteGroupBuilder MapTodoApiEndpoints(this RouteGroupBuilder builder)
        {
            builder.MapGet("/", GetAllTodoItems).Produces(200, typeof(IEnumerable<Todo>)).ProducesProblem(401).Produces(429);
            builder.MapGet("/{id}", GetTodoItem).Produces(200, typeof(Todo)).ProducesProblem(401).Produces(429);
            return builder;
        }


        private static async Task<IResult> GetAllTodoItems() => Results.Ok(sampleTodos);

        private static async Task<IResult> GetTodoItem(int id) => Results.Ok(sampleTodos[id]);
    }
}

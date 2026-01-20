using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using OrderDispatch.WebApi.Datebase;
using OrderDispatch.WebApi.Models;
using OrderDispatch.WebApi.Models.DTOs;
using OrderDispatch.WebApi.Repositories;

namespace OrderDispatch.WebApi.Endpoints
{
    public static class RiderEndpoint
    {
        public static RouteGroupBuilder MapRiderEndpoints(this RouteGroupBuilder builder)
        {
            builder.WithTags("Riders");
            builder.WithMetadata();

            builder.MapGet("/", GetResultsAsync)
                .Produces<IEnumerable<RiderDto>>(200)
                .ProducesProblem(401);

            builder.MapGet("/{id}",GetResultByIdAsync)
                .Produces<RiderDto>(200)
                .ProducesProblem(400);

            builder.MapPost("/",CreateRiderAsync)
                .Accepts<RiderDto>("application/json")
                .Produces<bool>(200)
                .ProducesProblem(400);

            builder.MapPut("/", UpdateRiderAsync)
                .Accepts<RiderDto>("application/json")
                .Produces<bool>(200)
                .ProducesProblem(400);

            builder.MapDelete("/{id}",DeleteRiderAsync)
                .Produces(200)
                .ProducesProblem(400);

            return builder;
        }

        private async static Task<IResult> GetResultsAsync([FromServices]IBaseRepository<RiderDto> repository) => Results.Ok(await repository.GetAllAsync());

        private async static Task<IResult> GetResultByIdAsync([FromServices] IBaseRepository<RiderDto> repository, int id) => Results.Ok(await repository.GetAsync(id));

        private async static Task<IResult> CreateRiderAsync([FromServices] IBaseRepository<RiderDto> repository, RiderDto rider) => Results.Ok(await repository.CreateAsync(rider));

        private async static Task<IResult> UpdateRiderAsync([FromServices] IBaseRepository<RiderDto> riderRepository, RiderDto rider) => Results.Ok(await riderRepository.UpdateAsync(rider));

        private async static Task<IResult> DeleteRiderAsync([FromServices] IBaseRepository<RiderDto> riderRepository, int riderId) => Results.Ok(await riderRepository.DeleteAsync(riderId));
    }
}

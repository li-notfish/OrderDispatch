using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OrderDispatch.WebApi.Attributes;
using OrderDispatch.WebApi.Datebase;
using OrderDispatch.WebApi.Endpoints;
using OrderDispatch.WebApi.Models.DTOs;
using OrderDispatch.WebApi.Repositories;
using System.Text.Json.Serialization;

namespace OrderDispatch.WebApi;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateSlimBuilder(args);
        builder.AddServiceDefaults();

        builder.Services.ConfigureHttpJsonOptions(options =>
        {
            options.SerializerOptions.TypeInfoResolverChain.Insert(0, AppJsonSerializerContext.Default);
        });

        builder.Services.AddDbContext<DispatchContext>(option => option.UseSqlite(builder.Configuration.GetConnectionString("DbConnect")));

        builder.Services.AddScoped<IBaseRepository<RiderDto>, RiderRepository>();

        // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
        builder.Services.AddOpenApi();

        var app = builder.Build();

        app.MapDefaultEndpoints();

        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
        }

        app.MapGroup("/todoitems")
            .MapTodoApiEndpoints()
            .WithTags("Todo Items");

        app.MapGroup("/riders")
            .MapRiderEndpoints();

        app.Run();
    }
}

var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.OrderDispatch_WebApi>("orderdispatch-webapi");

builder.AddProject<Projects.OrderDispatch_Web>("orderdispatch-web");

builder.AddProject<Projects.OrderDispatch_Mobile>("orderdispatch-mobile");

builder.Build().Run();

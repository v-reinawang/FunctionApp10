var builder = DistributedApplication.CreateBuilder(args);

builder.AddAzureFunctionsProject<Projects.FunctionApp10>("functionapp10");

builder.Build().Run();

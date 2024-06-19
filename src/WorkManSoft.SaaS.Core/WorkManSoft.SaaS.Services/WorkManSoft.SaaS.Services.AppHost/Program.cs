using Aspire.Hosting;

var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.WorkManSoft_SaaS_Services_ApiService>("apiservice");

builder.AddProject<Projects.WorkManSoft_SaaS_Services_Web>("webfrontend")
    .WithReference(apiService);

builder.Build().Run();

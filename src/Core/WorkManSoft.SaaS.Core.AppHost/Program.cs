var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.WorkManSoft_SaaS_Core_ApiService>("apiservice");

builder.AddProject<Projects.WorkManSoft_SaaS_Core_Web>("webfrontend")
    .WithReference(apiService);

builder.Build().Run();

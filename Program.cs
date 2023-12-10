var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddGraphQLServer()
    .InitializeOnStartup()
    .ModifyOptions(options => options.DefaultBindingBehavior = BindingBehavior.Explicit)
    .AddMutationConventions()
    .AddTypes();

var app = builder.Build();

app.MapGraphQL();

app.RunWithGraphQLCommands(args);

const string UserManagment = "UserManagement";
const string PostManagment = "PostManagement";

var builder = WebApplication.CreateBuilder(args);

// Add token
builder.Services.AddHttpClient(UserManagment, x => x.BaseAddress = new Uri("http://localhost:5052/graphql"));
builder.Services.AddHttpClient(PostManagment, X => X.BaseAddress = new Uri("http://localhost:5016/graphql"));

builder.Services
    .AddGraphQLServer()
    .AddRemoteSchema(UserManagment)
    .AddRemoteSchema(PostManagment);

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGraphQL();

app.Run();

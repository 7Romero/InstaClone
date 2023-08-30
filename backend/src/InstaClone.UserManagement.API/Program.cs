var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

builder.Services
    .AddGraphQLServer()
    .AddQueryType(x => x.Name("Query"))
    .AddMutationType(x => x.Name("Mutation"));

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

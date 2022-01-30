using FiltersInMVC;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

//register filter
builder.Services.AddControllers(options =>
{
    options.Filters.Add(new ActionFilterAttribute("Global", -1));
    options.Filters.Add(new ActionFilterAttributeAsync("Global Async First", 50));
    options.Filters.Add(new ActionFilterAttributeAsync("Global Async Second", 0));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

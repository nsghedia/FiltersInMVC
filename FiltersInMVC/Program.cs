using FiltersInMVC;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

//register filter
builder.Services.AddTransient<ResultFilterAttribute>();
builder.Services.AddControllers(options =>
{
    options.Filters.Add(new ActionFilterAttribute("ActionFilter Global", -1));
    options.Filters.Add(new ActionFilterAttributeAsync("ActionFilter Global Async First", 50));
    options.Filters.AddService<ResultFilterAttribute>();
    options.Filters.Add(new ResourceFilterAttribute("ResourceFilter Global Async Second"));
    options.Filters.Add(new ActionFilterAttributeAsync("ActionFilter Global Async Second", 0));
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

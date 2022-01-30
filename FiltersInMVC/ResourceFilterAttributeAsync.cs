namespace FiltersInMVC;
using Microsoft.AspNetCore.Mvc.Filters;
public class ResourceFilterAttributeAsync : Attribute, IAsyncResourceFilter
{
    public string _name { get; }
    public ResourceFilterAttributeAsync(string name)
    {
        _name = name;
    }

    public async Task OnResourceExecutionAsync(ResourceExecutingContext context, ResourceExecutionDelegate next)
    {
        Console.WriteLine($"ResourceFilterAttributeAsync_ Before async {_name}");
        await next();
        Console.WriteLine($"ResourceFilterAttributeAsync_ After async {_name}");
    }
}

namespace FiltersInMVC;
using Microsoft.AspNetCore.Mvc.Filters;
public class ActionFilterAttributeAsync : Attribute, IAsyncActionFilter, IOrderedFilter
{
    public int Order { get; set; }
    public string _name { get; }
    public ActionFilterAttributeAsync(string name, int order = 5)
    {
        _name = name;
        Order = order;
    }
    public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        Console.WriteLine($"ActionFilterAttributeAsync_ Before async {_name} {Order}");
        await next();
        Console.WriteLine($"ActionFilterAttributeAsync_ After async {_name} {Order}");
    }
}

namespace FiltersInMVC;
using Microsoft.AspNetCore.Mvc.Filters;
public class ActionFilterAttribute : Attribute, IActionFilter, IOrderedFilter
{
    public int Order { get; set; }
    public readonly string _name;
    public ActionFilterAttribute(string name, int order = 1)
    {
        _name = name;
        Order = order;
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
        Console.WriteLine($"OnActionExecuted - {_name}");
    }

    public void OnActionExecuting(ActionExecutingContext context)
    {
        Console.WriteLine($"OnActionExecuting - {_name}");
    }
}

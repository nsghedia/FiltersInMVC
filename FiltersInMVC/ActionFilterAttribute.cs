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

    public void OnActionExecuting(ActionExecutingContext context)
    {
        Console.WriteLine($"ActionFilterAttribute_ Before {_name} {Order}");
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
        Console.WriteLine($"ActionFilterAttribute_ After {_name} {Order}");
    }
}

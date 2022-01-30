﻿using Microsoft.AspNetCore.Mvc.Filters;

namespace FiltersInMVC;
public class ResourceFilterAttribute : Attribute, IResourceFilter
{
    public readonly string _name;
    public ResourceFilterAttribute(string name)
    {
        _name = name;
    }
    public void OnResourceExecuting(ResourceExecutingContext context)
    {
        Console.WriteLine($"ResourceFilterAttribute_ Before {_name}");
    }

    public void OnResourceExecuted(ResourceExecutedContext context)
    {
        Console.WriteLine($"ResourceFilterAttribute_ After {_name}");
    }
}

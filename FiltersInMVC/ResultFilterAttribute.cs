using Microsoft.AspNetCore.Mvc.Filters;

namespace FiltersInMVC;
public class ResultFilterAttribute : Attribute, IResultFilter
{
    public ILogger<ResultFilterAttribute> _logger { get; }
    private readonly Guid _MyInstanceID;
    private readonly string _name;
    public ResultFilterAttribute(ILogger<ResultFilterAttribute> logger, string name = "Global")
    {
        _logger = logger;
        _name = name;
        _MyInstanceID = Guid.NewGuid();
    }
    public void OnResultExecuting(ResultExecutingContext context)
    {
        _logger.LogInformation($"ResultFilterAttribute_Before {_name} {_MyInstanceID}");
    }
    public void OnResultExecuted(ResultExecutedContext context)
    {
        _logger.LogInformation($"ResultFilterAttribute_After {_name} {_MyInstanceID}");
    }
}

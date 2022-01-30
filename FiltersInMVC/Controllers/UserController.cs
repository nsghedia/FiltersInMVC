namespace FiltersInMVC.Controllers;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
[ActionFilterAttributeAsync("UserController", -10)]
[ResourceFilterAttribute("UserController")]
public class UserController : ControllerBase
{
    // GET: api/<UserController>
    [HttpGet]
    [ActionFilterAttributeAsync("UserController_Action", -100)]
    [ResourceFilterAttribute("UserController_Action")]
    //[ServiceFilterAttribute(typeof(ResultFilterAttribute))]
    [TypeFilter(typeof(ResultFilterAttribute), Arguments = new object[] { "Action" })]
    public IEnumerable<string> Get()
    {
        return new string[] { "value1", "value2", "UserController" };
    }

    // GET api/<UserController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/<UserController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<UserController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<UserController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}

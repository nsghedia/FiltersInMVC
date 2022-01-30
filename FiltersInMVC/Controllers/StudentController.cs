namespace FiltersInMVC.Controllers;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
[ActionFilterAttribute("StudentController")]
public class StudentController : ControllerBase
{
    // GET: api/<StudentController>
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "value1", "value2", "StudentController" };
    }

    // GET api/<StudentController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/<StudentController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<StudentController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<StudentController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}

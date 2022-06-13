using Microsoft.AspNetCore.Mvc;

namespace SimpleApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ValuesController : ControllerBase
{
    // Get api/values
    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
        return new string[]{ "dotnet", "playbook" };
    }

    // Get api/values/1
    [HttpGet("{id}")]
    public ActionResult<string> Get(int id)
    {
        return "Tosa Ojiru";
    }
}
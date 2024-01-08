using Microsoft.AspNetCore.Mvc;

namespace FooA_Challenge_EndpointAPI.Controllers;

[ApiController]
[Route("Hello")]
public class HelloEndpoint
{
    [HttpGet]
    [Route("{name}")]
    public string SayHello(string name){
        return $"Hello, {name}";
    }
    
}

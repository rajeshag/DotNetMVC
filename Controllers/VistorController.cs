using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
//using Vistor.Service;


namespace Controllers
{
[ApiController]
[Route("[controller]")]
public class VistorController(IVistor myService): ControllerBase
{
   /* private readonly IVistor _myService;

    public ApiController(IVistor myService)
    {
        _myService = myService;
    }*/
   
   [HttpPost("/vistor/entry")]
    public async Task<IActionResult> vistorEntry(Vistor vistor)
    {
         myService.entry(vistor);
         return Ok();
    }

    [HttpDelete("/vistor/delete")]
    public async Task<IActionResult> vistorDelete(Vistor vistor)
    {
         myService.delete(vistor);
         return Ok();
    }

    [HttpGet("/vistor/get")]
    public async Task<IActionResult> vistorGet(Vistor vistor)
    {
         myService.fetch(vistor);
         return Ok();
    }

    [HttpGet("/vistor/edit")]
    public async Task<IActionResult> vistorEdit(Vistor vistor)
    {
         myService.edit(vistor);
         return Ok();
    }
}
}
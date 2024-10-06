using Microsoft.AspNetCore.Mvc;
using USP.Application.Product.Commands;
using USP.Application.Product.Queires;

namespace USP.API.Controllers;

public class ProductController : ApiBaseController
{

    [HttpGet]
    public async Task<ActionResult> Get([FromQuery] GetOneProductQuery query)
    {
        return Ok(await Mediator.Send(query));
    }

    [HttpPost]
    public async Task<ActionResult> Create(CreateProductCommand command
    ) => Ok(await Mediator.Send(command));
}
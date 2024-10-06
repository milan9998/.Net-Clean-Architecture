using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace USP.API.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class ApiBaseController : ControllerBase
{
    private ISender? _sender;
    protected ISender Mediator => _sender ??= HttpContext.RequestServices.GetService<ISender>();
}
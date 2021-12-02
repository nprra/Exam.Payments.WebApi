using Microsoft.AspNetCore.Mvc;

namespace Exam.Payments.WebApi.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseController : ControllerBase
    {
    }
}

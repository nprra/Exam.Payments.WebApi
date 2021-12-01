using Exam.Payments.WebApi.Application.Accounts.Commands;
using Exam.Payments.WebApi.Application.Accounts.Queries;
using Exam.Payments.WebApi.Domain;
using Exam.Payments.WebApi.Domain.Accounts;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Exam.Payments.WebApi.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        public AccountsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost(nameof(CreateAccount))]
        public async Task<IActionResult> CreateAccount(Account account)
        {
            var result = _unitOfWork.Accounts.Add(account);
            _unitOfWork.Complete();

            if(result != null)
            {
                return Ok("Account Created");
            }
            else
            {
                return BadRequest("Error creating account");
            }
        }

        [HttpGet]
        public async Task<IActionResult> Get() => Ok(await _unitOfWork.Accounts.GetAllAsync());

    }
}

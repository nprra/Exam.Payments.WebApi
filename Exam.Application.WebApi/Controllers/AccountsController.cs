using Exam.Payments.WebApi.Application.Accounts.Commands;
using Exam.Payments.WebApi.Application.Accounts.Queries;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Exam.Payments.WebApi.Host.Controllers
{
    public class AccountsController : BaseController
    {
        [HttpPost(nameof(CreateAccount))]
        public async Task<IActionResult> CreateAccount(CreateAccountCommand command) => Ok(await Mediator.Send(command));

        [HttpGet]
        public async Task<IActionResult> GetAllPayments() => Ok(await Mediator.Send(new GetAccountsQuery()));

    }
}

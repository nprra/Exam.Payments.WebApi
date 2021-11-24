using Exam.Payments.WebApi.Application.Payments.Commands.CreatePaymentItem;
using Exam.Payments.WebApi.Application.Payments.Queries;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Exam.Payments.WebApi.Host.Controllers
{
    public class PaymentsController : BaseController
    {
        [HttpPost(nameof(CreatePaymentItem))]
        public async Task<IActionResult> CreatePaymentItem(CreatePaymentItemCommand command) => Ok(await Mediator.Send(command));

        [HttpGet]
        public async Task<IActionResult> GetAllPayments() => Ok(await Mediator.Send(new GetPaymentsQuery()));
    }
}

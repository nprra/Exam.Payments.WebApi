using Exam.Payments.WebApi.Application.Payments.Commands.CreatePaymentItem;
using Exam.Payments.WebApi.Application.Payments.Queries;
using Exam.Payments.WebApi.Domain;
using Exam.Payments.WebApi.Domain.Payments;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Exam.Payments.WebApi.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        public PaymentsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost(nameof(CreatePayment))]
        public async Task<IActionResult> CreatePayment(Payment payment)
        {
            var result = _unitOfWork.Payments.Add(payment);
            _unitOfWork.Complete();

            if (result != null)
            {
                return Ok("Payment Created");
            }
            else
            {
                return BadRequest("Error creating payment");
            }
        }

        [HttpGet]
        public async Task<IActionResult> Get() => Ok(await _unitOfWork.Payments.GetAllAsync());


        //[HttpPost(nameof(CreatePaymentItem))]
        //public async Task<IActionResult> CreatePaymentItem(CreatePaymentItemCommand command) => Ok(await Mediator.Send(command));

        //[HttpGet]
        //public async Task<IActionResult> GetAllPayments() => Ok(await Mediator.Send(new GetPaymentsQuery()));
    }
}

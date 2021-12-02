using Exam.Payments.WebApi.Domain;
using Exam.Payments.WebApi.Domain.Accounts;
using Exam.Payments.WebApi.Domain.Logger;
using Exam.Payments.WebApi.Domain.Payments;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Exam.Payments.WebApi.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogManager _logger;
        public PaymentsController(IUnitOfWork unitOfWork, ILogManager logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        [HttpPost(nameof(CreatePayment))]
        public IActionResult CreatePayment(Payment payment)
        {
            _logger.LogInfo("Attempting to create payment");

            var accountTask = _unitOfWork.Accounts.GetAsync(payment.AccountId);

            if (accountTask.Result == null)
            {
                _logger.LogWarning($"Unable to add payment to invalid account with id {payment.AccountId}.");
                return BadRequest($"Cannot find account with id {payment.AccountId}.");
            }

            if (accountTask.Result.Status != AccountStatus.Open)
            {
                _logger.LogWarning($"Unable to add payment to non-open account with id {payment.AccountId}.");
                return BadRequest($"Account with id {payment.AccountId}. is not open yet.");
            }

            var result = _unitOfWork.Payments.Add(payment);
            _unitOfWork.Complete();

            if (result != null)
            {
                var resultSuccessMessage = "Payment Created";
                _logger.LogInfo(resultSuccessMessage);
                return Ok(resultSuccessMessage);
            }
            else
            {
                var emptyResult = "Creation result is null. Please contact your administrator.";
                _logger.LogWarning(emptyResult);
                return BadRequest(emptyResult);
            }

        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _unitOfWork.Payments.GetAllAsync());
        }
    }
}

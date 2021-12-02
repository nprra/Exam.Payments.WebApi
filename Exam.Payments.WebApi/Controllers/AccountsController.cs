using Exam.Payments.WebApi.Domain;
using Exam.Payments.WebApi.Domain.Accounts;
using Exam.Payments.WebApi.Domain.Logger;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Exam.Payments.WebApi.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : BaseController
    {
        private readonly ILogManager _logger;
        private readonly IUnitOfWork _unitOfWork;
        public AccountsController(IUnitOfWork unitOfWork, ILogManager logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        [HttpPost(nameof(CreateAccount))]
        public IActionResult CreateAccount(Account account)
        {
            _logger.LogInfo("Attempting to create account");

            var result = _unitOfWork.Accounts.Add(account);
            _unitOfWork.Complete();

            if (result != null)
            {
                var resultSuccessMessage = "Account created";
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
            _logger.LogInfo("Attempting to retrieve all accounts");

            var result = await _unitOfWork.Accounts.GetAllAsync();

            _logger.LogInfo("Completed accounts retrieval");
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAccountById(Guid id)
        {
            _logger.LogInfo($"Attempting to retrieve Account with id {id}");

            var result = await _unitOfWork.Accounts.GetAsync(id);

            _logger.LogInfo("Completed account retrieval");
            return Ok(result);
        }


    }
}

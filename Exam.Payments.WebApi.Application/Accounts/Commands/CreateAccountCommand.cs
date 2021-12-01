using Exam.Payments.WebApi.Domain.Accounts;
using MediatR;

namespace Exam.Payments.WebApi.Application.Accounts.Commands
{
    public class CreateAccountCommand : IRequest<int>
    {
        public Account Item { get; set; }
    }
}

using Exam.Application.WebApi.Domain.Accounts;
using MediatR;

namespace Exam.Application.WebApi.Application.Accounts.Commands
{
    public class CreateAccountCommand : IRequest<int>
    {
        public Account Item { get; set; }
    }
}

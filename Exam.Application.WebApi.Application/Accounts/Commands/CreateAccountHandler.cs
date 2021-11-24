using Exam.Payments.WebApi.Infrastructure.SqlData;
using MediatR;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace Exam.Payments.WebApi.Application.Accounts.Commands
{
    public class CreateAccountHandler : IRequestHandler<CreateAccountCommand, int>
    {
        public ApplicationDbContext _context;
        public CreateAccountHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateAccountCommand request,
            CancellationToken cancellationToken)
        {
            _context.Account.Add(request.Item);
            await _context.SaveChangesAsync();

            return (int)HttpStatusCode.OK;
        }
    }
}

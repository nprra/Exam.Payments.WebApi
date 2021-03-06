using Exam.Payments.WebApi.Infrastructure;
using MediatR;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace Exam.Payments.WebApi.Application.Payments.Commands.CreatePaymentItem
{
    public class CreatePaymentItemHandler : IRequestHandler<CreatePaymentItemCommand, int>
    {
        public ApplicationDbContext _context;
        public CreatePaymentItemHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreatePaymentItemCommand request,
            CancellationToken cancellationToken)
        {
            _context.Payments.Add(request.Item);
            await _context.SaveChangesAsync();

            return (int)HttpStatusCode.OK;
        }
    }
}

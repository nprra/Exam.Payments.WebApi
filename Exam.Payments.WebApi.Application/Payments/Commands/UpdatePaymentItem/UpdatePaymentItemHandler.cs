using Exam.Payments.WebApi.Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace Exam.Payments.WebApi.Application.Payments.Commands.UpdatePaymentItem
{
    public class UpdatePaymentItemHandler : 
        IRequestHandler<UpdatePaymentItemCommand, int>
    {
        public ApplicationDbContext _context;
        public UpdatePaymentItemHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(UpdatePaymentItemCommand request, 
            CancellationToken cancellationToken)
        {
            if (request.Id != request.Item.Id)
            {
                return (int)HttpStatusCode.BadRequest;
            }

            _context.Entry(request.Item).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PaymentItemExists(request.Id))
                {
                    return (int)HttpStatusCode.NotFound;
                }
                else
                {
                    throw;
                }
            }

            return (int)HttpStatusCode.NoContent;
        }

        private bool PaymentItemExists(Guid id)
        {
            return _context.Payments.Any(e => e.Id == id);
        }
    }
}

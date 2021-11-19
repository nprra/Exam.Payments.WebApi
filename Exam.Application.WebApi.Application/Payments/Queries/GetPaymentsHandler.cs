using Exam.Application.WebApi.Domain.Payments;
using Exam.Application.WebApi.Infrastructure.SqlData;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Exam.Application.WebApi.Application.Payments.Queries
{
    public class GetPaymentsHandler: IRequestHandler<GetPaymentsQuery, IList<Payment>>
    {
        public ApplicationDbContext _context;
        public GetPaymentsHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IList<Payment>> Handle(GetPaymentsQuery query, CancellationToken cancellationToken)
        {
            return await _context.Payment.ToListAsync();
        }
    }
}

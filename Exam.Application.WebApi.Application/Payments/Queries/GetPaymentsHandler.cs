using Exam.Payments.WebApi.Domain.Payments;
using Exam.Payments.WebApi.Infrastructure.SqlData;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Exam.Payments.WebApi.Application.Payments.Queries
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
            return await _context.Set<Payment>().OrderByDescending(item => item.Date).ToListAsync();
        }
    }
}

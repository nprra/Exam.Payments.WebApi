using Exam.Payments.WebApi.Domain.Accounts;
using Exam.Payments.WebApi.Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Exam.Payments.WebApi.Application.Accounts.Queries
{
    public class GetAccountsHandler : IRequestHandler<GetAccountsQuery, IList<Account>>
    {
        public ApplicationDbContext _context;
        public GetAccountsHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IList<Account>> Handle(GetAccountsQuery query, CancellationToken cancellationToken)
        {
            return await _context.Accounts.ToListAsync();
        }
    }
}

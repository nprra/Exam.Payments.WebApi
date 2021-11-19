using Exam.Application.WebApi.Domain.Accounts;
using Exam.Application.WebApi.Infrastructure.SqlData;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Exam.Application.WebApi.Application.Accounts.Queries
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
            return await _context.Account.ToListAsync();
        }
    }
}

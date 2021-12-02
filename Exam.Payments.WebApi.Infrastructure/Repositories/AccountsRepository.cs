using Exam.Payments.WebApi.Domain.Accounts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam.Payments.WebApi.Infrastructure.Repositories
{
    public class AccountsRepository : GenericRepository<Account>, IAccountsRepository
    {
        public AccountsRepository(ApplicationDbContext context): base(context)
        {

        }

        public async Task<IEnumerable<Account>> GetAccountByAccountNumber(string accountNumber)
        {
            return await _context.Accounts.Where(c => c.AccountNumber.Contains(accountNumber)).ToListAsync();
        }
    }
}

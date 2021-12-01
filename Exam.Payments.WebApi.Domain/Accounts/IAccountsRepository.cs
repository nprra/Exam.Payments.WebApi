using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Payments.WebApi.Domain.Accounts
{
    public interface IAccountsRepository: IGenericRepository<Account>
    {
        Task<IEnumerable<Account>> GetAccountByAccountNumber(string accountNumber);
    }
}

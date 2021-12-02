using System.Collections.Generic;
using System.Threading.Tasks;

namespace Exam.Payments.WebApi.Domain.Accounts
{
    public interface IAccountsRepository: IGenericRepository<Account>
    {
        Task<IEnumerable<Account>> GetAccountByAccountNumber(string accountNumber);
    }
}

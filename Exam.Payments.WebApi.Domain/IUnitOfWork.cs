using Exam.Payments.WebApi.Domain.Accounts;
using Exam.Payments.WebApi.Domain.Payments;
using Exam.Payments.WebApi.Domain.Users;

namespace Exam.Payments.WebApi.Domain
{
    public interface IUnitOfWork
    {
        IAccountsRepository Accounts { get; }
        IPaymentsRepository Payments{ get; }
        IUsersRepository Users { get; }
        int Complete();
    }
}

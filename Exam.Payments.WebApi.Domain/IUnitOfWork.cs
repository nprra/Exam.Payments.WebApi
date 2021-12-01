using Exam.Payments.WebApi.Domain.Accounts;
using Exam.Payments.WebApi.Domain.Payments;
using Exam.Payments.WebApi.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

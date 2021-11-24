using Exam.Payments.WebApi.Domain.Accounts;
using MediatR;
using System.Collections.Generic;

namespace Exam.Payments.WebApi.Application.Accounts.Queries
{
    public class GetAccountsQuery : IRequest<IList<Account>>
    {
    }
}

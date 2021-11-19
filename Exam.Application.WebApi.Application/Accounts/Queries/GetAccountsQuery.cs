using Exam.Application.WebApi.Domain.Accounts;
using MediatR;
using System.Collections.Generic;

namespace Exam.Application.WebApi.Application.Accounts.Queries
{
    public class GetAccountsQuery : IRequest<IList<Account>>
    {
    }
}

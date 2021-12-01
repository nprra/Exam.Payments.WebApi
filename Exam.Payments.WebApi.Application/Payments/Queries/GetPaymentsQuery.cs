using Exam.Payments.WebApi.Domain.Payments;
using MediatR;
using System.Collections.Generic;

namespace Exam.Payments.WebApi.Application.Payments.Queries
{
    public class GetPaymentsQuery : IRequest<IList<Payment>>
    {
    }
}

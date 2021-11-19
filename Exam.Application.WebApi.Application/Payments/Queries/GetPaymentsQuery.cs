using Exam.Application.WebApi.Domain.Payments;
using MediatR;
using System.Collections.Generic;

namespace Exam.Application.WebApi.Application.Payments.Queries
{
    public class GetPaymentsQuery : IRequest<IList<Payment>>
    {
    }
}

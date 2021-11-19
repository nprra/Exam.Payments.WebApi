using Exam.Application.WebApi.Domain.Payments;
using MediatR;

namespace Exam.Application.WebApi.Application.Payments.Commands.CreatePaymentItem
{
    public class CreatePaymentItemCommand: IRequest<int>
    {
        public Payment Item { get; set; }
    }
}

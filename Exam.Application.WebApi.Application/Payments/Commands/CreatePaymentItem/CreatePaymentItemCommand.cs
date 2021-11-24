using Exam.Payments.WebApi.Domain.Payments;
using MediatR;

namespace Exam.Payments.WebApi.Application.Payments.Commands.CreatePaymentItem
{
    public class CreatePaymentItemCommand: IRequest<int>
    {
        public Payment Item { get; set; }
    }
}

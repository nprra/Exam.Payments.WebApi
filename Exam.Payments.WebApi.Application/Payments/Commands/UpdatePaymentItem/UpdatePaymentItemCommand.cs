using Exam.Payments.WebApi.Domain.Payments;
using MediatR;
using System;
using System.ComponentModel.DataAnnotations;

namespace Exam.Payments.WebApi.Application.Payments.Commands.UpdatePaymentItem
{
    public class UpdatePaymentItemCommand : IRequest<int>
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public Payment Item { get; set; }
    }
}

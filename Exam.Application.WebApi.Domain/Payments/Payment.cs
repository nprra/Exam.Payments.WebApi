using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exam.Payments.WebApi.Domain.Payments
{
    public class Payment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        public long Amount { get; set; }
        public DateTime Date { get; set; }
        public PaymentStatus Status { get; set; }
        public string? Reason { get; set; }
    }
}

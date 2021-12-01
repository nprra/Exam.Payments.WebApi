using Exam.Payments.WebApi.Domain.Payments;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exam.Payments.WebApi.Domain.Accounts
{
    public class Account
    {
        // Assumption that accounts do not have multiple types
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string AccountNumber { get; set; }
        public long Balance { get; set; }
        public AccountStatus Status { get; set; }
    }
}

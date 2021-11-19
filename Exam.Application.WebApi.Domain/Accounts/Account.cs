using Exam.Application.WebApi.Domain.Payments;
using System;
using System.Collections.Generic;

namespace Exam.Application.WebApi.Domain.Accounts
{
    public class Account
    {
        // Assumption that accounts do not have multiple types
        public Guid Id { get; set; }
        public long Balance { get; set; }
        public AccountStatus Status { get; set; }
        // Assumption that an account has a list of Payments
        public IEnumerable<Payment> Payments { get; set; }
    }
}

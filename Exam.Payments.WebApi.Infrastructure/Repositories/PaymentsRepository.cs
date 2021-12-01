using Exam.Payments.WebApi.Domain.Payments;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Payments.WebApi.Infrastructure.Repositories
{
    public class PaymentsRepository: GenericRepository<Payment>, IPaymentsRepository
    {
        public PaymentsRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Payments.WebApi.Domain.Payments
{
    public interface IPaymentsRepository: IGenericRepository<Payment>
    {
    }
}

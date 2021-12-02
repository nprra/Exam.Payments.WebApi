using Exam.Payments.WebApi.Domain.Payments;

namespace Exam.Payments.WebApi.Infrastructure.Repositories
{
    public class PaymentsRepository: GenericRepository<Payment>, IPaymentsRepository
    {
        public PaymentsRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

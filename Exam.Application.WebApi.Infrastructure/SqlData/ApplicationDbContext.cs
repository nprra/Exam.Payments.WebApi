using Exam.Payments.WebApi.Domain.Accounts;
using Exam.Payments.WebApi.Domain.Payments;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Exam.Payments.WebApi.Infrastructure.SqlData
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Payment> Payment { get; set; }
        public DbSet<Account> Account { get; set; }
    }
}

using Exam.Payments.WebApi.Domain.Accounts;
using Exam.Payments.WebApi.Domain.Logger;
using Exam.Payments.WebApi.Domain.Payments;
using Exam.Payments.WebApi.Domain.Users;
using Microsoft.EntityFrameworkCore;

namespace Exam.Payments.WebApi.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Payment> Payments { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Logs> Logs { get; set; }
    }
}

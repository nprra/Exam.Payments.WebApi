using Exam.Payments.WebApi.Domain;
using Exam.Payments.WebApi.Domain.Accounts;
using Exam.Payments.WebApi.Domain.Payments;
using Exam.Payments.WebApi.Domain.Users;
using Exam.Payments.WebApi.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Exam.Payments.WebApi.Infrastructure
{
    public static class DependencyInjection
    {
        public static void AddDbServices(this IServiceCollection services)
        {
            services.AddTransient<IAccountsRepository, AccountsRepository>();
            services.AddTransient<IPaymentsRepository, PaymentsRepository>();
            services.AddTransient<IUsersRepository, UsersRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            services.AddDbContext<ApplicationDbContext>(opt => opt
                .UseSqlServer("Server=localhost\\SQLEXPRESS; Database=exampayments;Trusted_Connection=True;"));
        }
    }
}

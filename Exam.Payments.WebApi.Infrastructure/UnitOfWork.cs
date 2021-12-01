using Exam.Payments.WebApi.Domain;
using Exam.Payments.WebApi.Domain.Accounts;
using Exam.Payments.WebApi.Domain.Payments;
using Exam.Payments.WebApi.Domain.Users;
using System;

namespace Exam.Payments.WebApi.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IAccountsRepository Accounts { get; }
        public IPaymentsRepository Payments { get; }
        public IUsersRepository Users { get; }

        public UnitOfWork(ApplicationDbContext context,
            IAccountsRepository accountsRepository,
            IPaymentsRepository paymentsRepository,
            IUsersRepository usersRepository
            )
        {
            _context = context;
            Accounts = accountsRepository;
            Payments = paymentsRepository;
            Users = usersRepository;
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }
    }
}

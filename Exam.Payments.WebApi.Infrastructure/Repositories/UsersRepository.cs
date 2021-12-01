using Exam.Payments.WebApi.Domain.Users;
using Microsoft.Extensions.Logging;

namespace Exam.Payments.WebApi.Infrastructure.Repositories
{
    public class UsersRepository: GenericRepository<User>, IUsersRepository
    {
        public UsersRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

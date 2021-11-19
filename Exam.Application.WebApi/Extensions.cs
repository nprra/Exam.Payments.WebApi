using Exam.Application.WebApi.Infrastructure.SqlData;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Exam.Application.WebApi.Host
{
    public static class Extensions
    {
        public static void AddDbServices(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(opt => 
                opt.UseInMemoryDatabase("Exam.Application"));
        }
    }
}

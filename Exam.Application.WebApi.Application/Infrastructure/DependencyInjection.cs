using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Exam.Payments.WebApi.Application.Infrastructure
{
    public static class DependencyInjection
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
        }
    }
}

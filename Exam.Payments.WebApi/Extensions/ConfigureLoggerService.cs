using Exam.Payments.WebApi.Domain.Logger;
using Exam.Payments.WebApi.Host.Logger;
using Microsoft.Extensions.DependencyInjection;

namespace Exam.Payments.WebApi.Host.Extensions
{
    public static class Extensions
    {
        public static void ConfigureLoggerService(this IServiceCollection services)
        {
            services.AddSingleton<ILogManager, LogManager>();
        }
    }
}

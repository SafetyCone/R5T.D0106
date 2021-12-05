using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.D0103;
using R5T.D0107;
using R5T.T0063;


namespace R5T.D0106.D002.I001
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="ProcessStartTimeDirectoryNameProvider"/> implementation of <see cref="IProcessStartTimeDirectoryNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddProcessStartTimeDirectoryNameProvider(this IServiceCollection services,
            IServiceAction<IProcessStartTimeProvider> processStartTimeProviderAction,
            IServiceAction<IDateTimeDirectoryNameProvider> dateTimeDirectoryNameProviderAction)
        {
            services
                .Run(processStartTimeProviderAction)
                .Run(dateTimeDirectoryNameProviderAction)
                .AddSingleton<IProcessStartTimeDirectoryNameProvider, ProcessStartTimeDirectoryNameProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="ProcessDirectoryNameProvider"/> implementation of <see cref="IProcessDirectoryNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddProcessDirectoryNameProvider(this IServiceCollection services,
            IServiceAction<IProcessNameProvider> processNameProviderAction,
            IServiceAction<IDirectoryNameProvider> directoryNameProviderAction)
        {
            services
                .Run(processNameProviderAction)
                .Run(directoryNameProviderAction)
                .AddSingleton<IProcessDirectoryNameProvider, ProcessDirectoryNameProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="YYYYMMDD_HHMMSS_DateTimeDirectoryNameProvider"/> implementation of <see cref="IDateTimeDirectoryNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddYYYYMMDD_HHMMSS_DateTimeDirectoryNameProvider(this IServiceCollection services)
        {
            services.AddSingleton<IDateTimeDirectoryNameProvider, YYYYMMDD_HHMMSS_DateTimeDirectoryNameProvider>();

            return services;
        }
    }
}
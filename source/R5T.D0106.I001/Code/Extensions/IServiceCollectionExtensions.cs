using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.T0062;
using R5T.T0063;


namespace R5T.D0106.I001
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="DirectDirectoryNameProvider"/> implementation of <see cref="IDirectoryNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDirectDirectoryNameProvider(this IServiceCollection services)
        {
            services.AddSingleton<IDirectoryNameProvider, DirectDirectoryNameProvider>();

            return services;
        }
    }
}
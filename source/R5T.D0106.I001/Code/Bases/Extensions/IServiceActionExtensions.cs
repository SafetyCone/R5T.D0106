using System;

using R5T.T0062;
using R5T.T0063;

namespace R5T.D0106.I001
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Adds the <see cref="DirectDirectoryNameProvider"/> implementation of <see cref="IDirectoryNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IDirectoryNameProvider> AddDirectDirectoryNameProviderAction(this IServiceAction _)
        {
            var serviceAction = _.New<IDirectoryNameProvider>(services => services.AddDirectDirectoryNameProvider());
            return serviceAction;
        }
    }
}

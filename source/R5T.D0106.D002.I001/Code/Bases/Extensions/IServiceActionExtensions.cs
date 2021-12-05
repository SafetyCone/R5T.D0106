using System;

using R5T.D0103;
using R5T.D0107;
using R5T.T0062;
using R5T.T0063;


namespace R5T.D0106.D002.I001
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Adds the <see cref="ProcessStartTimeDirectoryNameProvider"/> implementation of <see cref="IProcessStartTimeDirectoryNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IProcessStartTimeDirectoryNameProvider> AddProcessStartTimeDirectoryNameProviderAction(this IServiceAction _,
            IServiceAction<IProcessStartTimeProvider> processStartTimeProviderAction,
            IServiceAction<IDateTimeDirectoryNameProvider> dateTimeDirectoryNameProviderAction)
        {
            var serviceAction = _.New<IProcessStartTimeDirectoryNameProvider>(services => services.AddProcessStartTimeDirectoryNameProvider(
                processStartTimeProviderAction,
                dateTimeDirectoryNameProviderAction));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="ProcessDirectoryNameProvider"/> implementation of <see cref="IProcessDirectoryNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IProcessDirectoryNameProvider> AddProcessDirectoryNameProviderAction(this IServiceAction _,
            IServiceAction<IProcessNameProvider> processNameProviderAction,
            IServiceAction<IDirectoryNameProvider> directoryNameProviderAction)
        {
            var serviceAction = _.New<IProcessDirectoryNameProvider>(services => services.AddProcessDirectoryNameProvider(
                processNameProviderAction,
                directoryNameProviderAction));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="YYYYMMDD_HHMMSS_DateTimeDirectoryNameProvider"/> implementation of <see cref="IDateTimeDirectoryNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IDateTimeDirectoryNameProvider> AddYYYYMMDD_HHMMSS_DateTimeDirectoryNameProviderAction(this IServiceAction _)
        {
            var serviceAction = _.New<IDateTimeDirectoryNameProvider>(services => services.AddYYYYMMDD_HHMMSS_DateTimeDirectoryNameProvider());
            return serviceAction;
        }
    }
}

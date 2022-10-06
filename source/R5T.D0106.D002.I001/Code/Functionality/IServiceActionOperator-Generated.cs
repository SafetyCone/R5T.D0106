using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.D0103;
using R5T.D0106;
using R5T.D0106.D002;
using R5T.D0107;
using R5T.T0132;
using R5T.T0147;


namespace R5T.D0106.D002.I001
{
	[FunctionalityMarker]
	public partial interface IServiceActionOperator : IFunctionalityMarker,
		R5T.T0147.IServiceActionOperator
	{
		/// <summary>
		/// Adds the <see cref="ProcessDirectoryNameProvider"/> implementation of <see cref="IProcessDirectoryNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
		/// </summary>
		public IServiceAction<IProcessDirectoryNameProvider> AddProcessDirectoryNameProviderAction(
			IServiceAction<IProcessNameProvider> processNameProvider,
			IServiceAction<IDirectoryNameProvider> directoryNameProvider)
		{
			var serviceAction = this.New<IProcessDirectoryNameProvider>(services => services.AddProcessDirectoryNameProvider(
				processNameProvider,
				directoryNameProvider));
		
			return serviceAction;
		}
		/// <summary>
		/// Adds the <see cref="ProcessStartTimeDirectoryNameProvider"/> implementation of <see cref="IProcessStartTimeDirectoryNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
		/// </summary>
		public IServiceAction<IProcessStartTimeDirectoryNameProvider> AddProcessStartTimeDirectoryNameProviderAction(
			IServiceAction<IDateTimeDirectoryNameProvider> dateTimeDirectoryNameProvider,
			IServiceAction<IProcessStartTimeProvider> processStartTimeProvider)
		{
			var serviceAction = this.New<IProcessStartTimeDirectoryNameProvider>(services => services.AddProcessStartTimeDirectoryNameProvider(
				dateTimeDirectoryNameProvider,
				processStartTimeProvider));
		
			return serviceAction;
		}
		/// <summary>
		/// Adds the <see cref="YYYYMMDD_HHMMSS_DateTimeDirectoryNameProvider"/> implementation of <see cref="IDateTimeDirectoryNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
		/// </summary>
		public IServiceAction<IDateTimeDirectoryNameProvider> AddYYYYMMDD_HHMMSS_DateTimeDirectoryNameProviderAction()
		{
			var serviceAction = this.New<IDateTimeDirectoryNameProvider>(services => services.AddYYYYMMDD_HHMMSS_DateTimeDirectoryNameProvider());
		
			return serviceAction;
		}
	}
}

using System;
using System.Threading.Tasks;

using R5T.D0103;
using R5T.T0064;


namespace R5T.D0106.D002.I001
{
    [ServiceImplementationMarker]
    public class ProcessStartTimeDirectoryNameProvider : IProcessStartTimeDirectoryNameProvider, IServiceImplementation
    {
        private IDateTimeDirectoryNameProvider DateTimeDirectoryNameProvider { get; }
        private IProcessStartTimeProvider ProcessStartTimeProvider { get; }


        public ProcessStartTimeDirectoryNameProvider(
            IDateTimeDirectoryNameProvider dateTimeDirectoryNameProvider,
            IProcessStartTimeProvider processStartTimeProvider)
        {
            this.ProcessStartTimeProvider = processStartTimeProvider;
            this.DateTimeDirectoryNameProvider = dateTimeDirectoryNameProvider;
        }

        public async Task<string> GetProcessStartTimeDirectoryName()
        {
            var processStartTime = await this.ProcessStartTimeProvider.GetProcessStartTime();

            var output = await this.DateTimeDirectoryNameProvider.GetDateTimeDirectoryName(processStartTime);
            return output;
        }
    }
}

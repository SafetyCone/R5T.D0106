﻿using System;
using System.Threading.Tasks;

using R5T.D0107;
using R5T.T0064;


namespace R5T.D0106.D002.I001
{
    [ServiceImplementationMarker]
    public class ProcessDirectoryNameProvider : IProcessDirectoryNameProvider, IServiceImplementation
    {
        private IProcessNameProvider ProcessNameProvider { get; }
        private IDirectoryNameProvider DirectoryNameProvider { get; }


        public ProcessDirectoryNameProvider(
            IProcessNameProvider processNameProvider,
            IDirectoryNameProvider directoryNameProvider)
        {
            this.ProcessNameProvider = processNameProvider;
            this.DirectoryNameProvider = directoryNameProvider;
        }

        public async Task<string> GetProcessDirectoryName()
        {
            var processName = await this.ProcessNameProvider.GetProcessName();

            var output = await this.DirectoryNameProvider.GetDirectoryName(processName);
            return output;
        }
    }
}

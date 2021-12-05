using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0106.D002
{
    [ServiceDefinitionMarker]
    public interface IProcessDirectoryNameProvider : IServiceDefinition
    {
        Task<string> GetProcessDirectoryName();
    }
}

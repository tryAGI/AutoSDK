//HintName: G.IApi.DeployGpuAvailabilityDeployLlmGpuAvailabilityGet.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Deploy Gpu Availability
        /// </summary>
        /// <param name="source"></param>
        /// <param name="baseModel"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeployGPUAvailability> DeployGpuAvailabilityDeployLlmGpuAvailabilityGetAsync(
            string? source = default,
            string? baseModel = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
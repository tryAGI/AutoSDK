//HintName: G.ICloudClient.GetAcceleratorAvailability.g.cs
#nullable enable

namespace G
{
    public partial interface ICloudClient
    {
        /// <summary>
        /// Get Accelerator Availability
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetAcceleratorAvailabilityV4CloudProviderGcpAcceleratorAvailabilityGetResponse> GetAcceleratorAvailabilityAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
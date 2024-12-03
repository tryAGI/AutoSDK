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
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetAcceleratorAvailabilityAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
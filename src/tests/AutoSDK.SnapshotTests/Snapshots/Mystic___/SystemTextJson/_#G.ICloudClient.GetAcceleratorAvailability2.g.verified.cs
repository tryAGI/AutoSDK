//HintName: G.ICloudClient.GetAcceleratorAvailability2.g.cs
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
        global::System.Threading.Tasks.Task<string> GetAcceleratorAvailability2Async(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
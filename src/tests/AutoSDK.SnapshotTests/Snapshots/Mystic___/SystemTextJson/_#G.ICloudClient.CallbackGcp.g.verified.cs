//HintName: G.ICloudClient.CallbackGcp.g.cs
#nullable enable

namespace G
{
    public partial interface ICloudClient
    {
        /// <summary>
        /// Callback Gcp
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CallbackGcpAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
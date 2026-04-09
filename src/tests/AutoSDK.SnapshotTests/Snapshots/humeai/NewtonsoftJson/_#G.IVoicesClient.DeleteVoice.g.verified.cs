//HintName: G.IVoicesClient.DeleteVoice.g.cs
#nullable enable

namespace G
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Delete a custom voice
        /// </summary>
        /// <param name="name"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteVoiceAsync(
            string name,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
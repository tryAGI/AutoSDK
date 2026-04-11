//HintName: G.IOllieStateClient.DownloadOllieState.g.cs
#nullable enable

namespace G
{
    public partial interface IOllieStateClient
    {
        /// <summary>
        /// Download ollie state<br/>
        /// Download stored ollie state file
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> DownloadOllieStateAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
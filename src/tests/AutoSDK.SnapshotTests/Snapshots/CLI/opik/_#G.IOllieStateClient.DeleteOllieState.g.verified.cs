//HintName: G.IOllieStateClient.DeleteOllieState.g.cs
#nullable enable

namespace G
{
    public partial interface IOllieStateClient
    {
        /// <summary>
        /// Delete ollie state<br/>
        /// Clear stored ollie state
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteOllieStateAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
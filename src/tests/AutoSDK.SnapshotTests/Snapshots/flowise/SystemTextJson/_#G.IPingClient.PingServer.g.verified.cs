//HintName: G.IPingClient.PingServer.g.cs
#nullable enable

namespace G
{
    public partial interface IPingClient
    {
        /// <summary>
        /// Ping the server<br/>
        /// Ping the server to check if it is running
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> PingServerAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
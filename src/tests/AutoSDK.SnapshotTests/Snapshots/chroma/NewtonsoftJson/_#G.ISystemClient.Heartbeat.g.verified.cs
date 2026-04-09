//HintName: G.ISystemClient.Heartbeat.g.cs
#nullable enable

namespace G
{
    public partial interface ISystemClient
    {
        /// <summary>
        /// Heartbeat<br/>
        /// Returns a nanosecond timestamp of the current time.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// const timestamp = await client.heartbeat();
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.HeartbeatResponse> HeartbeatAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
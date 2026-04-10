//HintName: G.IEnvironmentsClient.EnvironmentsListConnections.g.cs
#nullable enable

namespace G
{
    public partial interface IEnvironmentsClient
    {
        /// <summary>
        /// List Environment Connections<br/>
        /// List all active environment connections for the organization
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="after"></param>
        /// <param name="userId"></param>
        /// <param name="onlineOnly"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EnvironmentsListConnectionsResponse> EnvironmentsListConnectionsAsync(
            string? limit = default,
            string? after = default,
            string? userId = default,
            string? onlineOnly = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
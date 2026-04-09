//HintName: G.IServiceHealthClient.HealthCheck.g.cs
#nullable enable

namespace G
{
    public partial interface IServiceHealthClient
    {
        /// <summary>
        /// Returns the status of the server
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.HealthCheck> HealthCheckAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
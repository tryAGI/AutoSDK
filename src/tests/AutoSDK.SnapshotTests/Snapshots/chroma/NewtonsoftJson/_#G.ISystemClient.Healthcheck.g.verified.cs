//HintName: G.ISystemClient.Healthcheck.g.cs
#nullable enable

namespace G
{
    public partial interface ISystemClient
    {
        /// <summary>
        /// Healthcheck<br/>
        /// Returns the health status of the service.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> HealthcheckAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
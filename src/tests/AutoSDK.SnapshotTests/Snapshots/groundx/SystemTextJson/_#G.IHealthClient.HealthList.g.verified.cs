//HintName: G.IHealthClient.HealthList.g.cs
#nullable enable

namespace G
{
    public partial interface IHealthClient
    {
        /// <summary>
        /// list<br/>
        /// List the current health status of all services. Statuses update every 5 minutes.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.HealthResponse> HealthListAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
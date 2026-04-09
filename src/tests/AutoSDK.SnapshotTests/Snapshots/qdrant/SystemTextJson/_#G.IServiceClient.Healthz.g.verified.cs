//HintName: G.IServiceClient.Healthz.g.cs
#nullable enable

namespace G
{
    public partial interface IServiceClient
    {
        /// <summary>
        /// Kubernetes healthz endpoint<br/>
        /// An endpoint for health checking used in Kubernetes.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> HealthzAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
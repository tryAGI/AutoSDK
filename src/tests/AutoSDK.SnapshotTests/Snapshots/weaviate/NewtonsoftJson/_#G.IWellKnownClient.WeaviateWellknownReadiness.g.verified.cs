//HintName: G.IWellKnownClient.WeaviateWellknownReadiness.g.cs
#nullable enable

namespace G
{
    public partial interface IWellKnownClient
    {
        /// <summary>
        /// Get application readiness.<br/>
        /// Determines whether the application is ready to receive traffic. Can be used for kubernetes readiness probe.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task WeaviateWellknownReadinessAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
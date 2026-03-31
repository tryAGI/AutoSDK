//HintName: G.IProxyClient.Proxycredentials.g.cs
#nullable enable

namespace G
{
    public partial interface IProxyClient
    {
        /// <summary>
        /// Create temporary credential<br/>
        /// Create a temporary credential which can access the proxy for a limited time. The temporary credential will be allowed to make requests on behalf of the Braintrust API key (or model provider API key) provided in the `Authorization` header. See [docs](/docs/deploy/ai-proxy#create-temporary-credentials) for code examples.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProxycredentialsResponse> ProxycredentialsAsync(

            global::G.ProxycredentialsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create temporary credential<br/>
        /// Create a temporary credential which can access the proxy for a limited time. The temporary credential will be allowed to make requests on behalf of the Braintrust API key (or model provider API key) provided in the `Authorization` header. See [docs](/docs/deploy/ai-proxy#create-temporary-credentials) for code examples.
        /// </summary>
        /// <param name="model">
        /// Granted model name. Null/undefined to grant usage of all models.
        /// </param>
        /// <param name="ttlSeconds">
        /// TTL of the temporary credential. 10 minutes by default.<br/>
        /// Default Value: 600
        /// </param>
        /// <param name="logging">
        /// If present, proxy will log requests to the given Braintrust project name.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProxycredentialsResponse> ProxycredentialsAsync(
            string? model = default,
            double? ttlSeconds = default,
            global::G.ProxycredentialsRequestLogging? logging = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
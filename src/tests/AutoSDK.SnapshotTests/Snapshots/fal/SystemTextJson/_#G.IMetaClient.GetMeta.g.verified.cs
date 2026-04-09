//HintName: G.IMetaClient.GetMeta.g.cs
#nullable enable

namespace G
{
    public partial interface IMetaClient
    {
        /// <summary>
        /// Get platform metadata<br/>
        /// Returns platform metadata including webhook IP ranges for allowlisting.<br/>
        /// If your infrastructure requires allowlisting IP addresses for incoming webhook<br/>
        /// requests, this endpoint provides the current list of IP ranges used by fal.ai<br/>
        /// webhooks in CIDR notation.<br/>
        ///     
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetMetaResponse> GetMetaAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
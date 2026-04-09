//HintName: G.IApi.GetNamespacesByNamespaceHintCacheWarm.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Signal turbopuffer to prepare for low-latency requests.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetNamespacesHintCacheWarmResponse> GetNamespacesByNamespaceHintCacheWarmAsync(
            string @namespace,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
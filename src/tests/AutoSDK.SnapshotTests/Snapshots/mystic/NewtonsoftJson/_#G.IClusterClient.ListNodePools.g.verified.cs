//HintName: G.IClusterClient.ListNodePools.g.cs
#nullable enable

namespace G
{
    public partial interface IClusterClient
    {
        /// <summary>
        /// List Node Pools<br/>
        /// List node pools for a given cluster
        /// </summary>
        /// <param name="clusterId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.NodePool>> ListNodePoolsAsync(
            string clusterId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
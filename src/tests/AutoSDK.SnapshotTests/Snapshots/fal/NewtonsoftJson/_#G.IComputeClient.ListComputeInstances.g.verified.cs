//HintName: G.IComputeClient.ListComputeInstances.g.cs
#nullable enable

namespace G
{
    public partial interface IComputeClient
    {
        /// <summary>
        /// List Compute Instances<br/>
        /// Returns a list of all compute instances belonging to the authenticated user's workspace.<br/>
        /// **Requirements:**<br/>
        /// - Requires compute permissions (extra_permissions.compute = true)<br/>
        /// - Authentication required via admin API key<br/>
        /// **Key Features:**<br/>
        /// - View all instances regardless of status<br/>
        /// - Includes instance configuration, region, and current status<br/>
        /// - Paginated results for large instance lists<br/>
        /// **Common Use Cases:**<br/>
        /// - Monitor all active compute resources<br/>
        /// - Check instance status and availability<br/>
        /// - Audit compute resource usage<br/>
        /// - Build compute management dashboards<br/>
        /// See [fal.ai docs](https://docs.fal.ai/compute) for more details.
        /// </summary>
        /// <param name="limit">
        /// Maximum number of items to return. Actual maximum depends on query type and expansion parameters.<br/>
        /// Example: 50
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor from previous response. Encodes the page number.<br/>
        /// Example: Mg==
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListComputeInstancesResponse> ListComputeInstancesAsync(
            int? limit = default,
            string? cursor = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
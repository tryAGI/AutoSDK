//HintName: G.IPointsClient.Facet.g.cs
#nullable enable

namespace G
{
    public partial interface IPointsClient
    {
        /// <summary>
        /// Facet a payload key with a given filter.<br/>
        /// Count points that satisfy the given filter for each unique value of a payload key.
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="consistency">
        /// Read consistency parameter<br/>
        /// Defines how many replicas should be queried to get the result<br/>
        /// * `N` - send N random request and return points, which present on all of them<br/>
        /// * `majority` - send N/2+1 random request and return points, which present on all of them<br/>
        /// * `quorum` - send requests to all nodes and return points which present on majority of them<br/>
        /// * `all` - send requests to all nodes and return points which present on all of them<br/>
        /// Default value is `Factor(1)`
        /// </param>
        /// <param name="timeout"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FacetResponse2> FacetAsync(
            string collectionName,

            global::G.FacetRequest request,
            global::G.ReadConsistency? consistency = default,
            int? timeout = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Facet a payload key with a given filter.<br/>
        /// Count points that satisfy the given filter for each unique value of a payload key.
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="consistency">
        /// Read consistency parameter<br/>
        /// Defines how many replicas should be queried to get the result<br/>
        /// * `N` - send N random request and return points, which present on all of them<br/>
        /// * `majority` - send N/2+1 random request and return points, which present on all of them<br/>
        /// * `quorum` - send requests to all nodes and return points which present on majority of them<br/>
        /// * `all` - send requests to all nodes and return points which present on all of them<br/>
        /// Default value is `Factor(1)`
        /// </param>
        /// <param name="timeout"></param>
        /// <param name="shardKey"></param>
        /// <param name="key">
        /// Payload key to use for faceting.
        /// </param>
        /// <param name="limit">
        /// Max number of hits to return. Default is 10.
        /// </param>
        /// <param name="filter">
        /// Filter conditions - only consider points that satisfy these conditions.
        /// </param>
        /// <param name="exact">
        /// Whether to do a more expensive exact count for each of the values in the facet. Default is false.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FacetResponse2> FacetAsync(
            string collectionName,
            string key,
            global::G.ReadConsistency? consistency = default,
            int? timeout = default,
            global::G.ShardKeySelector? shardKey = default,
            int? limit = default,
            global::G.Filter? filter = default,
            bool? exact = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
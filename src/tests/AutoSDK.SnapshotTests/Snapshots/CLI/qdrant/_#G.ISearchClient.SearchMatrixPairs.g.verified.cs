//HintName: G.ISearchClient.SearchMatrixPairs.g.cs
#nullable enable

namespace G
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Search points matrix distance pairs<br/>
        /// Compute distance matrix for sampled points with a pair based output format
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SearchMatrixPairsResponse2> SearchMatrixPairsAsync(
            string collectionName,

            global::G.SearchMatrixRequest request,
            global::G.ReadConsistency? consistency = default,
            int? timeout = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search points matrix distance pairs<br/>
        /// Compute distance matrix for sampled points with a pair based output format
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
        /// <param name="shardKey">
        /// Specify in which shards to look for the points, if not specified - look in all shards
        /// </param>
        /// <param name="filter">
        /// Look only for points which satisfies this conditions
        /// </param>
        /// <param name="sample">
        /// How many points to select and search within. Default is 10.
        /// </param>
        /// <param name="limit">
        /// How many neighbours per sample to find. Default is 3.
        /// </param>
        /// <param name="using">
        /// Define which vector name to use for querying. If missing, the default vector is used.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SearchMatrixPairsResponse2> SearchMatrixPairsAsync(
            string collectionName,
            global::G.ReadConsistency? consistency = default,
            int? timeout = default,
            global::G.ShardKeySelector? shardKey = default,
            global::G.Filter? filter = default,
            int? sample = default,
            int? limit = default,
            string? @using = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
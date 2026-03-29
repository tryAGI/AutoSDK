//HintName: G.ISearchClient.QueryPointsGroups.g.cs
#nullable enable

namespace G
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Query points, grouped by a given payload field<br/>
        /// Universally query points, grouped by a given payload field
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
        global::System.Threading.Tasks.Task<global::G.QueryPointsGroupsResponse> QueryPointsGroupsAsync(
            string collectionName,

            global::G.QueryGroupsRequest request,
            global::G.ReadConsistency? consistency = default,
            int? timeout = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Query points, grouped by a given payload field<br/>
        /// Universally query points, grouped by a given payload field
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
        /// <param name="prefetch">
        /// Sub-requests to perform first. If present, the query will be performed on the results of the prefetch(es).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="query">
        /// Query to perform. If missing without prefetches, returns points ordered by their IDs.
        /// </param>
        /// <param name="using">
        /// Define which vector name to use for querying. If missing, the default vector is used.
        /// </param>
        /// <param name="filter">
        /// Filter conditions - return only those points that satisfy the specified conditions.
        /// </param>
        /// <param name="params">
        /// Search params for when there is no prefetch
        /// </param>
        /// <param name="scoreThreshold">
        /// Return points with scores better than this threshold.
        /// </param>
        /// <param name="withVector">
        /// Options for specifying which vectors to include into the response. Default is false.
        /// </param>
        /// <param name="withPayload">
        /// Options for specifying which payload to include or not. Default is false.
        /// </param>
        /// <param name="lookupFrom">
        /// The location to use for IDs lookup, if not specified - use the current collection and the 'using' vector Note: the other collection vectors should have the same vector size as the 'using' vector in the current collection<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="groupBy">
        /// Payload field to group by, must be a string or number field. If the field contains more than 1 value, all values will be used for grouping. One point can be in multiple groups.
        /// </param>
        /// <param name="groupSize">
        /// Maximum amount of points to return per group. Default is 3.
        /// </param>
        /// <param name="limit">
        /// Maximum amount of groups to return. Default is 10.
        /// </param>
        /// <param name="withLookup">
        /// Look for points in another collection using the group ids
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.QueryPointsGroupsResponse> QueryPointsGroupsAsync(
            string collectionName,
            string groupBy,
            global::G.ReadConsistency? consistency = default,
            int? timeout = default,
            global::G.ShardKeySelector? shardKey = default,
            global::G.AnyOf<global::G.Prefetch2, global::System.Collections.Generic.IList<global::G.Prefetch2>, object>? prefetch = default,
            global::G.QueryInterface? query = default,
            string? @using = default,
            global::G.Filter? filter = default,
            global::G.SearchParams? @params = default,
            float? scoreThreshold = default,
            global::G.WithVector? withVector = default,
            global::G.WithPayloadInterface? withPayload = default,
            global::G.LookupLocation? lookupFrom = default,
            int? groupSize = default,
            int? limit = default,
            global::G.WithLookupInterface? withLookup = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
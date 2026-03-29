//HintName: G.ISearchClient.DiscoverPoints.g.cs
#nullable enable

namespace G
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Discover points<br/>
        /// Use context and a target to find the most similar points to the target, constrained by the context.<br/>
        /// When using only the context (without a target), a special search - called context search - is performed where pairs of points are used to generate a loss that guides the search towards the zone where most positive examples overlap. This means that the score minimizes the scenario of finding a point closer to a negative than to a positive part of a pair.<br/>
        /// Since the score of a context relates to loss, the maximum score a point can get is 0.0, and it becomes normal that many points can have a score of 0.0.<br/>
        /// When using target (with or without context), the score behaves a little different: The integer part of the score represents the rank with respect to the context, while the decimal part of the score relates to the distance to the target. The context part of the score for each pair is calculated +1 if the point is closer to a positive than to a negative part of a pair, and -1 otherwise.
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
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.DiscoverPointsResponse> DiscoverPointsAsync(
            string collectionName,

            global::G.DiscoverRequest request,
            global::G.ReadConsistency? consistency = default,
            int? timeout = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Discover points<br/>
        /// Use context and a target to find the most similar points to the target, constrained by the context.<br/>
        /// When using only the context (without a target), a special search - called context search - is performed where pairs of points are used to generate a loss that guides the search towards the zone where most positive examples overlap. This means that the score minimizes the scenario of finding a point closer to a negative than to a positive part of a pair.<br/>
        /// Since the score of a context relates to loss, the maximum score a point can get is 0.0, and it becomes normal that many points can have a score of 0.0.<br/>
        /// When using target (with or without context), the score behaves a little different: The integer part of the score represents the rank with respect to the context, while the decimal part of the score relates to the distance to the target. The context part of the score for each pair is calculated +1 if the point is closer to a positive than to a negative part of a pair, and -1 otherwise.
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
        /// <param name="target">
        /// Look for vectors closest to this.<br/>
        /// When using the target (with or without context), the integer part of the score represents the rank with respect to the context, while the decimal part of the score relates to the distance to the target.
        /// </param>
        /// <param name="context">
        /// Pairs of { positive, negative } examples to constrain the search.<br/>
        /// When using only the context (without a target), a special search - called context search - is performed where pairs of points are used to generate a loss that guides the search towards the zone where most positive examples overlap. This means that the score minimizes the scenario of finding a point closer to a negative than to a positive part of a pair.<br/>
        /// Since the score of a context relates to loss, the maximum score a point can get is 0.0, and it becomes normal that many points can have a score of 0.0.<br/>
        /// For discovery search (when including a target), the context part of the score for each pair is calculated +1 if the point is closer to a positive than to a negative part of a pair, and -1 otherwise.
        /// </param>
        /// <param name="filter">
        /// Look only for points which satisfies this conditions
        /// </param>
        /// <param name="params">
        /// Additional search params
        /// </param>
        /// <param name="limit">
        /// Max number of result to return
        /// </param>
        /// <param name="offset">
        /// Offset of the first result to return. May be used to paginate results. Note: large offset values may cause performance issues.
        /// </param>
        /// <param name="withPayload">
        /// Select which payload to return with the response. Default is false.
        /// </param>
        /// <param name="withVector">
        /// Options for specifying which vectors to include into response. Default is false.
        /// </param>
        /// <param name="using">
        /// Define which vector to use for recommendation, if not specified - try to use default vector<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="lookupFrom">
        /// The location used to lookup vectors. If not specified - use current collection. Note: the other collection should have the same vector size as the current collection<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.DiscoverPointsResponse> DiscoverPointsAsync(
            string collectionName,
            int limit,
            global::G.ReadConsistency? consistency = default,
            int? timeout = default,
            global::G.ShardKeySelector? shardKey = default,
            global::G.RecommendExample? target = default,
            global::System.Collections.Generic.IList<global::G.ContextExamplePair>? context = default,
            global::G.Filter? filter = default,
            global::G.SearchParams? @params = default,
            int? offset = default,
            global::G.WithPayloadInterface? withPayload = default,
            global::G.WithVector? withVector = default,
            global::G.UsingVector? @using = default,
            global::G.LookupLocation? lookupFrom = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
//HintName: G.IDistributedClient.CreateShardKey.g.cs
#nullable enable

namespace G
{
    public partial interface IDistributedClient
    {
        /// <summary>
        /// Create shard key
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="timeout"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateShardKeyResponse> CreateShardKeyAsync(
            string collectionName,

            global::G.CreateShardingKey request,
            int? timeout = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create shard key
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="timeout"></param>
        /// <param name="shardKey"></param>
        /// <param name="shardsNumber">
        /// How many shards to create for this key If not specified, will use the default value from config
        /// </param>
        /// <param name="replicationFactor">
        /// How many replicas to create for each shard If not specified, will use the default value from config
        /// </param>
        /// <param name="placement">
        /// Placement of shards for this key List of peer ids, that can be used to place shards for this key If not specified, will be randomly placed among all peers
        /// </param>
        /// <param name="initialState">
        /// Initial state of the shards for this key If not specified, will be `Initializing` first and then `Active` Warning: do not change this unless you know what you are doing
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateShardKeyResponse> CreateShardKeyAsync(
            string collectionName,
            global::G.ShardKey shardKey,
            int? timeout = default,
            int? shardsNumber = default,
            int? replicationFactor = default,
            global::System.Collections.Generic.IList<int>? placement = default,
            global::G.ReplicaState? initialState = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
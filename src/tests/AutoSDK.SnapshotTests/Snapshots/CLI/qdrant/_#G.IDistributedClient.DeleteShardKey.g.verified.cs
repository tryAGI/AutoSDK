//HintName: G.IDistributedClient.DeleteShardKey.g.cs
#nullable enable

namespace G
{
    public partial interface IDistributedClient
    {
        /// <summary>
        /// Delete shard key
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="timeout"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteShardKeyResponse> DeleteShardKeyAsync(
            string collectionName,

            global::G.DropShardingKey request,
            int? timeout = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete shard key
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="timeout"></param>
        /// <param name="shardKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteShardKeyResponse> DeleteShardKeyAsync(
            string collectionName,
            global::G.ShardKey shardKey,
            int? timeout = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
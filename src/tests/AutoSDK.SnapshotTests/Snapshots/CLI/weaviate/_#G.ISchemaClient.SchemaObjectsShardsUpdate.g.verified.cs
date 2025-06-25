//HintName: G.ISchemaClient.SchemaObjectsShardsUpdate.g.cs
#nullable enable

namespace G
{
    public partial interface ISchemaClient
    {
        /// <summary>
        /// Update a shard status.<br/>
        /// Update a shard status for a collection. For example, a shard may have been marked as `READONLY` because its disk was full. After providing more disk space, use this endpoint to set the shard status to `READY` again. There is also a convenience function in each client to set the status of all shards of a collection.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="shardName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ShardStatus> SchemaObjectsShardsUpdateAsync(
            string className,
            string shardName,
            global::G.ShardStatus request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a shard status.<br/>
        /// Update a shard status for a collection. For example, a shard may have been marked as `READONLY` because its disk was full. After providing more disk space, use this endpoint to set the shard status to `READY` again. There is also a convenience function in each client to set the status of all shards of a collection.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="shardName"></param>
        /// <param name="status">
        /// Status of the shard
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ShardStatus> SchemaObjectsShardsUpdateAsync(
            string className,
            string shardName,
            string? status = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
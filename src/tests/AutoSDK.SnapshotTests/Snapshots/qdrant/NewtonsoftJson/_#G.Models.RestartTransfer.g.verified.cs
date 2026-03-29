//HintName: G.Models.RestartTransfer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RestartTransfer
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("shard_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int ShardId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("from_peer_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int FromPeerId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("to_peer_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int ToPeerId { get; set; } = default!;

        /// <summary>
        /// Methods for transferring a shard from one node to another.<br/>
        /// - `stream_records` - Stream all shard records in batches until the whole shard is transferred.<br/>
        /// - `snapshot` - Snapshot the shard, transfer and restore it on the receiver.<br/>
        /// - `wal_delta` - Attempt to transfer shard difference by WAL delta.<br/>
        /// - `resharding_stream_records` - Shard transfer for resharding: stream all records in batches until all points are transferred.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("method", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ShardTransferMethod Method { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RestartTransfer" /> class.
        /// </summary>
        /// <param name="shardId"></param>
        /// <param name="fromPeerId"></param>
        /// <param name="toPeerId"></param>
        /// <param name="method">
        /// Methods for transferring a shard from one node to another.<br/>
        /// - `stream_records` - Stream all shard records in batches until the whole shard is transferred.<br/>
        /// - `snapshot` - Snapshot the shard, transfer and restore it on the receiver.<br/>
        /// - `wal_delta` - Attempt to transfer shard difference by WAL delta.<br/>
        /// - `resharding_stream_records` - Shard transfer for resharding: stream all records in batches until all points are transferred.
        /// </param>
        public RestartTransfer(
            int shardId,
            int fromPeerId,
            int toPeerId,
            global::G.ShardTransferMethod method)
        {
            this.ShardId = shardId;
            this.FromPeerId = fromPeerId;
            this.ToPeerId = toPeerId;
            this.Method = method;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RestartTransfer" /> class.
        /// </summary>
        public RestartTransfer()
        {
        }
    }
}
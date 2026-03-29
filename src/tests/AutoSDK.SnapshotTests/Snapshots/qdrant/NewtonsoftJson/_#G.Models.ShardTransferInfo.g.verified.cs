//HintName: G.Models.ShardTransferInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ShardTransferInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("shard_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int ShardId { get; set; } = default!;

        /// <summary>
        /// Target shard ID if different than source shard ID<br/>
        /// Used exclusively with `ReshardingStreamRecords` transfer method.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("to_shard_id")]
        public int? ToShardId { get; set; }

        /// <summary>
        /// Source peer id
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("from", Required = global::Newtonsoft.Json.Required.Always)]
        public int From { get; set; } = default!;

        /// <summary>
        /// Destination peer id
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("to", Required = global::Newtonsoft.Json.Required.Always)]
        public int To { get; set; } = default!;

        /// <summary>
        /// If `true` transfer is a synchronization of a replicas If `false` transfer is a moving of a shard from one peer to another
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sync", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Sync { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("method")]
        public global::G.ShardTransferMethod? Method { get; set; }

        /// <summary>
        /// A human-readable report of the transfer progress. Available only on the source peer.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShardTransferInfo" /> class.
        /// </summary>
        /// <param name="shardId"></param>
        /// <param name="from">
        /// Source peer id
        /// </param>
        /// <param name="to">
        /// Destination peer id
        /// </param>
        /// <param name="sync">
        /// If `true` transfer is a synchronization of a replicas If `false` transfer is a moving of a shard from one peer to another
        /// </param>
        /// <param name="toShardId">
        /// Target shard ID if different than source shard ID<br/>
        /// Used exclusively with `ReshardingStreamRecords` transfer method.
        /// </param>
        /// <param name="method"></param>
        /// <param name="comment">
        /// A human-readable report of the transfer progress. Available only on the source peer.
        /// </param>
        public ShardTransferInfo(
            int shardId,
            int from,
            int to,
            bool sync,
            int? toShardId,
            global::G.ShardTransferMethod? method,
            string? comment)
        {
            this.ShardId = shardId;
            this.ToShardId = toShardId;
            this.From = from;
            this.To = to;
            this.Sync = sync;
            this.Method = method;
            this.Comment = comment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShardTransferInfo" /> class.
        /// </summary>
        public ShardTransferInfo()
        {
        }
    }
}
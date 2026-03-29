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
        [global::System.Text.Json.Serialization.JsonPropertyName("shard_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ShardId { get; set; }

        /// <summary>
        /// Target shard ID if different than source shard ID<br/>
        /// Used exclusively with `ReshardingStreamRecords` transfer method.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to_shard_id")]
        public int? ToShardId { get; set; }

        /// <summary>
        /// Source peer id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int From { get; set; }

        /// <summary>
        /// Destination peer id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int To { get; set; }

        /// <summary>
        /// If `true` transfer is a synchronization of a replicas If `false` transfer is a moving of a shard from one peer to another
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sync")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Sync { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        public global::G.ShardTransferMethod? Method { get; set; }

        /// <summary>
        /// A human-readable report of the transfer progress. Available only on the source peer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
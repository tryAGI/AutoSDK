//HintName: G.Models.RemoteShardTelemetry.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RemoteShardTelemetry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shard_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ShardId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("peer_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PeerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("searches")]
        public global::G.OperationDurationStatistics? Searches { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updates")]
        public global::G.OperationDurationStatistics? Updates { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoteShardTelemetry" /> class.
        /// </summary>
        /// <param name="shardId"></param>
        /// <param name="peerId"></param>
        /// <param name="searches"></param>
        /// <param name="updates"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RemoteShardTelemetry(
            int shardId,
            int peerId,
            global::G.OperationDurationStatistics? searches,
            global::G.OperationDurationStatistics? updates)
        {
            this.ShardId = shardId;
            this.PeerId = peerId;
            this.Searches = searches;
            this.Updates = updates;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoteShardTelemetry" /> class.
        /// </summary>
        public RemoteShardTelemetry()
        {
        }
    }
}
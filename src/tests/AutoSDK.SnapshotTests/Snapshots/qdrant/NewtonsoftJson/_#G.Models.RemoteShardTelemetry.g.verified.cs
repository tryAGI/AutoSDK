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
        [global::Newtonsoft.Json.JsonProperty("shard_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int ShardId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("peer_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int PeerId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("searches")]
        public global::G.OperationDurationStatistics? Searches { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updates")]
        public global::G.OperationDurationStatistics? Updates { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoteShardTelemetry" /> class.
        /// </summary>
        /// <param name="shardId"></param>
        /// <param name="peerId"></param>
        /// <param name="searches"></param>
        /// <param name="updates"></param>
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
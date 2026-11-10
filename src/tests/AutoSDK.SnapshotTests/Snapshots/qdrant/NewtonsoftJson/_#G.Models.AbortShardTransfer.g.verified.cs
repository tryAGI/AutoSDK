//HintName: G.Models.AbortShardTransfer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AbortShardTransfer
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("shard_id", Required = global::Newtonsoft.Json.Required.Always)]
        public long ShardId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("to_peer_id", Required = global::Newtonsoft.Json.Required.Always)]
        public long ToPeerId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("from_peer_id", Required = global::Newtonsoft.Json.Required.Always)]
        public long FromPeerId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AbortShardTransfer" /> class.
        /// </summary>
        /// <param name="shardId"></param>
        /// <param name="toPeerId"></param>
        /// <param name="fromPeerId"></param>
        public AbortShardTransfer(
            long shardId,
            long toPeerId,
            long fromPeerId)
        {
            this.ShardId = shardId;
            this.ToPeerId = toPeerId;
            this.FromPeerId = fromPeerId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AbortShardTransfer" /> class.
        /// </summary>
        public AbortShardTransfer()
        {
        }

    }
}
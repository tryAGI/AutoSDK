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
        [global::System.Text.Json.Serialization.JsonPropertyName("shard_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ShardId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to_peer_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ToPeerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_peer_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FromPeerId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AbortShardTransfer" /> class.
        /// </summary>
        /// <param name="shardId"></param>
        /// <param name="toPeerId"></param>
        /// <param name="fromPeerId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AbortShardTransfer(
            int shardId,
            int toPeerId,
            int fromPeerId)
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
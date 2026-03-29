//HintName: G.Models.MoveShard.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MoveShard
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
        /// Method for transferring the shard from one node to another
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        public global::G.ShardTransferMethod? Method { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MoveShard" /> class.
        /// </summary>
        /// <param name="shardId"></param>
        /// <param name="toPeerId"></param>
        /// <param name="fromPeerId"></param>
        /// <param name="method">
        /// Method for transferring the shard from one node to another
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MoveShard(
            int shardId,
            int toPeerId,
            int fromPeerId,
            global::G.ShardTransferMethod? method)
        {
            this.ShardId = shardId;
            this.ToPeerId = toPeerId;
            this.FromPeerId = fromPeerId;
            this.Method = method;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MoveShard" /> class.
        /// </summary>
        public MoveShard()
        {
        }
    }
}
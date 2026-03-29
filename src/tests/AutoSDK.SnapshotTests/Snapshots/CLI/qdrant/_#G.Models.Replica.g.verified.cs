//HintName: G.Models.Replica.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Replica
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Replica" /> class.
        /// </summary>
        /// <param name="shardId"></param>
        /// <param name="peerId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Replica(
            int shardId,
            int peerId)
        {
            this.ShardId = shardId;
            this.PeerId = peerId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Replica" /> class.
        /// </summary>
        public Replica()
        {
        }
    }
}
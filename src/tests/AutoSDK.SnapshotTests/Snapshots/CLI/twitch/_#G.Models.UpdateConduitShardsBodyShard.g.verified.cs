//HintName: G.Models.UpdateConduitShardsBodyShard.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateConduitShardsBodyShard
    {
        /// <summary>
        /// Shard ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The transport details that you want Twitch to use when sending you notifications.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transport")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.UpdateConduitShardsBodyShardTransport Transport { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConduitShardsBodyShard" /> class.
        /// </summary>
        /// <param name="id">
        /// Shard ID.
        /// </param>
        /// <param name="transport">
        /// The transport details that you want Twitch to use when sending you notifications.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateConduitShardsBodyShard(
            string id,
            global::G.UpdateConduitShardsBodyShardTransport transport)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Transport = transport ?? throw new global::System.ArgumentNullException(nameof(transport));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConduitShardsBodyShard" /> class.
        /// </summary>
        public UpdateConduitShardsBodyShard()
        {
        }
    }
}
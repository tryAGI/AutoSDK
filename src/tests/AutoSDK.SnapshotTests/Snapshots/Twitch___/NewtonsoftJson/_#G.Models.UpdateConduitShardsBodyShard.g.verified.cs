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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The transport details that you want Twitch to use when sending you notifications.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transport", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.UpdateConduitShardsBodyShardTransport Transport { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
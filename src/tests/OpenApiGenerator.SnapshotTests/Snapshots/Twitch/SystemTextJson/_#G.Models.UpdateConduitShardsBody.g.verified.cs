//HintName: G.Models.UpdateConduitShardsBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateConduitShardsBody
    {
        /// <summary>
        /// Conduit ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conduit_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConduitId { get; set; }

        /// <summary>
        /// List of shards to update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shards")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.UpdateConduitShardsBodyShards> Shards { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
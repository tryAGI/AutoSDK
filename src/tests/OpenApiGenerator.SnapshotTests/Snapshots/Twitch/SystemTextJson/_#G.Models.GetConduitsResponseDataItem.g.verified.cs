//HintName: G.Models.GetConduitsResponseDataItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConduitsResponseDataItem
    {
        /// <summary>
        /// Conduit ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Number of shards associated with this conduit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shard_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ShardCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
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

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConduitsResponseDataItem" /> class.
        /// </summary>
        /// <param name="id">
        /// Conduit ID.
        /// </param>
        /// <param name="shardCount">
        /// Number of shards associated with this conduit.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConduitsResponseDataItem(
            string id,
            int shardCount)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ShardCount = shardCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConduitsResponseDataItem" /> class.
        /// </summary>
        public GetConduitsResponseDataItem()
        {
        }
    }
}
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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Number of shards associated with this conduit.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("shard_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int ShardCount { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
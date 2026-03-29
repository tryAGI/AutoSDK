//HintName: G.Models.DeletePayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This data structure is used in API interface and applied across multiple shards
    /// </summary>
    public sealed partial class DeletePayload
    {
        /// <summary>
        /// List of payload keys to remove from payload
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("keys", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Keys { get; set; } = default!;

        /// <summary>
        /// Deletes values from each point in this list
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("points")]
        public global::System.Collections.Generic.IList<global::G.ExtendedPointId>? Points { get; set; }

        /// <summary>
        /// Deletes values from points that satisfy this filter condition
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter")]
        public global::G.Filter? Filter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("shard_key")]
        public global::G.ShardKeySelector? ShardKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeletePayload" /> class.
        /// </summary>
        /// <param name="keys">
        /// List of payload keys to remove from payload
        /// </param>
        /// <param name="points">
        /// Deletes values from each point in this list
        /// </param>
        /// <param name="filter">
        /// Deletes values from points that satisfy this filter condition
        /// </param>
        /// <param name="shardKey"></param>
        public DeletePayload(
            global::System.Collections.Generic.IList<string> keys,
            global::System.Collections.Generic.IList<global::G.ExtendedPointId>? points,
            global::G.Filter? filter,
            global::G.ShardKeySelector? shardKey)
        {
            this.Keys = keys ?? throw new global::System.ArgumentNullException(nameof(keys));
            this.Points = points;
            this.Filter = filter;
            this.ShardKey = shardKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeletePayload" /> class.
        /// </summary>
        public DeletePayload()
        {
        }
    }
}
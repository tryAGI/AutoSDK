//HintName: G.Models.FilterSelector.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FilterSelector
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Filter Filter { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="FilterSelector" /> class.
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="shardKey"></param>
        public FilterSelector(
            global::G.Filter filter,
            global::G.ShardKeySelector? shardKey)
        {
            this.Filter = filter ?? throw new global::System.ArgumentNullException(nameof(filter));
            this.ShardKey = shardKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterSelector" /> class.
        /// </summary>
        public FilterSelector()
        {
        }
    }
}
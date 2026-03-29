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
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Filter Filter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shard_key")]
        public global::G.ShardKeySelector? ShardKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterSelector" /> class.
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="shardKey"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
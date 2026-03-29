//HintName: G.Models.AggregateGroup.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// API Result for a single group in the aggregate response
    /// </summary>
    public sealed partial class AggregateGroup
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("group_key", Required = global::Newtonsoft.Json.Required.Always)]
        public object GroupKey { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("count")]
        public int? Count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("first_item")]
        public object? FirstItem { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AggregateGroup" /> class.
        /// </summary>
        /// <param name="groupKey"></param>
        /// <param name="count"></param>
        /// <param name="firstItem"></param>
        public AggregateGroup(
            object groupKey,
            int? count,
            object? firstItem)
        {
            this.GroupKey = groupKey ?? throw new global::System.ArgumentNullException(nameof(groupKey));
            this.Count = count;
            this.FirstItem = firstItem;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AggregateGroup" /> class.
        /// </summary>
        public AggregateGroup()
        {
        }
    }
}
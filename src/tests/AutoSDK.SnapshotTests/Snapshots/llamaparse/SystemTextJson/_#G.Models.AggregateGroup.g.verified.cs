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
        [global::System.Text.Json.Serialization.JsonPropertyName("group_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object GroupKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public int? Count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_item")]
        public object? FirstItem { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AggregateGroup" /> class.
        /// </summary>
        /// <param name="groupKey"></param>
        /// <param name="count"></param>
        /// <param name="firstItem"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
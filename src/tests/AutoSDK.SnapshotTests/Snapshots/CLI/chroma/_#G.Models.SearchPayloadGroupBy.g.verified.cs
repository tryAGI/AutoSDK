//HintName: G.Models.SearchPayloadGroupBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchPayloadGroupBy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aggregate")]
        public object? Aggregate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keys")]
        public global::System.Collections.Generic.IList<string>? Keys { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchPayloadGroupBy" /> class.
        /// </summary>
        /// <param name="aggregate"></param>
        /// <param name="keys"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchPayloadGroupBy(
            object? aggregate,
            global::System.Collections.Generic.IList<string>? keys)
        {
            this.Aggregate = aggregate;
            this.Keys = keys;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchPayloadGroupBy" /> class.
        /// </summary>
        public SearchPayloadGroupBy()
        {
        }
    }
}
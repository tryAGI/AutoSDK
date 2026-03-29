//HintName: G.Models.OtlpSpanDroppedLinksCount.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// dropped_links_count is the number of dropped links after the maximum size was enforced. If this value is 0, then no links were dropped.
    /// </summary>
    public sealed partial class OtlpSpanDroppedLinksCount
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
//HintName: G.Models.OtlpSpanDroppedAttributesCount.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// dropped_attributes_count is the number of attributes that were discarded. Attributes can be discarded because their keys are too long or because there are too many attributes. If this value is 0, then no attributes were dropped.
    /// </summary>
    public sealed partial class OtlpSpanDroppedAttributesCount
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
//HintName: G.Models.OtlpSpanParentSpanId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The `span_id` of this span's parent span. If this is a root span, then this field must be empty. The ID is an 8-byte array.
    /// </summary>
    public sealed partial class OtlpSpanParentSpanId
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
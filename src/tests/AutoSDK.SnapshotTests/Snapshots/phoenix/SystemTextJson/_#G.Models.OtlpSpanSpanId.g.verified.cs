//HintName: G.Models.OtlpSpanSpanId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A unique identifier for a span within a trace, assigned when the span is created. The ID is an 8-byte array. An ID with all zeroes OR of length other than 8 bytes is considered invalid (empty string in OTLP/JSON is zero-length and thus is also invalid).<br/>
    /// This field is required.
    /// </summary>
    public sealed partial class OtlpSpanSpanId
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
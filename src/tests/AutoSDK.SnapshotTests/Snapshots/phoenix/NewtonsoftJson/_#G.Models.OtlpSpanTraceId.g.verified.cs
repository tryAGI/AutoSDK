//HintName: G.Models.OtlpSpanTraceId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A unique identifier for a trace. All spans from the same trace share the same `trace_id`. The ID is a 16-byte array. An ID with all zeroes OR of length other than 16 bytes is considered invalid (empty string in OTLP/JSON is zero-length and thus is also invalid).<br/>
    /// This field is required.
    /// </summary>
    public sealed partial class OtlpSpanTraceId
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
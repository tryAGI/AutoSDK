//HintName: G.Models.OtlpExportTraceServiceRequestResourceSpanScopeSpan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OtlpExportTraceServiceRequestResourceSpanScopeSpan
    {
        /// <summary>
        /// The instrumentation scope that produced the spans.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        public global::G.OtlpExportTraceServiceRequestResourceSpanScopeSpanScope? Scope { get; set; }

        /// <summary>
        /// Array of Span objects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spans")]
        public global::System.Collections.Generic.IList<global::G.OtlpSpan>? Spans { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OtlpExportTraceServiceRequestResourceSpanScopeSpan" /> class.
        /// </summary>
        /// <param name="scope">
        /// The instrumentation scope that produced the spans.
        /// </param>
        /// <param name="spans">
        /// Array of Span objects.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OtlpExportTraceServiceRequestResourceSpanScopeSpan(
            global::G.OtlpExportTraceServiceRequestResourceSpanScopeSpanScope? scope,
            global::System.Collections.Generic.IList<global::G.OtlpSpan>? spans)
        {
            this.Scope = scope;
            this.Spans = spans;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OtlpExportTraceServiceRequestResourceSpanScopeSpan" /> class.
        /// </summary>
        public OtlpExportTraceServiceRequestResourceSpanScopeSpan()
        {
        }
    }
}
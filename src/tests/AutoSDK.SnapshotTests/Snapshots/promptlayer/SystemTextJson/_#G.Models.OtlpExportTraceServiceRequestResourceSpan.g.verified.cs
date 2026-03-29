//HintName: G.Models.OtlpExportTraceServiceRequestResourceSpan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OtlpExportTraceServiceRequestResourceSpan
    {
        /// <summary>
        /// The resource that produced the spans.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource")]
        public global::G.OtlpExportTraceServiceRequestResourceSpanResource? Resource { get; set; }

        /// <summary>
        /// An array of ScopeSpans, grouping spans by instrumentation scope.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopeSpans")]
        public global::System.Collections.Generic.IList<global::G.OtlpExportTraceServiceRequestResourceSpanScopeSpan>? ScopeSpans { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OtlpExportTraceServiceRequestResourceSpan" /> class.
        /// </summary>
        /// <param name="resource">
        /// The resource that produced the spans.
        /// </param>
        /// <param name="scopeSpans">
        /// An array of ScopeSpans, grouping spans by instrumentation scope.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OtlpExportTraceServiceRequestResourceSpan(
            global::G.OtlpExportTraceServiceRequestResourceSpanResource? resource,
            global::System.Collections.Generic.IList<global::G.OtlpExportTraceServiceRequestResourceSpanScopeSpan>? scopeSpans)
        {
            this.Resource = resource;
            this.ScopeSpans = scopeSpans;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OtlpExportTraceServiceRequestResourceSpan" /> class.
        /// </summary>
        public OtlpExportTraceServiceRequestResourceSpan()
        {
        }
    }
}
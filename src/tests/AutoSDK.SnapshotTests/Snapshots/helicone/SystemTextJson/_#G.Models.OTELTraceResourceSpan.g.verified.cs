//HintName: G.Models.OTELTraceResourceSpan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OTELTraceResourceSpan
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopeSpans")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.OTELTraceResourceSpanScopeSpan> ScopeSpans { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OTELTraceResourceSpanResource Resource { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OTELTraceResourceSpan" /> class.
        /// </summary>
        /// <param name="scopeSpans"></param>
        /// <param name="resource"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OTELTraceResourceSpan(
            global::System.Collections.Generic.IList<global::G.OTELTraceResourceSpanScopeSpan> scopeSpans,
            global::G.OTELTraceResourceSpanResource resource)
        {
            this.ScopeSpans = scopeSpans ?? throw new global::System.ArgumentNullException(nameof(scopeSpans));
            this.Resource = resource ?? throw new global::System.ArgumentNullException(nameof(resource));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OTELTraceResourceSpan" /> class.
        /// </summary>
        public OTELTraceResourceSpan()
        {
        }
    }
}
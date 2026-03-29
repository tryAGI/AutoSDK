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
        [global::Newtonsoft.Json.JsonProperty("scopeSpans", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.OTELTraceResourceSpanScopeSpan> ScopeSpans { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resource", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OTELTraceResourceSpanResource Resource { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OTELTraceResourceSpan" /> class.
        /// </summary>
        /// <param name="scopeSpans"></param>
        /// <param name="resource"></param>
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
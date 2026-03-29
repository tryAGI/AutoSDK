//HintName: G.Models.OTELTraceResourceSpanScopeSpan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OTELTraceResourceSpanScopeSpan
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("spans", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.OTELTraceResourceSpanScopeSpanSpan> Spans { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scope", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OTELTraceResourceSpanScopeSpanScope Scope { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OTELTraceResourceSpanScopeSpan" /> class.
        /// </summary>
        /// <param name="spans"></param>
        /// <param name="scope"></param>
        public OTELTraceResourceSpanScopeSpan(
            global::System.Collections.Generic.IList<global::G.OTELTraceResourceSpanScopeSpanSpan> spans,
            global::G.OTELTraceResourceSpanScopeSpanScope scope)
        {
            this.Spans = spans ?? throw new global::System.ArgumentNullException(nameof(spans));
            this.Scope = scope ?? throw new global::System.ArgumentNullException(nameof(scope));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OTELTraceResourceSpanScopeSpan" /> class.
        /// </summary>
        public OTELTraceResourceSpanScopeSpan()
        {
        }
    }
}
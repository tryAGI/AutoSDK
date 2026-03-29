//HintName: G.Models.OtelScopeSpan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Collection of spans from a single instrumentation scope
    /// </summary>
    public sealed partial class OtelScopeSpan
    {
        /// <summary>
        /// Instrumentation scope information
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scope")]
        public global::G.OtelScope? Scope { get; set; }

        /// <summary>
        /// Array of spans
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("spans")]
        public global::System.Collections.Generic.IList<global::G.OtelSpan>? Spans { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OtelScopeSpan" /> class.
        /// </summary>
        /// <param name="scope">
        /// Instrumentation scope information
        /// </param>
        /// <param name="spans">
        /// Array of spans
        /// </param>
        public OtelScopeSpan(
            global::G.OtelScope? scope,
            global::System.Collections.Generic.IList<global::G.OtelSpan>? spans)
        {
            this.Scope = scope;
            this.Spans = spans;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OtelScopeSpan" /> class.
        /// </summary>
        public OtelScopeSpan()
        {
        }
    }
}
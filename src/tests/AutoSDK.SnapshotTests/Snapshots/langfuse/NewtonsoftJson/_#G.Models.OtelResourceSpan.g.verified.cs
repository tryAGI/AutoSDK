//HintName: G.Models.OtelResourceSpan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a collection of spans from a single resource as per OTLP specification
    /// </summary>
    public sealed partial class OtelResourceSpan
    {
        /// <summary>
        /// Resource attributes identifying the source of telemetry
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resource")]
        public global::G.OtelResource? Resource { get; set; }

        /// <summary>
        /// Array of scope spans
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scopeSpans")]
        public global::System.Collections.Generic.IList<global::G.OtelScopeSpan>? ScopeSpans { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OtelResourceSpan" /> class.
        /// </summary>
        /// <param name="resource">
        /// Resource attributes identifying the source of telemetry
        /// </param>
        /// <param name="scopeSpans">
        /// Array of scope spans
        /// </param>
        public OtelResourceSpan(
            global::G.OtelResource? resource,
            global::System.Collections.Generic.IList<global::G.OtelScopeSpan>? scopeSpans)
        {
            this.Resource = resource;
            this.ScopeSpans = scopeSpans;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OtelResourceSpan" /> class.
        /// </summary>
        public OtelResourceSpan()
        {
        }
    }
}
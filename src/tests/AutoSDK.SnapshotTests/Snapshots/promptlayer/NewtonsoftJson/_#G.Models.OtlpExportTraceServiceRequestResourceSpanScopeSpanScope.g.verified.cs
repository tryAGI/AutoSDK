//HintName: G.Models.OtlpExportTraceServiceRequestResourceSpanScopeSpanScope.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The instrumentation scope that produced the spans.
    /// </summary>
    public sealed partial class OtlpExportTraceServiceRequestResourceSpanScopeSpanScope
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OtlpExportTraceServiceRequestResourceSpanScopeSpanScope" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="version"></param>
        public OtlpExportTraceServiceRequestResourceSpanScopeSpanScope(
            string? name,
            string? version)
        {
            this.Name = name;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OtlpExportTraceServiceRequestResourceSpanScopeSpanScope" /> class.
        /// </summary>
        public OtlpExportTraceServiceRequestResourceSpanScopeSpanScope()
        {
        }
    }
}
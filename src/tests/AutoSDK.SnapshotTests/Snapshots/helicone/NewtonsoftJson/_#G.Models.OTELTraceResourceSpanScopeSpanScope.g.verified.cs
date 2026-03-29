//HintName: G.Models.OTELTraceResourceSpanScopeSpanScope.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OTELTraceResourceSpanScopeSpanScope
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public string Version { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OTELTraceResourceSpanScopeSpanScope" /> class.
        /// </summary>
        /// <param name="version"></param>
        /// <param name="name"></param>
        public OTELTraceResourceSpanScopeSpanScope(
            string version,
            string name)
        {
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OTELTraceResourceSpanScopeSpanScope" /> class.
        /// </summary>
        public OTELTraceResourceSpanScopeSpanScope()
        {
        }
    }
}
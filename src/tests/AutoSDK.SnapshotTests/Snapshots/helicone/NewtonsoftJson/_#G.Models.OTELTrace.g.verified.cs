//HintName: G.Models.OTELTrace.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OTELTrace
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resourceSpans", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.OTELTraceResourceSpan> ResourceSpans { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OTELTrace" /> class.
        /// </summary>
        /// <param name="resourceSpans"></param>
        public OTELTrace(
            global::System.Collections.Generic.IList<global::G.OTELTraceResourceSpan> resourceSpans)
        {
            this.ResourceSpans = resourceSpans ?? throw new global::System.ArgumentNullException(nameof(resourceSpans));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OTELTrace" /> class.
        /// </summary>
        public OTELTrace()
        {
        }
    }
}
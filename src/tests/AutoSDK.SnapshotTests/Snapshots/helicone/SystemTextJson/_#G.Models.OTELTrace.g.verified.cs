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
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceSpans")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.OTELTraceResourceSpan> ResourceSpans { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OTELTrace" /> class.
        /// </summary>
        /// <param name="resourceSpans"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
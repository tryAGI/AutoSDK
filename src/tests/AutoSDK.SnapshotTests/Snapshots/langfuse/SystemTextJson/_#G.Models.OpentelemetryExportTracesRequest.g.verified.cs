//HintName: G.Models.OpentelemetryExportTracesRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpentelemetryExportTracesRequest
    {
        /// <summary>
        /// Array of resource spans containing trace data as defined in the OTLP specification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceSpans")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.OtelResourceSpan> ResourceSpans { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpentelemetryExportTracesRequest" /> class.
        /// </summary>
        /// <param name="resourceSpans">
        /// Array of resource spans containing trace data as defined in the OTLP specification
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpentelemetryExportTracesRequest(
            global::System.Collections.Generic.IList<global::G.OtelResourceSpan> resourceSpans)
        {
            this.ResourceSpans = resourceSpans ?? throw new global::System.ArgumentNullException(nameof(resourceSpans));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpentelemetryExportTracesRequest" /> class.
        /// </summary>
        public OpentelemetryExportTracesRequest()
        {
        }
    }
}
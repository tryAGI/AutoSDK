//HintName: G.Models.OtlpExportTraceServiceRequestResourceSpanResource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The resource that produced the spans.
    /// </summary>
    public sealed partial class OtlpExportTraceServiceRequestResourceSpanResource
    {
        /// <summary>
        /// Resource attributes as key-value pairs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public global::System.Collections.Generic.IList<global::G.OtlpKeyValue>? Attributes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OtlpExportTraceServiceRequestResourceSpanResource" /> class.
        /// </summary>
        /// <param name="attributes">
        /// Resource attributes as key-value pairs.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OtlpExportTraceServiceRequestResourceSpanResource(
            global::System.Collections.Generic.IList<global::G.OtlpKeyValue>? attributes)
        {
            this.Attributes = attributes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OtlpExportTraceServiceRequestResourceSpanResource" /> class.
        /// </summary>
        public OtlpExportTraceServiceRequestResourceSpanResource()
        {
        }
    }
}
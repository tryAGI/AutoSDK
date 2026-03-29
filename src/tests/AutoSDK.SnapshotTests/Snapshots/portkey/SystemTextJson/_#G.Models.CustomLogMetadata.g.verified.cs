//HintName: G.Models.CustomLogMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomLogMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        public string? TraceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("span_id")]
        public string? SpanId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("span_name")]
        public string? SpanName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additionalProperties")]
        public string? AdditionalProperties { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties2 { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomLogMetadata" /> class.
        /// </summary>
        /// <param name="traceId"></param>
        /// <param name="spanId"></param>
        /// <param name="spanName"></param>
        /// <param name="additionalProperties"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomLogMetadata(
            string? traceId,
            string? spanId,
            string? spanName,
            string? additionalProperties)
        {
            this.TraceId = traceId;
            this.SpanId = spanId;
            this.SpanName = spanName;
            this.AdditionalProperties = additionalProperties;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomLogMetadata" /> class.
        /// </summary>
        public CustomLogMetadata()
        {
        }
    }
}
//HintName: G.Models.MessagesRequestTrace.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Metadata for observability and tracing. Known keys (trace_id, trace_name, span_name, generation_name, parent_span_id) have special handling. Additional keys are passed through as custom metadata to configured broadcast destinations.
    /// </summary>
    public sealed partial class MessagesRequestTrace
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        public string? TraceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_name")]
        public string? TraceName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("span_name")]
        public string? SpanName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_name")]
        public string? GenerationName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_span_id")]
        public string? ParentSpanId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestTrace" /> class.
        /// </summary>
        /// <param name="traceId"></param>
        /// <param name="traceName"></param>
        /// <param name="spanName"></param>
        /// <param name="generationName"></param>
        /// <param name="parentSpanId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesRequestTrace(
            string? traceId,
            string? traceName,
            string? spanName,
            string? generationName,
            string? parentSpanId)
        {
            this.TraceId = traceId;
            this.TraceName = traceName;
            this.SpanName = spanName;
            this.GenerationName = generationName;
            this.ParentSpanId = parentSpanId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestTrace" /> class.
        /// </summary>
        public MessagesRequestTrace()
        {
        }
    }
}
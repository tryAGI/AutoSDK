//HintName: G.Models.ChatRequestTrace.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Metadata for observability and tracing. Known keys (trace_id, trace_name, span_name, generation_name, parent_span_id) have special handling. Additional keys are passed through as custom metadata to configured broadcast destinations.
    /// </summary>
    public sealed partial class ChatRequestTrace
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trace_id")]
        public string? TraceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trace_name")]
        public string? TraceName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("span_name")]
        public string? SpanName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generation_name")]
        public string? GenerationName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parent_span_id")]
        public string? ParentSpanId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRequestTrace" /> class.
        /// </summary>
        /// <param name="traceId"></param>
        /// <param name="traceName"></param>
        /// <param name="spanName"></param>
        /// <param name="generationName"></param>
        /// <param name="parentSpanId"></param>
        public ChatRequestTrace(
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
        /// Initializes a new instance of the <see cref="ChatRequestTrace" /> class.
        /// </summary>
        public ChatRequestTrace()
        {
        }
    }
}
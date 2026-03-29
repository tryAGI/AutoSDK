//HintName: G.Models.SpanContext.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpanContext
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trace_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string TraceId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("span_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string SpanId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trace_state", Required = global::Newtonsoft.Json.Required.Always)]
        public string TraceState { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpanContext" /> class.
        /// </summary>
        /// <param name="traceId"></param>
        /// <param name="spanId"></param>
        /// <param name="traceState"></param>
        public SpanContext(
            string traceId,
            string spanId,
            string traceState)
        {
            this.TraceId = traceId ?? throw new global::System.ArgumentNullException(nameof(traceId));
            this.SpanId = spanId ?? throw new global::System.ArgumentNullException(nameof(spanId));
            this.TraceState = traceState ?? throw new global::System.ArgumentNullException(nameof(traceState));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpanContext" /> class.
        /// </summary>
        public SpanContext()
        {
        }
    }
}
//HintName: G.Models.GetTraceResponseSpan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTraceResponseSpan
    {
        /// <summary>
        /// The internal span ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// The name of the span.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The trace ID this span belongs to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trace_id")]
        public string? TraceId { get; set; }

        /// <summary>
        /// The unique span identifier.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("span_id")]
        public string? SpanId { get; set; }

        /// <summary>
        /// The parent span ID, or null for root spans.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parent_id")]
        public string? ParentId { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when the span started.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start")]
        public string? Start { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when the span ended.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end")]
        public string? End { get; set; }

        /// <summary>
        /// Arbitrary key-value attributes attached to the span.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("attributes")]
        public object? Attributes { get; set; }

        /// <summary>
        /// Resource information for the span.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resource")]
        public object? Resource { get; set; }

        /// <summary>
        /// Span context information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("context")]
        public object? Context { get; set; }

        /// <summary>
        /// The span kind (e.g. INTERNAL, CLIENT, SERVER).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// The span status including status code.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public object? Status { get; set; }

        /// <summary>
        /// Events recorded on the span.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("events")]
        public byte[]? Events { get; set; }

        /// <summary>
        /// Links to other spans.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("links")]
        public byte[]? Links { get; set; }

        /// <summary>
        /// The PromptLayer request log ID associated with this span, if any.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_log_id")]
        public int? RequestLogId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTraceResponseSpan" /> class.
        /// </summary>
        /// <param name="id">
        /// The internal span ID.
        /// </param>
        /// <param name="name">
        /// The name of the span.
        /// </param>
        /// <param name="traceId">
        /// The trace ID this span belongs to.
        /// </param>
        /// <param name="spanId">
        /// The unique span identifier.
        /// </param>
        /// <param name="parentId">
        /// The parent span ID, or null for root spans.
        /// </param>
        /// <param name="start">
        /// ISO 8601 timestamp of when the span started.
        /// </param>
        /// <param name="end">
        /// ISO 8601 timestamp of when the span ended.
        /// </param>
        /// <param name="attributes">
        /// Arbitrary key-value attributes attached to the span.
        /// </param>
        /// <param name="resource">
        /// Resource information for the span.
        /// </param>
        /// <param name="context">
        /// Span context information.
        /// </param>
        /// <param name="kind">
        /// The span kind (e.g. INTERNAL, CLIENT, SERVER).
        /// </param>
        /// <param name="status">
        /// The span status including status code.
        /// </param>
        /// <param name="events">
        /// Events recorded on the span.
        /// </param>
        /// <param name="links">
        /// Links to other spans.
        /// </param>
        /// <param name="requestLogId">
        /// The PromptLayer request log ID associated with this span, if any.
        /// </param>
        public GetTraceResponseSpan(
            int? id,
            string? name,
            string? traceId,
            string? spanId,
            string? parentId,
            string? start,
            string? end,
            object? attributes,
            object? resource,
            object? context,
            string? kind,
            object? status,
            byte[]? events,
            byte[]? links,
            int? requestLogId)
        {
            this.Id = id;
            this.Name = name;
            this.TraceId = traceId;
            this.SpanId = spanId;
            this.ParentId = parentId;
            this.Start = start;
            this.End = end;
            this.Attributes = attributes;
            this.Resource = resource;
            this.Context = context;
            this.Kind = kind;
            this.Status = status;
            this.Events = events;
            this.Links = links;
            this.RequestLogId = requestLogId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTraceResponseSpan" /> class.
        /// </summary>
        public GetTraceResponseSpan()
        {
        }
    }
}
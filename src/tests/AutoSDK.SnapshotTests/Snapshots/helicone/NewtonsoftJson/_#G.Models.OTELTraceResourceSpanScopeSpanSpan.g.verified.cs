//HintName: G.Models.OTELTraceResourceSpanScopeSpanSpan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OTELTraceResourceSpanScopeSpanSpan
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("droppedLinksCount", Required = global::Newtonsoft.Json.Required.Always)]
        public double DroppedLinksCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("links", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<object> Links { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OTELTraceResourceSpanScopeSpanSpanStatus Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("droppedEventsCount", Required = global::Newtonsoft.Json.Required.Always)]
        public double DroppedEventsCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("events", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<object> Events { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("droppedAttributesCount", Required = global::Newtonsoft.Json.Required.Always)]
        public double DroppedAttributesCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("attributes", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.OTELTraceResourceSpanScopeSpanSpanAttribute> Attributes { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endTimeUnixNano", Required = global::Newtonsoft.Json.Required.Always)]
        public string EndTimeUnixNano { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("startTimeUnixNano", Required = global::Newtonsoft.Json.Required.Always)]
        public string StartTimeUnixNano { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("kind", Required = global::Newtonsoft.Json.Required.Always)]
        public double Kind { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("spanId", Required = global::Newtonsoft.Json.Required.Always)]
        public string SpanId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("traceId", Required = global::Newtonsoft.Json.Required.Always)]
        public string TraceId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OTELTraceResourceSpanScopeSpanSpan" /> class.
        /// </summary>
        /// <param name="droppedLinksCount"></param>
        /// <param name="links"></param>
        /// <param name="status"></param>
        /// <param name="droppedEventsCount"></param>
        /// <param name="events"></param>
        /// <param name="droppedAttributesCount"></param>
        /// <param name="attributes"></param>
        /// <param name="endTimeUnixNano"></param>
        /// <param name="startTimeUnixNano"></param>
        /// <param name="kind"></param>
        /// <param name="name"></param>
        /// <param name="spanId"></param>
        /// <param name="traceId"></param>
        public OTELTraceResourceSpanScopeSpanSpan(
            double droppedLinksCount,
            global::System.Collections.Generic.IList<object> links,
            global::G.OTELTraceResourceSpanScopeSpanSpanStatus status,
            double droppedEventsCount,
            global::System.Collections.Generic.IList<object> events,
            double droppedAttributesCount,
            global::System.Collections.Generic.IList<global::G.OTELTraceResourceSpanScopeSpanSpanAttribute> attributes,
            string endTimeUnixNano,
            string startTimeUnixNano,
            double kind,
            string name,
            string spanId,
            string traceId)
        {
            this.DroppedLinksCount = droppedLinksCount;
            this.Links = links ?? throw new global::System.ArgumentNullException(nameof(links));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.DroppedEventsCount = droppedEventsCount;
            this.Events = events ?? throw new global::System.ArgumentNullException(nameof(events));
            this.DroppedAttributesCount = droppedAttributesCount;
            this.Attributes = attributes ?? throw new global::System.ArgumentNullException(nameof(attributes));
            this.EndTimeUnixNano = endTimeUnixNano ?? throw new global::System.ArgumentNullException(nameof(endTimeUnixNano));
            this.StartTimeUnixNano = startTimeUnixNano ?? throw new global::System.ArgumentNullException(nameof(startTimeUnixNano));
            this.Kind = kind;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.SpanId = spanId ?? throw new global::System.ArgumentNullException(nameof(spanId));
            this.TraceId = traceId ?? throw new global::System.ArgumentNullException(nameof(traceId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OTELTraceResourceSpanScopeSpanSpan" /> class.
        /// </summary>
        public OTELTraceResourceSpanScopeSpanSpan()
        {
        }
    }
}
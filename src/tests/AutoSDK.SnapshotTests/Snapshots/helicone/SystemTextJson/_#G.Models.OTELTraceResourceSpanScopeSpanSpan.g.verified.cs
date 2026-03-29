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
        [global::System.Text.Json.Serialization.JsonPropertyName("droppedLinksCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double DroppedLinksCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("links")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Links { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OTELTraceResourceSpanScopeSpanSpanStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("droppedEventsCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double DroppedEventsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Events { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("droppedAttributesCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double DroppedAttributesCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.OTELTraceResourceSpanScopeSpanSpanAttribute> Attributes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endTimeUnixNano")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EndTimeUnixNano { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startTimeUnixNano")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StartTimeUnixNano { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Kind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spanId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SpanId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TraceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
//HintName: G.Models.SpanSearchStreamRequestPublic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpanSearchStreamRequestPublic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trace_id")]
        public global::System.Guid? TraceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_name")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SpanSearchStreamRequestPublicTypeJsonConverter))]
        public global::G.SpanSearchStreamRequestPublicType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filters")]
        public global::System.Collections.Generic.IList<global::G.SpanFilterPublic>? Filters { get; set; }

        /// <summary>
        /// Max number of spans to be streamed<br/>
        /// Default Value: 500
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_retrieved_id")]
        public global::System.Guid? LastRetrievedId { get; set; }

        /// <summary>
        /// Truncate image included in either input, output or metadata<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("truncate")]
        public bool? Truncate { get; set; }

        /// <summary>
        /// Filter spans created from this time (ISO-8601 format).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("from_time")]
        public global::System.DateTime? FromTime { get; set; }

        /// <summary>
        /// Filter spans created up to this time (ISO-8601 format). If not provided, defaults to current time. Must be after 'from_time'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("to_time")]
        public global::System.DateTime? ToTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpanSearchStreamRequestPublic" /> class.
        /// </summary>
        /// <param name="traceId"></param>
        /// <param name="projectName"></param>
        /// <param name="projectId"></param>
        /// <param name="type"></param>
        /// <param name="filters"></param>
        /// <param name="limit">
        /// Max number of spans to be streamed<br/>
        /// Default Value: 500
        /// </param>
        /// <param name="lastRetrievedId"></param>
        /// <param name="truncate">
        /// Truncate image included in either input, output or metadata<br/>
        /// Default Value: true
        /// </param>
        /// <param name="fromTime">
        /// Filter spans created from this time (ISO-8601 format).
        /// </param>
        /// <param name="toTime">
        /// Filter spans created up to this time (ISO-8601 format). If not provided, defaults to current time. Must be after 'from_time'.
        /// </param>
        public SpanSearchStreamRequestPublic(
            global::System.Guid? traceId,
            string? projectName,
            global::System.Guid? projectId,
            global::G.SpanSearchStreamRequestPublicType? type,
            global::System.Collections.Generic.IList<global::G.SpanFilterPublic>? filters,
            int? limit,
            global::System.Guid? lastRetrievedId,
            bool? truncate,
            global::System.DateTime? fromTime,
            global::System.DateTime? toTime)
        {
            this.TraceId = traceId;
            this.ProjectName = projectName;
            this.ProjectId = projectId;
            this.Type = type;
            this.Filters = filters;
            this.Limit = limit;
            this.LastRetrievedId = lastRetrievedId;
            this.Truncate = truncate;
            this.FromTime = fromTime;
            this.ToTime = toTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpanSearchStreamRequestPublic" /> class.
        /// </summary>
        public SpanSearchStreamRequestPublic()
        {
        }
    }
}
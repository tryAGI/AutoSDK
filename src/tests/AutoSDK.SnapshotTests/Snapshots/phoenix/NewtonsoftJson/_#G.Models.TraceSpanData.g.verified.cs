//HintName: G.Models.TraceSpanData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TraceSpanData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("span_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string SpanId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parent_id")]
        public string? ParentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("span_kind", Required = global::Newtonsoft.Json.Required.Always)]
        public string SpanKind { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status_code", Required = global::Newtonsoft.Json.Required.Always)]
        public string StatusCode { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_time", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime StartTime { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_time", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime EndTime { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceSpanData" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="spanId"></param>
        /// <param name="name"></param>
        /// <param name="spanKind"></param>
        /// <param name="statusCode"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="parentId"></param>
        public TraceSpanData(
            string id,
            string spanId,
            string name,
            string spanKind,
            string statusCode,
            global::System.DateTime startTime,
            global::System.DateTime endTime,
            string? parentId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.SpanId = spanId ?? throw new global::System.ArgumentNullException(nameof(spanId));
            this.ParentId = parentId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.SpanKind = spanKind ?? throw new global::System.ArgumentNullException(nameof(spanKind));
            this.StatusCode = statusCode ?? throw new global::System.ArgumentNullException(nameof(statusCode));
            this.StartTime = startTime;
            this.EndTime = endTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceSpanData" /> class.
        /// </summary>
        public TraceSpanData()
        {
        }
    }
}
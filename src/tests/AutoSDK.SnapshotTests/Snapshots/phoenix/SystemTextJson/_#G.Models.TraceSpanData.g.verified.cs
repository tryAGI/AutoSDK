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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("span_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SpanId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_id")]
        public string? ParentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("span_kind")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SpanKind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StatusCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime EndTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
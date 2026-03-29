//HintName: G.Models.TraceSearchStreamRequestPublic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TraceSearchStreamRequestPublic
    {
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
        [global::Newtonsoft.Json.JsonProperty("filters")]
        public global::System.Collections.Generic.IList<global::G.TraceFilterPublic>? Filters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_retrieved_id")]
        public global::System.Guid? LastRetrievedId { get; set; }

        /// <summary>
        /// Max number of traces to be streamed<br/>
        /// Default Value: 500
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Truncate input, output and metadata to slim payloads<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("truncate")]
        public bool? Truncate { get; set; }

        /// <summary>
        /// If true, returns attachment references like [file.png]; if false, downloads and reinjects stripped attachments<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("strip_attachments")]
        public bool? StripAttachments { get; set; }

        /// <summary>
        /// Filter traces created from this time (ISO-8601 format).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("from_time")]
        public global::System.DateTime? FromTime { get; set; }

        /// <summary>
        /// Filter traces created up to this time (ISO-8601 format). If not provided, defaults to current time. Must be after 'from_time'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("to_time")]
        public global::System.DateTime? ToTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceSearchStreamRequestPublic" /> class.
        /// </summary>
        /// <param name="projectName"></param>
        /// <param name="projectId"></param>
        /// <param name="filters"></param>
        /// <param name="lastRetrievedId"></param>
        /// <param name="limit">
        /// Max number of traces to be streamed<br/>
        /// Default Value: 500
        /// </param>
        /// <param name="truncate">
        /// Truncate input, output and metadata to slim payloads<br/>
        /// Default Value: true
        /// </param>
        /// <param name="stripAttachments">
        /// If true, returns attachment references like [file.png]; if false, downloads and reinjects stripped attachments<br/>
        /// Default Value: false
        /// </param>
        /// <param name="fromTime">
        /// Filter traces created from this time (ISO-8601 format).
        /// </param>
        /// <param name="toTime">
        /// Filter traces created up to this time (ISO-8601 format). If not provided, defaults to current time. Must be after 'from_time'.
        /// </param>
        public TraceSearchStreamRequestPublic(
            string? projectName,
            global::System.Guid? projectId,
            global::System.Collections.Generic.IList<global::G.TraceFilterPublic>? filters,
            global::System.Guid? lastRetrievedId,
            int? limit,
            bool? truncate,
            bool? stripAttachments,
            global::System.DateTime? fromTime,
            global::System.DateTime? toTime)
        {
            this.ProjectName = projectName;
            this.ProjectId = projectId;
            this.Filters = filters;
            this.LastRetrievedId = lastRetrievedId;
            this.Limit = limit;
            this.Truncate = truncate;
            this.StripAttachments = stripAttachments;
            this.FromTime = fromTime;
            this.ToTime = toTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceSearchStreamRequestPublic" /> class.
        /// </summary>
        public TraceSearchStreamRequestPublic()
        {
        }
    }
}
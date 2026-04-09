//HintName: G.Models.TraceWrite.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TraceWrite
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// If null, the default project is used
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_name")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_time", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime StartTime { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_time")]
        public global::System.DateTime? EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input")]
        public global::G.JsonListStringWrite? Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output")]
        public global::G.JsonListStringWrite? Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.JsonListStringWrite? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_info")]
        public global::G.ErrorInfoWrite? ErrorInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_updated_at")]
        public global::System.DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Time to first token in milliseconds
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ttft")]
        public double? Ttft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thread_id")]
        public string? ThreadId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TraceWriteSourceJsonConverter))]
        public global::G.TraceWriteSource? Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceWrite" /> class.
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="id"></param>
        /// <param name="projectName">
        /// If null, the default project is used
        /// </param>
        /// <param name="name"></param>
        /// <param name="endTime"></param>
        /// <param name="input"></param>
        /// <param name="output"></param>
        /// <param name="metadata"></param>
        /// <param name="tags"></param>
        /// <param name="errorInfo"></param>
        /// <param name="lastUpdatedAt"></param>
        /// <param name="ttft">
        /// Time to first token in milliseconds
        /// </param>
        /// <param name="threadId"></param>
        /// <param name="source"></param>
        public TraceWrite(
            global::System.DateTime startTime,
            global::System.Guid? id,
            string? projectName,
            string? name,
            global::System.DateTime? endTime,
            global::G.JsonListStringWrite? input,
            global::G.JsonListStringWrite? output,
            global::G.JsonListStringWrite? metadata,
            global::System.Collections.Generic.IList<string>? tags,
            global::G.ErrorInfoWrite? errorInfo,
            global::System.DateTime? lastUpdatedAt,
            double? ttft,
            string? threadId,
            global::G.TraceWriteSource? source)
        {
            this.Id = id;
            this.ProjectName = projectName;
            this.Name = name;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Input = input;
            this.Output = output;
            this.Metadata = metadata;
            this.Tags = tags;
            this.ErrorInfo = errorInfo;
            this.LastUpdatedAt = lastUpdatedAt;
            this.Ttft = ttft;
            this.ThreadId = threadId;
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceWrite" /> class.
        /// </summary>
        public TraceWrite()
        {
        }
    }
}
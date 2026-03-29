//HintName: G.Models.LogFlowRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LogFlowRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("versionId")]
        public string? VersionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("environment")]
        public string? Environment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path")]
        public string? Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output")]
        public string? Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputs")]
        public object? Inputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source")]
        public string? Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("startTime")]
        public global::System.DateTime? StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endTime")]
        public global::System.DateTime? EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("traceParentId")]
        public string? TraceParentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("save")]
        public bool? Save { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logId")]
        public string? LogId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LogFlowRequest" /> class.
        /// </summary>
        /// <param name="versionId"></param>
        /// <param name="environment"></param>
        /// <param name="path"></param>
        /// <param name="id"></param>
        /// <param name="output"></param>
        /// <param name="inputs"></param>
        /// <param name="source"></param>
        /// <param name="metadata"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="error"></param>
        /// <param name="traceParentId"></param>
        /// <param name="save"></param>
        /// <param name="logId"></param>
        public LogFlowRequest(
            string? versionId,
            string? environment,
            string? path,
            string? id,
            string? output,
            object? inputs,
            string? source,
            object? metadata,
            global::System.DateTime? startTime,
            global::System.DateTime? endTime,
            string? error,
            string? traceParentId,
            bool? save,
            string? logId)
        {
            this.VersionId = versionId;
            this.Environment = environment;
            this.Path = path;
            this.Id = id;
            this.Output = output;
            this.Inputs = inputs;
            this.Source = source;
            this.Metadata = metadata;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Error = error;
            this.TraceParentId = traceParentId;
            this.Save = save;
            this.LogId = logId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogFlowRequest" /> class.
        /// </summary>
        public LogFlowRequest()
        {
        }
    }
}
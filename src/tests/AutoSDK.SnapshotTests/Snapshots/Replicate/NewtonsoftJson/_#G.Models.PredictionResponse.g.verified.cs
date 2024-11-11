//HintName: G.Models.PredictionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PredictionResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed_at")]
        public string? CompletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data_removed")]
        public bool? DataRemoved { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public object? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input")]
        public global::G.PredictionResponseInput? Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logs")]
        public string? Logs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metrics")]
        public global::G.PredictionResponseMetrics? Metrics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output")]
        public string? Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("started_at")]
        public string? StartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("urls")]
        public global::G.PredictionResponseUrls? Urls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PredictionResponse" /> class.
        /// </summary>
        /// <param name="completedAt"></param>
        /// <param name="createdAt"></param>
        /// <param name="dataRemoved"></param>
        /// <param name="error"></param>
        /// <param name="id"></param>
        /// <param name="input"></param>
        /// <param name="logs"></param>
        /// <param name="metrics"></param>
        /// <param name="output"></param>
        /// <param name="startedAt"></param>
        /// <param name="status"></param>
        /// <param name="urls"></param>
        /// <param name="version"></param>
        public PredictionResponse(
            string? completedAt,
            string? createdAt,
            bool? dataRemoved,
            object? error,
            string? id,
            global::G.PredictionResponseInput? input,
            string? logs,
            global::G.PredictionResponseMetrics? metrics,
            string? output,
            string? startedAt,
            string? status,
            global::G.PredictionResponseUrls? urls,
            string? version)
        {
            this.CompletedAt = completedAt;
            this.CreatedAt = createdAt;
            this.DataRemoved = dataRemoved;
            this.Error = error;
            this.Id = id;
            this.Input = input;
            this.Logs = logs;
            this.Metrics = metrics;
            this.Output = output;
            this.StartedAt = startedAt;
            this.Status = status;
            this.Urls = urls;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PredictionResponse" /> class.
        /// </summary>
        public PredictionResponse()
        {
        }
    }
}
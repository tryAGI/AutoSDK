//HintName: G.Models.MetadataSendTelemetryRequestEventVariant4Data.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MetadataSendTelemetryRequestEventVariant4Data
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string SessionId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_id")]
        public string? RunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string ErrorType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_message", Required = global::Newtonsoft.Json.Required.Always)]
        public string ErrorMessage { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("context")]
        public string? Context { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("http_status")]
        public double? HttpStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_id")]
        public string? ModelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("recent_chunks")]
        public global::System.Collections.Generic.IList<object>? RecentChunks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("debug_log_tail")]
        public string? DebugLogTail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataSendTelemetryRequestEventVariant4Data" /> class.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="errorType"></param>
        /// <param name="errorMessage"></param>
        /// <param name="agentId"></param>
        /// <param name="runId"></param>
        /// <param name="context"></param>
        /// <param name="httpStatus"></param>
        /// <param name="modelId"></param>
        /// <param name="recentChunks"></param>
        /// <param name="debugLogTail"></param>
        public MetadataSendTelemetryRequestEventVariant4Data(
            string sessionId,
            string errorType,
            string errorMessage,
            string? agentId,
            string? runId,
            string? context,
            double? httpStatus,
            string? modelId,
            global::System.Collections.Generic.IList<object>? recentChunks,
            string? debugLogTail)
        {
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.AgentId = agentId;
            this.RunId = runId;
            this.ErrorType = errorType ?? throw new global::System.ArgumentNullException(nameof(errorType));
            this.ErrorMessage = errorMessage ?? throw new global::System.ArgumentNullException(nameof(errorMessage));
            this.Context = context;
            this.HttpStatus = httpStatus;
            this.ModelId = modelId;
            this.RecentChunks = recentChunks;
            this.DebugLogTail = debugLogTail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataSendTelemetryRequestEventVariant4Data" /> class.
        /// </summary>
        public MetadataSendTelemetryRequestEventVariant4Data()
        {
        }
    }
}
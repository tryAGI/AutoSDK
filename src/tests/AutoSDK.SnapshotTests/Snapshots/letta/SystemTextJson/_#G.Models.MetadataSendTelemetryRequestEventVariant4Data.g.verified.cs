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
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        public string? RunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ErrorType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ErrorMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public string? Context { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("http_status")]
        public double? HttpStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string? ModelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recent_chunks")]
        public global::System.Collections.Generic.IList<object>? RecentChunks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("debug_log_tail")]
        public string? DebugLogTail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
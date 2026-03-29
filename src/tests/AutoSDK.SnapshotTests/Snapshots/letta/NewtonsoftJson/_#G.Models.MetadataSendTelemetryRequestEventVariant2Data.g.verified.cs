//HintName: G.Models.MetadataSendTelemetryRequestEventVariant2Data.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MetadataSendTelemetryRequestEventVariant2Data
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
        [global::Newtonsoft.Json.JsonProperty("duration", Required = global::Newtonsoft.Json.Required.Always)]
        public double Duration { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message_count", Required = global::Newtonsoft.Json.Required.Always)]
        public double MessageCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_call_count", Required = global::Newtonsoft.Json.Required.Always)]
        public double ToolCallCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exit_reason")]
        public string? ExitReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_api_ms")]
        public double? TotalApiMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_wall_ms")]
        public double? TotalWallMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_tokens")]
        public double? PromptTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion_tokens")]
        public double? CompletionTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_tokens")]
        public double? TotalTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cached_tokens")]
        public double? CachedTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reasoning_tokens")]
        public double? ReasoningTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("step_count")]
        public double? StepCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataSendTelemetryRequestEventVariant2Data" /> class.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="duration"></param>
        /// <param name="messageCount"></param>
        /// <param name="toolCallCount"></param>
        /// <param name="agentId"></param>
        /// <param name="exitReason"></param>
        /// <param name="totalApiMs"></param>
        /// <param name="totalWallMs"></param>
        /// <param name="promptTokens"></param>
        /// <param name="completionTokens"></param>
        /// <param name="totalTokens"></param>
        /// <param name="cachedTokens"></param>
        /// <param name="reasoningTokens"></param>
        /// <param name="stepCount"></param>
        public MetadataSendTelemetryRequestEventVariant2Data(
            string sessionId,
            double duration,
            double messageCount,
            double toolCallCount,
            string? agentId,
            string? exitReason,
            double? totalApiMs,
            double? totalWallMs,
            double? promptTokens,
            double? completionTokens,
            double? totalTokens,
            double? cachedTokens,
            double? reasoningTokens,
            double? stepCount)
        {
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.AgentId = agentId;
            this.Duration = duration;
            this.MessageCount = messageCount;
            this.ToolCallCount = toolCallCount;
            this.ExitReason = exitReason;
            this.TotalApiMs = totalApiMs;
            this.TotalWallMs = totalWallMs;
            this.PromptTokens = promptTokens;
            this.CompletionTokens = completionTokens;
            this.TotalTokens = totalTokens;
            this.CachedTokens = cachedTokens;
            this.ReasoningTokens = reasoningTokens;
            this.StepCount = stepCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataSendTelemetryRequestEventVariant2Data" /> class.
        /// </summary>
        public MetadataSendTelemetryRequestEventVariant2Data()
        {
        }
    }
}
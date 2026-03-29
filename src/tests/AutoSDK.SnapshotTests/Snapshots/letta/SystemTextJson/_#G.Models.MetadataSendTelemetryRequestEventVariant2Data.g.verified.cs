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
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Duration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MessageCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ToolCallCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exit_reason")]
        public string? ExitReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_api_ms")]
        public double? TotalApiMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_wall_ms")]
        public double? TotalWallMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        public double? PromptTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens")]
        public double? CompletionTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        public double? TotalTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cached_tokens")]
        public double? CachedTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_tokens")]
        public double? ReasoningTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step_count")]
        public double? StepCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
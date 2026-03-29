//HintName: G.Models.MetadataSendFeedbackRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MetadataSendFeedbackRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Default Value: letta-code
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feature")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MetadataSendFeedbackRequestFeatureJsonConverter))]
        public global::G.MetadataSendFeedbackRequestFeature? Feature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform")]
        public string? Platform { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        public string? Settings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("local_time")]
        public string? LocalTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("device_type")]
        public string? DeviceType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cwd")]
        public string? Cwd { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("step_count")]
        public double? StepCount { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("cached_input_tokens")]
        public double? CachedInputTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_write_tokens")]
        public double? CacheWriteTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_tokens")]
        public double? ReasoningTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_tokens")]
        public double? ContextTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_name")]
        public string? AgentName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_description")]
        public string? AgentDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billing_tier")]
        public string? BillingTier { get; set; }

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
        /// Initializes a new instance of the <see cref="MetadataSendFeedbackRequest" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="feature">
        /// Default Value: letta-code
        /// </param>
        /// <param name="agentId"></param>
        /// <param name="sessionId"></param>
        /// <param name="version"></param>
        /// <param name="platform"></param>
        /// <param name="settings"></param>
        /// <param name="localTime"></param>
        /// <param name="deviceType"></param>
        /// <param name="cwd"></param>
        /// <param name="totalApiMs"></param>
        /// <param name="totalWallMs"></param>
        /// <param name="stepCount"></param>
        /// <param name="promptTokens"></param>
        /// <param name="completionTokens"></param>
        /// <param name="totalTokens"></param>
        /// <param name="cachedInputTokens"></param>
        /// <param name="cacheWriteTokens"></param>
        /// <param name="reasoningTokens"></param>
        /// <param name="contextTokens"></param>
        /// <param name="agentName"></param>
        /// <param name="agentDescription"></param>
        /// <param name="model"></param>
        /// <param name="billingTier"></param>
        /// <param name="recentChunks"></param>
        /// <param name="debugLogTail"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MetadataSendFeedbackRequest(
            string message,
            global::G.MetadataSendFeedbackRequestFeature? feature,
            string? agentId,
            string? sessionId,
            string? version,
            string? platform,
            string? settings,
            string? localTime,
            string? deviceType,
            string? cwd,
            double? totalApiMs,
            double? totalWallMs,
            double? stepCount,
            double? promptTokens,
            double? completionTokens,
            double? totalTokens,
            double? cachedInputTokens,
            double? cacheWriteTokens,
            double? reasoningTokens,
            double? contextTokens,
            string? agentName,
            string? agentDescription,
            string? model,
            string? billingTier,
            global::System.Collections.Generic.IList<object>? recentChunks,
            string? debugLogTail)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Feature = feature;
            this.AgentId = agentId;
            this.SessionId = sessionId;
            this.Version = version;
            this.Platform = platform;
            this.Settings = settings;
            this.LocalTime = localTime;
            this.DeviceType = deviceType;
            this.Cwd = cwd;
            this.TotalApiMs = totalApiMs;
            this.TotalWallMs = totalWallMs;
            this.StepCount = stepCount;
            this.PromptTokens = promptTokens;
            this.CompletionTokens = completionTokens;
            this.TotalTokens = totalTokens;
            this.CachedInputTokens = cachedInputTokens;
            this.CacheWriteTokens = cacheWriteTokens;
            this.ReasoningTokens = reasoningTokens;
            this.ContextTokens = contextTokens;
            this.AgentName = agentName;
            this.AgentDescription = agentDescription;
            this.Model = model;
            this.BillingTier = billingTier;
            this.RecentChunks = recentChunks;
            this.DebugLogTail = debugLogTail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataSendFeedbackRequest" /> class.
        /// </summary>
        public MetadataSendFeedbackRequest()
        {
        }
    }
}
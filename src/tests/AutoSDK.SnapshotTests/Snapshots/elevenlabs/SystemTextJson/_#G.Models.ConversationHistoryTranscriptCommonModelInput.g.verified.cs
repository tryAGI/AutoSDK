﻿//HintName: G.Models.ConversationHistoryTranscriptCommonModelInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationHistoryTranscriptCommonModelInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConversationHistoryTranscriptCommonModelInputRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ConversationHistoryTranscriptCommonModelInputRole Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls")]
        public global::System.Collections.Generic.IList<global::G.ConversationHistoryTranscriptToolCallCommonModel>? ToolCalls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_results")]
        public global::System.Collections.Generic.IList<global::G.ConversationHistoryTranscriptToolResultCommonModel>? ToolResults { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback")]
        public global::G.UserFeedback? Feedback { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_override")]
        public string? LlmOverride { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_in_call_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TimeInCallSecs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_turn_metrics")]
        public global::G.ConversationTurnMetrics? ConversationTurnMetrics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rag_retrieval_info")]
        public global::G.RagRetrievalInfo? RagRetrievalInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_usage")]
        public global::G.LLMUsageInput? LlmUsage { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interrupted")]
        public bool? Interrupted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_message")]
        public string? OriginalMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_medium")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConversationHistoryTranscriptCommonModelInputSourceMediumJsonConverter))]
        public global::G.ConversationHistoryTranscriptCommonModelInputSourceMedium? SourceMedium { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryTranscriptCommonModelInput" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="message"></param>
        /// <param name="toolCalls"></param>
        /// <param name="toolResults"></param>
        /// <param name="feedback"></param>
        /// <param name="llmOverride"></param>
        /// <param name="timeInCallSecs"></param>
        /// <param name="conversationTurnMetrics"></param>
        /// <param name="ragRetrievalInfo"></param>
        /// <param name="llmUsage"></param>
        /// <param name="interrupted">
        /// Default Value: false
        /// </param>
        /// <param name="originalMessage"></param>
        /// <param name="sourceMedium"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationHistoryTranscriptCommonModelInput(
            global::G.ConversationHistoryTranscriptCommonModelInputRole role,
            int timeInCallSecs,
            string? message,
            global::System.Collections.Generic.IList<global::G.ConversationHistoryTranscriptToolCallCommonModel>? toolCalls,
            global::System.Collections.Generic.IList<global::G.ConversationHistoryTranscriptToolResultCommonModel>? toolResults,
            global::G.UserFeedback? feedback,
            string? llmOverride,
            global::G.ConversationTurnMetrics? conversationTurnMetrics,
            global::G.RagRetrievalInfo? ragRetrievalInfo,
            global::G.LLMUsageInput? llmUsage,
            bool? interrupted,
            string? originalMessage,
            global::G.ConversationHistoryTranscriptCommonModelInputSourceMedium? sourceMedium)
        {
            this.Role = role;
            this.TimeInCallSecs = timeInCallSecs;
            this.Message = message;
            this.ToolCalls = toolCalls;
            this.ToolResults = toolResults;
            this.Feedback = feedback;
            this.LlmOverride = llmOverride;
            this.ConversationTurnMetrics = conversationTurnMetrics;
            this.RagRetrievalInfo = ragRetrievalInfo;
            this.LlmUsage = llmUsage;
            this.Interrupted = interrupted;
            this.OriginalMessage = originalMessage;
            this.SourceMedium = sourceMedium;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryTranscriptCommonModelInput" /> class.
        /// </summary>
        public ConversationHistoryTranscriptCommonModelInput()
        {
        }
    }
}
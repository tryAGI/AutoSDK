//HintName: G.Models.ConversationHistoryTranscriptCommonModelInput.g.cs

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
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ConversationHistoryTranscriptCommonModelInputRole Role { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_metadata")]
        public global::G.AgentMetadata? AgentMetadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("multivoice_message")]
        public global::G.ConversationHistoryMultivoiceMessageModel? MultivoiceMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_calls")]
        public global::System.Collections.Generic.IList<global::G.ConversationHistoryTranscriptToolCallCommonModelInput>? ToolCalls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_results")]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::G.ConversationHistoryTranscriptSystemToolResultCommonModelInput, global::G.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModel, global::G.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput>>? ToolResults { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feedback")]
        public global::G.UserFeedback? Feedback { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("llm_override")]
        public string? LlmOverride { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("time_in_call_secs", Required = global::Newtonsoft.Json.Required.Always)]
        public int TimeInCallSecs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conversation_turn_metrics")]
        public global::G.ConversationTurnMetrics? ConversationTurnMetrics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rag_retrieval_info")]
        public global::G.RagRetrievalInfo? RagRetrievalInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("llm_usage")]
        public global::G.LLMUsageInput? LlmUsage { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("interrupted")]
        public bool? Interrupted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("original_message")]
        public string? OriginalMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_medium")]
        public global::G.ChatSourceMedium? SourceMedium { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryTranscriptCommonModelInput" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="agentMetadata"></param>
        /// <param name="message"></param>
        /// <param name="multivoiceMessage"></param>
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
        public ConversationHistoryTranscriptCommonModelInput(
            global::G.ConversationHistoryTranscriptCommonModelInputRole role,
            int timeInCallSecs,
            global::G.AgentMetadata? agentMetadata,
            string? message,
            global::G.ConversationHistoryMultivoiceMessageModel? multivoiceMessage,
            global::System.Collections.Generic.IList<global::G.ConversationHistoryTranscriptToolCallCommonModelInput>? toolCalls,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::G.ConversationHistoryTranscriptSystemToolResultCommonModelInput, global::G.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModel, global::G.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput>>? toolResults,
            global::G.UserFeedback? feedback,
            string? llmOverride,
            global::G.ConversationTurnMetrics? conversationTurnMetrics,
            global::G.RagRetrievalInfo? ragRetrievalInfo,
            global::G.LLMUsageInput? llmUsage,
            bool? interrupted,
            string? originalMessage,
            global::G.ChatSourceMedium? sourceMedium)
        {
            this.Role = role;
            this.TimeInCallSecs = timeInCallSecs;
            this.AgentMetadata = agentMetadata;
            this.Message = message;
            this.MultivoiceMessage = multivoiceMessage;
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
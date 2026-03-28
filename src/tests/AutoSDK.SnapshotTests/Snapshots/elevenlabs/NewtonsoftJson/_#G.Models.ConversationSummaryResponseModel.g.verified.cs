//HintName: G.Models.ConversationSummaryResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationSummaryResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("branch_id")]
        public string? BranchId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version_id")]
        public string? VersionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_name")]
        public string? AgentName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conversation_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ConversationId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_time_unix_secs", Required = global::Newtonsoft.Json.Required.Always)]
        public int StartTimeUnixSecs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("call_duration_secs", Required = global::Newtonsoft.Json.Required.Always)]
        public int CallDurationSecs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int MessageCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ConversationSummaryResponseModelStatus Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("call_successful", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EvaluationSuccessResult CallSuccessful { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcript_summary")]
        public string? TranscriptSummary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("call_summary_title")]
        public string? CallSummaryTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("main_language")]
        public string? MainLanguage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conversation_initiation_source")]
        public global::G.ConversationInitiationSource? ConversationInitiationSource { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_names")]
        public global::System.Collections.Generic.IList<string>? ToolNames { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("direction")]
        public global::G.ConversationSummaryResponseModelDirection2? Direction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rating")]
        public double? Rating { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationSummaryResponseModel" /> class.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="conversationId"></param>
        /// <param name="startTimeUnixSecs"></param>
        /// <param name="callDurationSecs"></param>
        /// <param name="messageCount"></param>
        /// <param name="status"></param>
        /// <param name="callSuccessful"></param>
        /// <param name="branchId"></param>
        /// <param name="versionId"></param>
        /// <param name="agentName"></param>
        /// <param name="transcriptSummary"></param>
        /// <param name="callSummaryTitle"></param>
        /// <param name="mainLanguage"></param>
        /// <param name="conversationInitiationSource"></param>
        /// <param name="toolNames"></param>
        /// <param name="direction"></param>
        /// <param name="rating"></param>
        public ConversationSummaryResponseModel(
            string agentId,
            string conversationId,
            int startTimeUnixSecs,
            int callDurationSecs,
            int messageCount,
            global::G.ConversationSummaryResponseModelStatus status,
            global::G.EvaluationSuccessResult callSuccessful,
            string? branchId,
            string? versionId,
            string? agentName,
            string? transcriptSummary,
            string? callSummaryTitle,
            string? mainLanguage,
            global::G.ConversationInitiationSource? conversationInitiationSource,
            global::System.Collections.Generic.IList<string>? toolNames,
            global::G.ConversationSummaryResponseModelDirection2? direction,
            double? rating)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.BranchId = branchId;
            this.VersionId = versionId;
            this.AgentName = agentName;
            this.ConversationId = conversationId ?? throw new global::System.ArgumentNullException(nameof(conversationId));
            this.StartTimeUnixSecs = startTimeUnixSecs;
            this.CallDurationSecs = callDurationSecs;
            this.MessageCount = messageCount;
            this.Status = status;
            this.CallSuccessful = callSuccessful;
            this.TranscriptSummary = transcriptSummary;
            this.CallSummaryTitle = callSummaryTitle;
            this.MainLanguage = mainLanguage;
            this.ConversationInitiationSource = conversationInitiationSource;
            this.ToolNames = toolNames;
            this.Direction = direction;
            this.Rating = rating;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationSummaryResponseModel" /> class.
        /// </summary>
        public ConversationSummaryResponseModel()
        {
        }
    }
}
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationSummaryResponseModel" /> class.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="agentName"></param>
        /// <param name="conversationId"></param>
        /// <param name="startTimeUnixSecs"></param>
        /// <param name="callDurationSecs"></param>
        /// <param name="messageCount"></param>
        /// <param name="status"></param>
        /// <param name="callSuccessful"></param>
        public ConversationSummaryResponseModel(
            string agentId,
            string conversationId,
            int startTimeUnixSecs,
            int callDurationSecs,
            int messageCount,
            global::G.ConversationSummaryResponseModelStatus status,
            global::G.EvaluationSuccessResult callSuccessful,
            string? agentName)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.ConversationId = conversationId ?? throw new global::System.ArgumentNullException(nameof(conversationId));
            this.StartTimeUnixSecs = startTimeUnixSecs;
            this.CallDurationSecs = callDurationSecs;
            this.MessageCount = messageCount;
            this.Status = status;
            this.CallSuccessful = callSuccessful;
            this.AgentName = agentName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationSummaryResponseModel" /> class.
        /// </summary>
        public ConversationSummaryResponseModel()
        {
        }
    }
}
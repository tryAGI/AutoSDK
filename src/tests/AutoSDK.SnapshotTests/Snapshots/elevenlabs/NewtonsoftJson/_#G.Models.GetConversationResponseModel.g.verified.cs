//HintName: G.Models.GetConversationResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConversationResponseModel
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
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GetConversationResponseModelStatusJsonConverter))]
        public global::G.GetConversationResponseModelStatus Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("branch_id")]
        public string? BranchId { get; set; }

        /// <summary>
        /// The ID of the agent version used for this conversation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version_id")]
        public string? VersionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ConversationHistoryMetadataCommonModel Metadata { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("analysis")]
        public global::G.ConversationHistoryAnalysisCommonModel? Analysis { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conversation_initiation_client_data")]
        public global::G.ConversationInitiationClientDataRequestOutput? ConversationInitiationClientData { get; set; }

        /// <summary>
        /// Default Value: production
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("environment")]
        public string? Environment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conversation_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ConversationId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_audio", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasAudio { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_user_audio", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasUserAudio { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_response_audio", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasResponseAudio { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcript", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ConversationHistoryTranscriptResponseModel> Transcript { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConversationResponseModel" /> class.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="status"></param>
        /// <param name="metadata"></param>
        /// <param name="conversationId"></param>
        /// <param name="hasAudio"></param>
        /// <param name="hasUserAudio"></param>
        /// <param name="hasResponseAudio"></param>
        /// <param name="transcript"></param>
        /// <param name="agentName"></param>
        /// <param name="userId"></param>
        /// <param name="branchId"></param>
        /// <param name="versionId">
        /// The ID of the agent version used for this conversation
        /// </param>
        /// <param name="analysis"></param>
        /// <param name="conversationInitiationClientData"></param>
        /// <param name="environment">
        /// Default Value: production
        /// </param>
        public GetConversationResponseModel(
            string agentId,
            global::G.GetConversationResponseModelStatus status,
            global::G.ConversationHistoryMetadataCommonModel metadata,
            string conversationId,
            bool hasAudio,
            bool hasUserAudio,
            bool hasResponseAudio,
            global::System.Collections.Generic.IList<global::G.ConversationHistoryTranscriptResponseModel> transcript,
            string? agentName,
            string? userId,
            string? branchId,
            string? versionId,
            global::G.ConversationHistoryAnalysisCommonModel? analysis,
            global::G.ConversationInitiationClientDataRequestOutput? conversationInitiationClientData,
            string? environment)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.AgentName = agentName;
            this.Status = status;
            this.UserId = userId;
            this.BranchId = branchId;
            this.VersionId = versionId;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.Analysis = analysis;
            this.ConversationInitiationClientData = conversationInitiationClientData;
            this.Environment = environment;
            this.ConversationId = conversationId ?? throw new global::System.ArgumentNullException(nameof(conversationId));
            this.HasAudio = hasAudio;
            this.HasUserAudio = hasUserAudio;
            this.HasResponseAudio = hasResponseAudio;
            this.Transcript = transcript ?? throw new global::System.ArgumentNullException(nameof(transcript));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConversationResponseModel" /> class.
        /// </summary>
        public GetConversationResponseModel()
        {
        }
    }
}
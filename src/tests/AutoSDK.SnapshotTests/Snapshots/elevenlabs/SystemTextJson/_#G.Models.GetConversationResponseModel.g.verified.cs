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
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_name")]
        public string? AgentName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GetConversationResponseModelStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetConversationResponseModelStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch_id")]
        public string? BranchId { get; set; }

        /// <summary>
        /// The ID of the agent version used for this conversation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_id")]
        public string? VersionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ConversationHistoryMetadataCommonModel Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analysis")]
        public global::G.ConversationHistoryAnalysisCommonModel? Analysis { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_initiation_client_data")]
        public global::G.ConversationInitiationClientDataRequestOutput? ConversationInitiationClientData { get; set; }

        /// <summary>
        /// Default Value: production
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        public string? Environment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConversationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasAudio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_user_audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasUserAudio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_response_audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasResponseAudio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ConversationHistoryTranscriptResponseModel> Transcript { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConversationResponseModel" /> class.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="agentName"></param>
        /// <param name="status"></param>
        /// <param name="userId"></param>
        /// <param name="branchId"></param>
        /// <param name="versionId">
        /// The ID of the agent version used for this conversation
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="analysis"></param>
        /// <param name="conversationInitiationClientData"></param>
        /// <param name="environment">
        /// Default Value: production
        /// </param>
        /// <param name="conversationId"></param>
        /// <param name="hasAudio"></param>
        /// <param name="hasUserAudio"></param>
        /// <param name="hasResponseAudio"></param>
        /// <param name="transcript"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
            this.Status = status;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.ConversationId = conversationId ?? throw new global::System.ArgumentNullException(nameof(conversationId));
            this.HasAudio = hasAudio;
            this.HasUserAudio = hasUserAudio;
            this.HasResponseAudio = hasResponseAudio;
            this.Transcript = transcript ?? throw new global::System.ArgumentNullException(nameof(transcript));
            this.AgentName = agentName;
            this.UserId = userId;
            this.BranchId = branchId;
            this.VersionId = versionId;
            this.Analysis = analysis;
            this.ConversationInitiationClientData = conversationInitiationClientData;
            this.Environment = environment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConversationResponseModel" /> class.
        /// </summary>
        public GetConversationResponseModel()
        {
        }
    }
}
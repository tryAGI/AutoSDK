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
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConversationId { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ConversationHistoryTranscriptCommonModelOutput> Transcript { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConversationResponseModel" /> class.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="conversationId"></param>
        /// <param name="status"></param>
        /// <param name="transcript"></param>
        /// <param name="metadata"></param>
        /// <param name="analysis"></param>
        /// <param name="conversationInitiationClientData"></param>
        /// <param name="hasAudio"></param>
        /// <param name="hasUserAudio"></param>
        /// <param name="hasResponseAudio"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConversationResponseModel(
            string agentId,
            string conversationId,
            global::G.GetConversationResponseModelStatus status,
            global::System.Collections.Generic.IList<global::G.ConversationHistoryTranscriptCommonModelOutput> transcript,
            global::G.ConversationHistoryMetadataCommonModel metadata,
            bool hasAudio,
            bool hasUserAudio,
            bool hasResponseAudio,
            global::G.ConversationHistoryAnalysisCommonModel? analysis,
            global::G.ConversationInitiationClientDataRequestOutput? conversationInitiationClientData)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.ConversationId = conversationId ?? throw new global::System.ArgumentNullException(nameof(conversationId));
            this.Status = status;
            this.Transcript = transcript ?? throw new global::System.ArgumentNullException(nameof(transcript));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.HasAudio = hasAudio;
            this.HasUserAudio = hasUserAudio;
            this.HasResponseAudio = hasResponseAudio;
            this.Analysis = analysis;
            this.ConversationInitiationClientData = conversationInitiationClientData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConversationResponseModel" /> class.
        /// </summary>
        public GetConversationResponseModel()
        {
        }
    }
}
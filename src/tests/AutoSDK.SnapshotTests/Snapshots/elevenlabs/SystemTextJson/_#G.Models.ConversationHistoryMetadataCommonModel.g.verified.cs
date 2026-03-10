//HintName: G.Models.ConversationHistoryMetadataCommonModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationHistoryMetadataCommonModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time_unix_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartTimeUnixSecs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accepted_time_unix_secs")]
        public int? AcceptedTimeUnixSecs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_duration_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CallDurationSecs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        public int? Cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deletion_settings")]
        public global::G.ConversationDeletionSettings? DeletionSettings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback")]
        public global::G.ConversationHistoryFeedbackCommonModel? Feedback { get; set; }

        /// <summary>
        /// Default Value: public
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorization_method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AuthorizationMethodJsonConverter))]
        public global::G.AuthorizationMethod? AuthorizationMethod { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("charging")]
        public global::G.ConversationChargingCommonModel? Charging { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_call")]
        public global::G.PhoneCallVariant1? PhoneCall { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_call")]
        public global::G.ConversationHistoryBatchCallModel? BatchCall { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("termination_reason")]
        public string? TerminationReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::G.ConversationHistoryErrorCommonModel? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warnings")]
        public global::System.Collections.Generic.IList<string>? Warnings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("main_language")]
        public string? MainLanguage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rag_usage")]
        public global::G.ConversationHistoryRagUsageCommonModel? RagUsage { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_only")]
        public bool? TextOnly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("features_usage")]
        public global::G.FeaturesUsageCommonModel? FeaturesUsage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eleven_assistant")]
        public global::G.ConversationHistoryElevenAssistantCommonModel? ElevenAssistant { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initiator_id")]
        public string? InitiatorId { get; set; }

        /// <summary>
        /// Enum representing the possible sources for conversation initiation.<br/>
        /// Default Value: unknown
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_initiation_source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConversationInitiationSourceJsonConverter))]
        public global::G.ConversationInitiationSource? ConversationInitiationSource { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_initiation_source_version")]
        public string? ConversationInitiationSourceVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("async_metadata")]
        public global::G.AsyncConversationMetadata? AsyncMetadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("whatsapp")]
        public global::G.WhatsAppConversationInfo? Whatsapp { get; set; }

        /// <summary>
        /// Default Value: unknown
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_created_from")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AgentDefinitionSourceJsonConverter))]
        public global::G.AgentDefinitionSource? AgentCreatedFrom { get; set; }

        /// <summary>
        /// Default Value: unknown
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_last_updated_from")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AgentDefinitionSourceJsonConverter))]
        public global::G.AgentDefinitionSource? AgentLastUpdatedFrom { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryMetadataCommonModel" /> class.
        /// </summary>
        /// <param name="startTimeUnixSecs"></param>
        /// <param name="acceptedTimeUnixSecs"></param>
        /// <param name="callDurationSecs"></param>
        /// <param name="cost"></param>
        /// <param name="deletionSettings"></param>
        /// <param name="feedback"></param>
        /// <param name="authorizationMethod">
        /// Default Value: public
        /// </param>
        /// <param name="charging"></param>
        /// <param name="phoneCall"></param>
        /// <param name="batchCall"></param>
        /// <param name="terminationReason"></param>
        /// <param name="error"></param>
        /// <param name="warnings"></param>
        /// <param name="mainLanguage"></param>
        /// <param name="ragUsage"></param>
        /// <param name="textOnly">
        /// Default Value: false
        /// </param>
        /// <param name="featuresUsage"></param>
        /// <param name="elevenAssistant"></param>
        /// <param name="initiatorId"></param>
        /// <param name="conversationInitiationSource">
        /// Enum representing the possible sources for conversation initiation.<br/>
        /// Default Value: unknown
        /// </param>
        /// <param name="conversationInitiationSourceVersion"></param>
        /// <param name="timezone"></param>
        /// <param name="asyncMetadata"></param>
        /// <param name="whatsapp"></param>
        /// <param name="agentCreatedFrom">
        /// Default Value: unknown
        /// </param>
        /// <param name="agentLastUpdatedFrom">
        /// Default Value: unknown
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationHistoryMetadataCommonModel(
            int startTimeUnixSecs,
            int callDurationSecs,
            int? acceptedTimeUnixSecs,
            int? cost,
            global::G.ConversationDeletionSettings? deletionSettings,
            global::G.ConversationHistoryFeedbackCommonModel? feedback,
            global::G.AuthorizationMethod? authorizationMethod,
            global::G.ConversationChargingCommonModel? charging,
            global::G.PhoneCallVariant1? phoneCall,
            global::G.ConversationHistoryBatchCallModel? batchCall,
            string? terminationReason,
            global::G.ConversationHistoryErrorCommonModel? error,
            global::System.Collections.Generic.IList<string>? warnings,
            string? mainLanguage,
            global::G.ConversationHistoryRagUsageCommonModel? ragUsage,
            bool? textOnly,
            global::G.FeaturesUsageCommonModel? featuresUsage,
            global::G.ConversationHistoryElevenAssistantCommonModel? elevenAssistant,
            string? initiatorId,
            global::G.ConversationInitiationSource? conversationInitiationSource,
            string? conversationInitiationSourceVersion,
            string? timezone,
            global::G.AsyncConversationMetadata? asyncMetadata,
            global::G.WhatsAppConversationInfo? whatsapp,
            global::G.AgentDefinitionSource? agentCreatedFrom,
            global::G.AgentDefinitionSource? agentLastUpdatedFrom)
        {
            this.StartTimeUnixSecs = startTimeUnixSecs;
            this.CallDurationSecs = callDurationSecs;
            this.AcceptedTimeUnixSecs = acceptedTimeUnixSecs;
            this.Cost = cost;
            this.DeletionSettings = deletionSettings;
            this.Feedback = feedback;
            this.AuthorizationMethod = authorizationMethod;
            this.Charging = charging;
            this.PhoneCall = phoneCall;
            this.BatchCall = batchCall;
            this.TerminationReason = terminationReason;
            this.Error = error;
            this.Warnings = warnings;
            this.MainLanguage = mainLanguage;
            this.RagUsage = ragUsage;
            this.TextOnly = textOnly;
            this.FeaturesUsage = featuresUsage;
            this.ElevenAssistant = elevenAssistant;
            this.InitiatorId = initiatorId;
            this.ConversationInitiationSource = conversationInitiationSource;
            this.ConversationInitiationSourceVersion = conversationInitiationSourceVersion;
            this.Timezone = timezone;
            this.AsyncMetadata = asyncMetadata;
            this.Whatsapp = whatsapp;
            this.AgentCreatedFrom = agentCreatedFrom;
            this.AgentLastUpdatedFrom = agentLastUpdatedFrom;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryMetadataCommonModel" /> class.
        /// </summary>
        public ConversationHistoryMetadataCommonModel()
        {
        }
    }
}
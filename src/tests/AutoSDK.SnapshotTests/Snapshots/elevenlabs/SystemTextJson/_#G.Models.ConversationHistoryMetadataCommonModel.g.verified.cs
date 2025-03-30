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
        /// 
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
        public global::G.ConversationHistoryTwilioPhoneCallModel? PhoneCall { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("termination_reason")]
        public string? TerminationReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryMetadataCommonModel" /> class.
        /// </summary>
        /// <param name="startTimeUnixSecs"></param>
        /// <param name="callDurationSecs"></param>
        /// <param name="cost"></param>
        /// <param name="deletionSettings"></param>
        /// <param name="feedback"></param>
        /// <param name="authorizationMethod"></param>
        /// <param name="charging"></param>
        /// <param name="phoneCall"></param>
        /// <param name="terminationReason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationHistoryMetadataCommonModel(
            int startTimeUnixSecs,
            int callDurationSecs,
            int? cost,
            global::G.ConversationDeletionSettings? deletionSettings,
            global::G.ConversationHistoryFeedbackCommonModel? feedback,
            global::G.AuthorizationMethod? authorizationMethod,
            global::G.ConversationChargingCommonModel? charging,
            global::G.ConversationHistoryTwilioPhoneCallModel? phoneCall,
            string? terminationReason)
        {
            this.StartTimeUnixSecs = startTimeUnixSecs;
            this.CallDurationSecs = callDurationSecs;
            this.Cost = cost;
            this.DeletionSettings = deletionSettings;
            this.Feedback = feedback;
            this.AuthorizationMethod = authorizationMethod;
            this.Charging = charging;
            this.PhoneCall = phoneCall;
            this.TerminationReason = terminationReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryMetadataCommonModel" /> class.
        /// </summary>
        public ConversationHistoryMetadataCommonModel()
        {
        }
    }
}
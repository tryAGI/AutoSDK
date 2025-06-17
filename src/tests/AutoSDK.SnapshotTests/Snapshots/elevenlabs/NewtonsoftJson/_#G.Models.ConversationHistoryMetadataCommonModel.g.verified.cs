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
        [global::Newtonsoft.Json.JsonProperty("start_time_unix_secs", Required = global::Newtonsoft.Json.Required.Always)]
        public int StartTimeUnixSecs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accepted_time_unix_secs")]
        public int? AcceptedTimeUnixSecs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("call_duration_secs", Required = global::Newtonsoft.Json.Required.Always)]
        public int CallDurationSecs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cost")]
        public int? Cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deletion_settings")]
        public global::G.ConversationDeletionSettings? DeletionSettings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feedback")]
        public global::G.ConversationHistoryFeedbackCommonModel? Feedback { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authorization_method")]
        public global::G.AuthorizationMethod? AuthorizationMethod { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("charging")]
        public global::G.ConversationChargingCommonModel? Charging { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phone_call")]
        public global::G.PhoneCall? PhoneCall { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("batch_call")]
        public global::G.ConversationHistoryBatchCallModel? BatchCall { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("termination_reason")]
        public string? TerminationReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public global::G.ConversationHistoryErrorCommonModel? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("main_language")]
        public string? MainLanguage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rag_usage")]
        public global::G.ConversationHistoryRagUsageCommonModel? RagUsage { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text_only")]
        public bool? TextOnly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("features_usage")]
        public global::G.FeaturesUsageCommonModel? FeaturesUsage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
        /// <param name="authorizationMethod"></param>
        /// <param name="charging"></param>
        /// <param name="phoneCall"></param>
        /// <param name="batchCall"></param>
        /// <param name="terminationReason"></param>
        /// <param name="error"></param>
        /// <param name="mainLanguage"></param>
        /// <param name="ragUsage"></param>
        /// <param name="textOnly">
        /// Default Value: false
        /// </param>
        /// <param name="featuresUsage"></param>
        public ConversationHistoryMetadataCommonModel(
            int startTimeUnixSecs,
            int callDurationSecs,
            int? acceptedTimeUnixSecs,
            int? cost,
            global::G.ConversationDeletionSettings? deletionSettings,
            global::G.ConversationHistoryFeedbackCommonModel? feedback,
            global::G.AuthorizationMethod? authorizationMethod,
            global::G.ConversationChargingCommonModel? charging,
            global::G.PhoneCall? phoneCall,
            global::G.ConversationHistoryBatchCallModel? batchCall,
            string? terminationReason,
            global::G.ConversationHistoryErrorCommonModel? error,
            string? mainLanguage,
            global::G.ConversationHistoryRagUsageCommonModel? ragUsage,
            bool? textOnly,
            global::G.FeaturesUsageCommonModel? featuresUsage)
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
            this.MainLanguage = mainLanguage;
            this.RagUsage = ragUsage;
            this.TextOnly = textOnly;
            this.FeaturesUsage = featuresUsage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryMetadataCommonModel" /> class.
        /// </summary>
        public ConversationHistoryMetadataCommonModel()
        {
        }
    }
}
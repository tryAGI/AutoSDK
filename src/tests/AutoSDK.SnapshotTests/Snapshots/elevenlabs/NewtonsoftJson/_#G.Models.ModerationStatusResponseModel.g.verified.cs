//HintName: G.Models.ModerationStatusResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModerationStatusResponseModel
    {
        /// <summary>
        /// Whether the user is in probation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_in_probation", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsInProbation { get; set; } = default!;

        /// <summary>
        /// Whether the user's enterprise check nogo voice is enabled.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enterprise_check_nogo_voice", Required = global::Newtonsoft.Json.Required.Always)]
        public bool EnterpriseCheckNogoVoice { get; set; } = default!;

        /// <summary>
        /// Whether the user's enterprise check block nogo voice is enabled.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enterprise_check_block_nogo_voice", Required = global::Newtonsoft.Json.Required.Always)]
        public bool EnterpriseCheckBlockNogoVoice { get; set; } = default!;

        /// <summary>
        /// Whether the user's never live moderate is enabled.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("never_live_moderate", Required = global::Newtonsoft.Json.Required.Always)]
        public bool NeverLiveModerate { get; set; } = default!;

        /// <summary>
        /// The number of similar voice uploads that have been blocked.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("nogo_voice_similar_voice_upload_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int NogoVoiceSimilarVoiceUploadCount { get; set; } = default!;

        /// <summary>
        /// Whether the user's enterprise background moderation is enabled.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enterprise_background_moderation_enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool EnterpriseBackgroundModerationEnabled { get; set; } = default!;

        /// <summary>
        /// The safety status of the user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("safety_status")]
        public global::G.ModerationStatusResponseModelSafetyStatus? SafetyStatus { get; set; }

        /// <summary>
        /// The warning status of the user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("warning_status")]
        public global::G.ModerationStatusResponseModelWarningStatus? WarningStatus { get; set; }

        /// <summary>
        /// Whether the user is on the watchlist.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("on_watchlist", Required = global::Newtonsoft.Json.Required.Always)]
        public bool OnWatchlist { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationStatusResponseModel" /> class.
        /// </summary>
        /// <param name="isInProbation">
        /// Whether the user is in probation.
        /// </param>
        /// <param name="enterpriseCheckNogoVoice">
        /// Whether the user's enterprise check nogo voice is enabled.
        /// </param>
        /// <param name="enterpriseCheckBlockNogoVoice">
        /// Whether the user's enterprise check block nogo voice is enabled.
        /// </param>
        /// <param name="neverLiveModerate">
        /// Whether the user's never live moderate is enabled.
        /// </param>
        /// <param name="nogoVoiceSimilarVoiceUploadCount">
        /// The number of similar voice uploads that have been blocked.
        /// </param>
        /// <param name="enterpriseBackgroundModerationEnabled">
        /// Whether the user's enterprise background moderation is enabled.
        /// </param>
        /// <param name="safetyStatus">
        /// The safety status of the user.
        /// </param>
        /// <param name="warningStatus">
        /// The warning status of the user.
        /// </param>
        /// <param name="onWatchlist">
        /// Whether the user is on the watchlist.
        /// </param>
        public ModerationStatusResponseModel(
            bool isInProbation,
            bool enterpriseCheckNogoVoice,
            bool enterpriseCheckBlockNogoVoice,
            bool neverLiveModerate,
            int nogoVoiceSimilarVoiceUploadCount,
            bool enterpriseBackgroundModerationEnabled,
            bool onWatchlist,
            global::G.ModerationStatusResponseModelSafetyStatus? safetyStatus,
            global::G.ModerationStatusResponseModelWarningStatus? warningStatus)
        {
            this.IsInProbation = isInProbation;
            this.EnterpriseCheckNogoVoice = enterpriseCheckNogoVoice;
            this.EnterpriseCheckBlockNogoVoice = enterpriseCheckBlockNogoVoice;
            this.NeverLiveModerate = neverLiveModerate;
            this.NogoVoiceSimilarVoiceUploadCount = nogoVoiceSimilarVoiceUploadCount;
            this.EnterpriseBackgroundModerationEnabled = enterpriseBackgroundModerationEnabled;
            this.OnWatchlist = onWatchlist;
            this.SafetyStatus = safetyStatus;
            this.WarningStatus = warningStatus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationStatusResponseModel" /> class.
        /// </summary>
        public ModerationStatusResponseModel()
        {
        }
    }
}
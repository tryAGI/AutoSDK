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
        [global::System.Text.Json.Serialization.JsonPropertyName("is_in_probation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsInProbation { get; set; }

        /// <summary>
        /// Whether the user's enterprise check nogo voice is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enterprise_check_nogo_voice")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool EnterpriseCheckNogoVoice { get; set; }

        /// <summary>
        /// Whether the user's enterprise check block nogo voice is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enterprise_check_block_nogo_voice")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool EnterpriseCheckBlockNogoVoice { get; set; }

        /// <summary>
        /// Whether the user's never live moderate is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("never_live_moderate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool NeverLiveModerate { get; set; }

        /// <summary>
        /// The number of similar voice uploads that have been blocked.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nogo_voice_similar_voice_upload_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NogoVoiceSimilarVoiceUploadCount { get; set; }

        /// <summary>
        /// Whether the user's enterprise background moderation is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enterprise_background_moderation_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool EnterpriseBackgroundModerationEnabled { get; set; }

        /// <summary>
        /// The safety status of the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("safety_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ModerationStatusResponseModelSafetyStatusJsonConverter))]
        public global::G.ModerationStatusResponseModelSafetyStatus? SafetyStatus { get; set; }

        /// <summary>
        /// The warning status of the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warning_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ModerationStatusResponseModelWarningStatusJsonConverter))]
        public global::G.ModerationStatusResponseModelWarningStatus? WarningStatus { get; set; }

        /// <summary>
        /// Whether the user is on the watchlist.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on_watchlist")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool OnWatchlist { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
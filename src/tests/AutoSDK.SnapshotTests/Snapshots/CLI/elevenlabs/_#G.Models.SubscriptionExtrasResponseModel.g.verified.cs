//HintName: G.Models.SubscriptionExtrasResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubscriptionExtrasResponseModel
    {
        /// <summary>
        /// The concurrency of the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Concurrency { get; set; }

        /// <summary>
        /// The Convai concurrency of the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("convai_concurrency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ConvaiConcurrency { get; set; }

        /// <summary>
        /// The Convai characters per minute of the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("convai_chars_per_minute")]
        public int? ConvaiCharsPerMinute { get; set; }

        /// <summary>
        /// The Convai ASR characters per minute of the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("convai_asr_chars_per_minute")]
        public int? ConvaiAsrCharsPerMinute { get; set; }

        /// <summary>
        /// Whether the user's logging is disabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("force_logging_disabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ForceLoggingDisabled { get; set; }

        /// <summary>
        /// Whether the user can request manual pro voice verification.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_request_manual_pro_voice_verification")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CanRequestManualProVoiceVerification { get; set; }

        /// <summary>
        /// Whether the user can bypass the voice captcha.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_bypass_voice_captcha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CanBypassVoiceCaptcha { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moderation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ModerationStatusResponseModel Moderation { get; set; }

        /// <summary>
        /// The unused characters rolled over from the previous period.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unused_characters_rolled_over_from_previous_period")]
        public int? UnusedCharactersRolledOverFromPreviousPeriod { get; set; }

        /// <summary>
        /// The overused characters rolled over from the previous period.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overused_characters_rolled_over_from_previous_period")]
        public int? OverusedCharactersRolledOverFromPreviousPeriod { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::G.SubscriptionUsageResponseModel? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionExtrasResponseModel" /> class.
        /// </summary>
        /// <param name="concurrency">
        /// The concurrency of the user.
        /// </param>
        /// <param name="convaiConcurrency">
        /// The Convai concurrency of the user.
        /// </param>
        /// <param name="convaiCharsPerMinute">
        /// The Convai characters per minute of the user.
        /// </param>
        /// <param name="convaiAsrCharsPerMinute">
        /// The Convai ASR characters per minute of the user.
        /// </param>
        /// <param name="forceLoggingDisabled">
        /// Whether the user's logging is disabled.
        /// </param>
        /// <param name="canRequestManualProVoiceVerification">
        /// Whether the user can request manual pro voice verification.
        /// </param>
        /// <param name="canBypassVoiceCaptcha">
        /// Whether the user can bypass the voice captcha.
        /// </param>
        /// <param name="moderation"></param>
        /// <param name="unusedCharactersRolledOverFromPreviousPeriod">
        /// The unused characters rolled over from the previous period.
        /// </param>
        /// <param name="overusedCharactersRolledOverFromPreviousPeriod">
        /// The overused characters rolled over from the previous period.
        /// </param>
        /// <param name="usage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionExtrasResponseModel(
            int concurrency,
            int convaiConcurrency,
            bool forceLoggingDisabled,
            bool canRequestManualProVoiceVerification,
            bool canBypassVoiceCaptcha,
            global::G.ModerationStatusResponseModel moderation,
            int? convaiCharsPerMinute,
            int? convaiAsrCharsPerMinute,
            int? unusedCharactersRolledOverFromPreviousPeriod,
            int? overusedCharactersRolledOverFromPreviousPeriod,
            global::G.SubscriptionUsageResponseModel? usage)
        {
            this.Concurrency = concurrency;
            this.ConvaiConcurrency = convaiConcurrency;
            this.ForceLoggingDisabled = forceLoggingDisabled;
            this.CanRequestManualProVoiceVerification = canRequestManualProVoiceVerification;
            this.CanBypassVoiceCaptcha = canBypassVoiceCaptcha;
            this.Moderation = moderation ?? throw new global::System.ArgumentNullException(nameof(moderation));
            this.ConvaiCharsPerMinute = convaiCharsPerMinute;
            this.ConvaiAsrCharsPerMinute = convaiAsrCharsPerMinute;
            this.UnusedCharactersRolledOverFromPreviousPeriod = unusedCharactersRolledOverFromPreviousPeriod;
            this.OverusedCharactersRolledOverFromPreviousPeriod = overusedCharactersRolledOverFromPreviousPeriod;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionExtrasResponseModel" /> class.
        /// </summary>
        public SubscriptionExtrasResponseModel()
        {
        }
    }
}
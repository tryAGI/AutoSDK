//HintName: G.Models.SubscriptionResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubscriptionResponseModel
    {
        /// <summary>
        /// The tier of the user's subscription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Tier { get; set; }

        /// <summary>
        /// The number of characters used by the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CharacterCount { get; set; }

        /// <summary>
        /// The maximum number of characters allowed in the current billing period.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CharacterLimit { get; set; }

        /// <summary>
        /// Maximum number of characters that the character limit can be exceeded by. Managed by the workspace admin.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_character_limit_extension")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? MaxCharacterLimitExtension { get; set; }

        /// <summary>
        /// Whether the user can extend their character limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_extend_character_limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CanExtendCharacterLimit { get; set; }

        /// <summary>
        /// Whether the user is allowed to extend their character limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_to_extend_character_limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AllowedToExtendCharacterLimit { get; set; }

        /// <summary>
        /// The Unix timestamp of the next character count reset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_character_count_reset_unix")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? NextCharacterCountResetUnix { get; set; }

        /// <summary>
        /// The number of voice slots used by the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_slots_used")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int VoiceSlotsUsed { get; set; }

        /// <summary>
        /// The number of professional voice slots used by the workspace/user if single seat.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("professional_voice_slots_used")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ProfessionalVoiceSlotsUsed { get; set; }

        /// <summary>
        /// The maximum number of voice slots allowed for the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int VoiceLimit { get; set; }

        /// <summary>
        /// The maximum number of voice add/edits allowed for the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_voice_add_edits")]
        public int? MaxVoiceAddEdits { get; set; }

        /// <summary>
        /// The number of voice add/edits used by the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_add_edit_counter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int VoiceAddEditCounter { get; set; }

        /// <summary>
        /// The maximum number of professional voices allowed for the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("professional_voice_limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ProfessionalVoiceLimit { get; set; }

        /// <summary>
        /// Whether the user can extend their voice limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_extend_voice_limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CanExtendVoiceLimit { get; set; }

        /// <summary>
        /// Whether the user can use instant voice cloning.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_use_instant_voice_cloning")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CanUseInstantVoiceCloning { get; set; }

        /// <summary>
        /// Whether the user can use professional voice cloning.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_use_professional_voice_cloning")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CanUseProfessionalVoiceCloning { get; set; }

        /// <summary>
        /// The currency of the user's subscription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currency")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SubscriptionResponseModelCurrencyJsonConverter))]
        public global::G.SubscriptionResponseModelCurrency? Currency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SubscriptionStatusTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SubscriptionStatusType Status { get; set; }

        /// <summary>
        /// The billing period of the user's subscription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billing_period")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SubscriptionResponseModelBillingPeriodJsonConverter))]
        public global::G.SubscriptionResponseModelBillingPeriod? BillingPeriod { get; set; }

        /// <summary>
        /// The character refresh period of the user's subscription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_refresh_period")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SubscriptionResponseModelCharacterRefreshPeriodJsonConverter))]
        public global::G.SubscriptionResponseModelCharacterRefreshPeriod? CharacterRefreshPeriod { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionResponseModel" /> class.
        /// </summary>
        /// <param name="tier">
        /// The tier of the user's subscription.
        /// </param>
        /// <param name="characterCount">
        /// The number of characters used by the user.
        /// </param>
        /// <param name="characterLimit">
        /// The maximum number of characters allowed in the current billing period.
        /// </param>
        /// <param name="maxCharacterLimitExtension">
        /// Maximum number of characters that the character limit can be exceeded by. Managed by the workspace admin.
        /// </param>
        /// <param name="canExtendCharacterLimit">
        /// Whether the user can extend their character limit.
        /// </param>
        /// <param name="allowedToExtendCharacterLimit">
        /// Whether the user is allowed to extend their character limit.
        /// </param>
        /// <param name="nextCharacterCountResetUnix">
        /// The Unix timestamp of the next character count reset.
        /// </param>
        /// <param name="voiceSlotsUsed">
        /// The number of voice slots used by the user.
        /// </param>
        /// <param name="professionalVoiceSlotsUsed">
        /// The number of professional voice slots used by the workspace/user if single seat.
        /// </param>
        /// <param name="voiceLimit">
        /// The maximum number of voice slots allowed for the user.
        /// </param>
        /// <param name="maxVoiceAddEdits">
        /// The maximum number of voice add/edits allowed for the user.
        /// </param>
        /// <param name="voiceAddEditCounter">
        /// The number of voice add/edits used by the user.
        /// </param>
        /// <param name="professionalVoiceLimit">
        /// The maximum number of professional voices allowed for the user.
        /// </param>
        /// <param name="canExtendVoiceLimit">
        /// Whether the user can extend their voice limit.
        /// </param>
        /// <param name="canUseInstantVoiceCloning">
        /// Whether the user can use instant voice cloning.
        /// </param>
        /// <param name="canUseProfessionalVoiceCloning">
        /// Whether the user can use professional voice cloning.
        /// </param>
        /// <param name="currency">
        /// The currency of the user's subscription.
        /// </param>
        /// <param name="status"></param>
        /// <param name="billingPeriod">
        /// The billing period of the user's subscription.
        /// </param>
        /// <param name="characterRefreshPeriod">
        /// The character refresh period of the user's subscription.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionResponseModel(
            string tier,
            int characterCount,
            int characterLimit,
            int? maxCharacterLimitExtension,
            bool canExtendCharacterLimit,
            bool allowedToExtendCharacterLimit,
            int voiceSlotsUsed,
            int professionalVoiceSlotsUsed,
            int voiceLimit,
            int voiceAddEditCounter,
            int professionalVoiceLimit,
            bool canExtendVoiceLimit,
            bool canUseInstantVoiceCloning,
            bool canUseProfessionalVoiceCloning,
            global::G.SubscriptionStatusType status,
            global::System.DateTimeOffset? nextCharacterCountResetUnix,
            int? maxVoiceAddEdits,
            global::G.SubscriptionResponseModelCurrency? currency,
            global::G.SubscriptionResponseModelBillingPeriod? billingPeriod,
            global::G.SubscriptionResponseModelCharacterRefreshPeriod? characterRefreshPeriod)
        {
            this.Tier = tier ?? throw new global::System.ArgumentNullException(nameof(tier));
            this.CharacterCount = characterCount;
            this.CharacterLimit = characterLimit;
            this.MaxCharacterLimitExtension = maxCharacterLimitExtension;
            this.CanExtendCharacterLimit = canExtendCharacterLimit;
            this.AllowedToExtendCharacterLimit = allowedToExtendCharacterLimit;
            this.VoiceSlotsUsed = voiceSlotsUsed;
            this.ProfessionalVoiceSlotsUsed = professionalVoiceSlotsUsed;
            this.VoiceLimit = voiceLimit;
            this.VoiceAddEditCounter = voiceAddEditCounter;
            this.ProfessionalVoiceLimit = professionalVoiceLimit;
            this.CanExtendVoiceLimit = canExtendVoiceLimit;
            this.CanUseInstantVoiceCloning = canUseInstantVoiceCloning;
            this.CanUseProfessionalVoiceCloning = canUseProfessionalVoiceCloning;
            this.Status = status;
            this.NextCharacterCountResetUnix = nextCharacterCountResetUnix;
            this.MaxVoiceAddEdits = maxVoiceAddEdits;
            this.Currency = currency;
            this.BillingPeriod = billingPeriod;
            this.CharacterRefreshPeriod = characterRefreshPeriod;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionResponseModel" /> class.
        /// </summary>
        public SubscriptionResponseModel()
        {
        }
    }
}
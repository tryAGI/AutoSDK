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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Tier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CharacterCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CharacterLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_extend_character_limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CanExtendCharacterLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_to_extend_character_limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AllowedToExtendCharacterLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_character_count_reset_unix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NextCharacterCountResetUnix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int VoiceLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_voice_add_edits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxVoiceAddEdits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_add_edit_counter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int VoiceAddEditCounter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("professional_voice_limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ProfessionalVoiceLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_extend_voice_limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CanExtendVoiceLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_use_instant_voice_cloning")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CanUseInstantVoiceCloning { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_use_professional_voice_cloning")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CanUseProfessionalVoiceCloning { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currency")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SubscriptionResponseModelCurrencyJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SubscriptionResponseModelCurrency Currency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SubscriptionResponseModelStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SubscriptionResponseModelStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billing_period")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SubscriptionResponseModelBillingPeriodJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SubscriptionResponseModelBillingPeriod BillingPeriod { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_refresh_period")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SubscriptionResponseModelCharacterRefreshPeriodJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SubscriptionResponseModelCharacterRefreshPeriod CharacterRefreshPeriod { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionResponseModel" /> class.
        /// </summary>
        /// <param name="tier"></param>
        /// <param name="characterCount"></param>
        /// <param name="characterLimit"></param>
        /// <param name="canExtendCharacterLimit"></param>
        /// <param name="allowedToExtendCharacterLimit"></param>
        /// <param name="nextCharacterCountResetUnix"></param>
        /// <param name="voiceLimit"></param>
        /// <param name="maxVoiceAddEdits"></param>
        /// <param name="voiceAddEditCounter"></param>
        /// <param name="professionalVoiceLimit"></param>
        /// <param name="canExtendVoiceLimit"></param>
        /// <param name="canUseInstantVoiceCloning"></param>
        /// <param name="canUseProfessionalVoiceCloning"></param>
        /// <param name="currency"></param>
        /// <param name="status"></param>
        /// <param name="billingPeriod"></param>
        /// <param name="characterRefreshPeriod"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionResponseModel(
            string tier,
            int characterCount,
            int characterLimit,
            bool canExtendCharacterLimit,
            bool allowedToExtendCharacterLimit,
            int nextCharacterCountResetUnix,
            int voiceLimit,
            int maxVoiceAddEdits,
            int voiceAddEditCounter,
            int professionalVoiceLimit,
            bool canExtendVoiceLimit,
            bool canUseInstantVoiceCloning,
            bool canUseProfessionalVoiceCloning,
            global::G.SubscriptionResponseModelCurrency currency,
            global::G.SubscriptionResponseModelStatus status,
            global::G.SubscriptionResponseModelBillingPeriod billingPeriod,
            global::G.SubscriptionResponseModelCharacterRefreshPeriod characterRefreshPeriod)
        {
            this.Tier = tier ?? throw new global::System.ArgumentNullException(nameof(tier));
            this.CharacterCount = characterCount;
            this.CharacterLimit = characterLimit;
            this.CanExtendCharacterLimit = canExtendCharacterLimit;
            this.AllowedToExtendCharacterLimit = allowedToExtendCharacterLimit;
            this.NextCharacterCountResetUnix = nextCharacterCountResetUnix;
            this.VoiceLimit = voiceLimit;
            this.MaxVoiceAddEdits = maxVoiceAddEdits;
            this.VoiceAddEditCounter = voiceAddEditCounter;
            this.ProfessionalVoiceLimit = professionalVoiceLimit;
            this.CanExtendVoiceLimit = canExtendVoiceLimit;
            this.CanUseInstantVoiceCloning = canUseInstantVoiceCloning;
            this.CanUseProfessionalVoiceCloning = canUseProfessionalVoiceCloning;
            this.Currency = currency;
            this.Status = status;
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
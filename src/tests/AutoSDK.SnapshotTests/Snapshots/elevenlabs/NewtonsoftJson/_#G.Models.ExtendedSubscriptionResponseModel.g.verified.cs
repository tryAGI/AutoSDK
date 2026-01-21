//HintName: G.Models.ExtendedSubscriptionResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"has_open_invoices":false,"next_invoice":{"amount_due_cents":1000,"next_payment_attempt_unix":1738356858}}
    /// </summary>
    public sealed partial class ExtendedSubscriptionResponseModel
    {
        /// <summary>
        /// The tier of the user's subscription.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tier", Required = global::Newtonsoft.Json.Required.Always)]
        public string Tier { get; set; } = default!;

        /// <summary>
        /// The number of characters used by the user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("character_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int CharacterCount { get; set; } = default!;

        /// <summary>
        /// The maximum number of characters allowed in the current billing period.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("character_limit", Required = global::Newtonsoft.Json.Required.Always)]
        public int CharacterLimit { get; set; } = default!;

        /// <summary>
        /// Maximum number of characters that the character limit can be exceeded by. Managed by the workspace admin.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_character_limit_extension", Required = global::Newtonsoft.Json.Required.Always)]
        public int? MaxCharacterLimitExtension { get; set; } = default!;

        /// <summary>
        /// Whether the user can extend their character limit.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_extend_character_limit", Required = global::Newtonsoft.Json.Required.Always)]
        public bool CanExtendCharacterLimit { get; set; } = default!;

        /// <summary>
        /// Whether the user is allowed to extend their character limit.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allowed_to_extend_character_limit", Required = global::Newtonsoft.Json.Required.Always)]
        public bool AllowedToExtendCharacterLimit { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp of the next character count reset.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_character_count_reset_unix")]
        public int? NextCharacterCountResetUnix { get; set; }

        /// <summary>
        /// The number of voice slots used by the user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_slots_used", Required = global::Newtonsoft.Json.Required.Always)]
        public int VoiceSlotsUsed { get; set; } = default!;

        /// <summary>
        /// The number of professional voice slots used by the workspace/user if single seat.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("professional_voice_slots_used", Required = global::Newtonsoft.Json.Required.Always)]
        public int ProfessionalVoiceSlotsUsed { get; set; } = default!;

        /// <summary>
        /// The maximum number of voice slots allowed for the user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_limit", Required = global::Newtonsoft.Json.Required.Always)]
        public int VoiceLimit { get; set; } = default!;

        /// <summary>
        /// The maximum number of voice add/edits allowed for the user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_voice_add_edits")]
        public int? MaxVoiceAddEdits { get; set; }

        /// <summary>
        /// The number of voice add/edits used by the user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_add_edit_counter", Required = global::Newtonsoft.Json.Required.Always)]
        public int VoiceAddEditCounter { get; set; } = default!;

        /// <summary>
        /// The maximum number of professional voices allowed for the user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("professional_voice_limit", Required = global::Newtonsoft.Json.Required.Always)]
        public int ProfessionalVoiceLimit { get; set; } = default!;

        /// <summary>
        /// Whether the user can extend their voice limit.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_extend_voice_limit", Required = global::Newtonsoft.Json.Required.Always)]
        public bool CanExtendVoiceLimit { get; set; } = default!;

        /// <summary>
        /// Whether the user can use instant voice cloning.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_use_instant_voice_cloning", Required = global::Newtonsoft.Json.Required.Always)]
        public bool CanUseInstantVoiceCloning { get; set; } = default!;

        /// <summary>
        /// Whether the user can use professional voice cloning.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_use_professional_voice_cloning", Required = global::Newtonsoft.Json.Required.Always)]
        public bool CanUseProfessionalVoiceCloning { get; set; } = default!;

        /// <summary>
        /// The currency of the user's subscription.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("currency")]
        public global::G.ExtendedSubscriptionResponseModelCurrency2? Currency { get; set; }

        /// <summary>
        /// The status of the user's subscription.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SubscriptionStatusType Status { get; set; } = default!;

        /// <summary>
        /// The billing period of the user's subscription.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("billing_period")]
        public global::G.ExtendedSubscriptionResponseModelBillingPeriod2? BillingPeriod { get; set; }

        /// <summary>
        /// The character refresh period of the user's subscription.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("character_refresh_period")]
        public global::G.ExtendedSubscriptionResponseModelCharacterRefreshPeriod2? CharacterRefreshPeriod { get; set; }

        /// <summary>
        /// The next invoice for the user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_invoice")]
        public global::G.InvoiceResponseModel? NextInvoice { get; set; }

        /// <summary>
        /// Whether the user has open invoices.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_open_invoices", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasOpenInvoices { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendedSubscriptionResponseModel" /> class.
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
        /// <param name="status">
        /// The status of the user's subscription.
        /// </param>
        /// <param name="billingPeriod">
        /// The billing period of the user's subscription.
        /// </param>
        /// <param name="characterRefreshPeriod">
        /// The character refresh period of the user's subscription.
        /// </param>
        /// <param name="nextInvoice">
        /// The next invoice for the user.
        /// </param>
        /// <param name="hasOpenInvoices">
        /// Whether the user has open invoices.
        /// </param>
        public ExtendedSubscriptionResponseModel(
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
            bool hasOpenInvoices,
            int? nextCharacterCountResetUnix,
            int? maxVoiceAddEdits,
            global::G.ExtendedSubscriptionResponseModelCurrency2? currency,
            global::G.ExtendedSubscriptionResponseModelBillingPeriod2? billingPeriod,
            global::G.ExtendedSubscriptionResponseModelCharacterRefreshPeriod2? characterRefreshPeriod,
            global::G.InvoiceResponseModel? nextInvoice)
        {
            this.Tier = tier ?? throw new global::System.ArgumentNullException(nameof(tier));
            this.CharacterCount = characterCount;
            this.CharacterLimit = characterLimit;
            this.MaxCharacterLimitExtension = maxCharacterLimitExtension ?? throw new global::System.ArgumentNullException(nameof(maxCharacterLimitExtension));
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
            this.HasOpenInvoices = hasOpenInvoices;
            this.NextCharacterCountResetUnix = nextCharacterCountResetUnix;
            this.MaxVoiceAddEdits = maxVoiceAddEdits;
            this.Currency = currency;
            this.BillingPeriod = billingPeriod;
            this.CharacterRefreshPeriod = characterRefreshPeriod;
            this.NextInvoice = nextInvoice;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendedSubscriptionResponseModel" /> class.
        /// </summary>
        public ExtendedSubscriptionResponseModel()
        {
        }
    }
}
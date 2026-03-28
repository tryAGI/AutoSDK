//HintName: G.Models.ExtendedSubscriptionResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"allowed_to_extend_character_limit":true,"billing_period":"monthly_period","can_extend_character_limit":true,"can_extend_voice_limit":true,"can_use_instant_voice_cloning":true,"can_use_professional_voice_cloning":true,"character_count":1000,"character_limit":10000,"character_refresh_period":"monthly_period","currency":"usd","has_open_invoices":true,"max_character_limit_extension":10000,"next_character_count_reset_unix":1738356858,"next_invoice":{"amount_due_cents":1000,"discounts":[{"discount_percent_off":20.0}],"next_payment_attempt_unix":1738356858,"payment_intent_status":"processing","payment_intent_statusses":["processing","succeeded"],"subtotal_cents":900,"tax_cents":100},"open_invoices":[{"amount_due_cents":1000,"discounts":[{"discount_percent_off":20.0}],"next_payment_attempt_unix":1738356858,"payment_intent_status":"processing","payment_intent_statusses":["processing","succeeded"],"subtotal_cents":900,"tax_cents":100}],"professional_voice_limit":1,"professional_voice_slots_used":0,"status":"active","tier":"starter","voice_add_edit_counter":0,"voice_limit":10,"voice_slots_used":1}
    /// </summary>
    public sealed partial class ExtendedSubscriptionResponseModel
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
        public int? MaxCharacterLimitExtension { get; set; }

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
        public int? NextCharacterCountResetUnix { get; set; }

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
        public global::G.ExtendedSubscriptionResponseModelCurrency2? Currency { get; set; }

        /// <summary>
        /// The status of the user's subscription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SubscriptionStatusTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SubscriptionStatusType Status { get; set; }

        /// <summary>
        /// The billing period of the user's subscription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billing_period")]
        public global::G.BillingPeriod? BillingPeriod { get; set; }

        /// <summary>
        /// The character refresh period of the user's subscription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_refresh_period")]
        public global::G.CharacterRefreshPeriod? CharacterRefreshPeriod { get; set; }

        /// <summary>
        /// The next invoice for the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_invoice")]
        public global::G.InvoiceResponseModel? NextInvoice { get; set; }

        /// <summary>
        /// The open invoices for the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("open_invoices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.InvoiceResponseModel> OpenInvoices { get; set; }

        /// <summary>
        /// Whether the user has open invoices.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_open_invoices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasOpenInvoices { get; set; }

        /// <summary>
        /// The pending change for the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending_change")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.PendingSubscriptionSwitchResponseModel, global::G.PendingCancellationResponseModel, object>))]
        public global::G.AnyOf<global::G.PendingSubscriptionSwitchResponseModel, global::G.PendingCancellationResponseModel, object>? PendingChange { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        /// <param name="openInvoices">
        /// The open invoices for the user.
        /// </param>
        /// <param name="hasOpenInvoices">
        /// Whether the user has open invoices.
        /// </param>
        /// <param name="pendingChange">
        /// The pending change for the user.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtendedSubscriptionResponseModel(
            string tier,
            int characterCount,
            int characterLimit,
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
            global::System.Collections.Generic.IList<global::G.InvoiceResponseModel> openInvoices,
            bool hasOpenInvoices,
            int? maxCharacterLimitExtension,
            int? nextCharacterCountResetUnix,
            int? maxVoiceAddEdits,
            global::G.ExtendedSubscriptionResponseModelCurrency2? currency,
            global::G.BillingPeriod? billingPeriod,
            global::G.CharacterRefreshPeriod? characterRefreshPeriod,
            global::G.InvoiceResponseModel? nextInvoice,
            global::G.AnyOf<global::G.PendingSubscriptionSwitchResponseModel, global::G.PendingCancellationResponseModel, object>? pendingChange)
        {
            this.Tier = tier ?? throw new global::System.ArgumentNullException(nameof(tier));
            this.CharacterCount = characterCount;
            this.CharacterLimit = characterLimit;
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
            this.OpenInvoices = openInvoices ?? throw new global::System.ArgumentNullException(nameof(openInvoices));
            this.HasOpenInvoices = hasOpenInvoices;
            this.MaxCharacterLimitExtension = maxCharacterLimitExtension;
            this.NextCharacterCountResetUnix = nextCharacterCountResetUnix;
            this.MaxVoiceAddEdits = maxVoiceAddEdits;
            this.Currency = currency;
            this.BillingPeriod = billingPeriod;
            this.CharacterRefreshPeriod = characterRefreshPeriod;
            this.NextInvoice = nextInvoice;
            this.PendingChange = pendingChange;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendedSubscriptionResponseModel" /> class.
        /// </summary>
        public ExtendedSubscriptionResponseModel()
        {
        }
    }
}
//HintName: G.Models.UserResponseModel.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"can_use_delayed_payment_methods":false,"created_at":1753999199,"first_name":"John","is_api_key_hashed":false,"is_new_user":false,"is_onboarding_checklist_completed":true,"is_onboarding_completed":true,"seat_type":"workspace_member","show_compliance_terms":false,"subscription":{"allowed_to_extend_character_limit":false,"billing_period":"monthly_period","can_extend_character_limit":false,"can_extend_voice_limit":false,"can_use_instant_voice_cloning":true,"can_use_professional_voice_cloning":true,"character_count":17231,"character_limit":100000,"character_refresh_period":"monthly_period","currency":"usd","max_character_limit_extension":10000,"max_voice_add_edits":230,"next_character_count_reset_unix":1738356858,"professional_voice_limit":1,"professional_voice_slots_used":0,"status":"free","tier":"trial","voice_add_edit_counter":212,"voice_limit":120,"voice_slots_used":1},"user_id":"1234567890","xi_api_key":"8so27l7327189x0h939ekx293380l920"}
    /// </summary>
    public sealed partial class UserResponseModel
    {
        /// <summary>
        /// The unique identifier of the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Details of the user's subscription.<br/>
        /// Example: {"allowed_to_extend_character_limit":false,"billing_period":"monthly_period","can_extend_character_limit":false,"can_extend_voice_limit":false,"can_use_instant_voice_cloning":true,"can_use_professional_voice_cloning":true,"character_count":17231,"character_limit":100000,"character_refresh_period":"monthly_period","currency":"usd","max_character_limit_extension":10000,"max_voice_add_edits":230,"next_character_count_reset_unix":1738356858,"professional_voice_limit":1,"professional_voice_slots_used":0,"status":"free","tier":"trial","voice_add_edit_counter":212,"voice_limit":120,"voice_slots_used":1}
        /// </summary>
        /// <example>{"allowed_to_extend_character_limit":false,"billing_period":"monthly_period","can_extend_character_limit":false,"can_extend_voice_limit":false,"can_use_instant_voice_cloning":true,"can_use_professional_voice_cloning":true,"character_count":17231,"character_limit":100000,"character_refresh_period":"monthly_period","currency":"usd","max_character_limit_extension":10000,"max_voice_add_edits":230,"next_character_count_reset_unix":1738356858,"professional_voice_limit":1,"professional_voice_slots_used":0,"status":"free","tier":"trial","voice_add_edit_counter":212,"voice_limit":120,"voice_slots_used":1}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SubscriptionResponseModel Subscription { get; set; }

        /// <summary>
        /// Whether the user is new. This field is deprecated and will be removed in the future. Use 'created_at' instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_new_user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsNewUser { get; set; }

        /// <summary>
        /// The API key of the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xi_api_key")]
        public string? XiApiKey { get; set; }

        /// <summary>
        /// This field is deprecated and will be removed in a future major version. Instead use subscription.trust_on_invoice_creation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_use_delayed_payment_methods")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CanUseDelayedPaymentMethods { get; set; }

        /// <summary>
        /// Whether the user's onboarding is completed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_onboarding_completed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsOnboardingCompleted { get; set; }

        /// <summary>
        /// Whether the user's onboarding checklist is completed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_onboarding_checklist_completed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsOnboardingChecklistCompleted { get; set; }

        /// <summary>
        /// Whether to show compliance terms (ToS, Privacy Policy, biometric consent) during onboarding. Set for users signing up from the marketing site.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("show_compliance_terms")]
        public bool? ShowComplianceTerms { get; set; }

        /// <summary>
        /// First name of the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_name")]
        public string? FirstName { get; set; }

        /// <summary>
        /// Whether the user's API key is hashed.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_api_key_hashed")]
        public bool? IsApiKeyHashed { get; set; }

        /// <summary>
        /// The preview of the user's API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xi_api_key_preview")]
        public string? XiApiKeyPreview { get; set; }

        /// <summary>
        /// The referral link code of the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referral_link_code")]
        public string? ReferralLinkCode { get; set; }

        /// <summary>
        /// The Partnerstack partner default link of the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("partnerstack_partner_default_link")]
        public string? PartnerstackPartnerDefaultLink { get; set; }

        /// <summary>
        /// The unix timestamp of the user's creation. 0 if the user was created before the unix timestamp was added.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// The seat type of the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seat_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SeatTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SeatType SeatType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserResponseModel" /> class.
        /// </summary>
        /// <param name="userId">
        /// The unique identifier of the user.
        /// </param>
        /// <param name="subscription">
        /// Details of the user's subscription.<br/>
        /// Example: {"allowed_to_extend_character_limit":false,"billing_period":"monthly_period","can_extend_character_limit":false,"can_extend_voice_limit":false,"can_use_instant_voice_cloning":true,"can_use_professional_voice_cloning":true,"character_count":17231,"character_limit":100000,"character_refresh_period":"monthly_period","currency":"usd","max_character_limit_extension":10000,"max_voice_add_edits":230,"next_character_count_reset_unix":1738356858,"professional_voice_limit":1,"professional_voice_slots_used":0,"status":"free","tier":"trial","voice_add_edit_counter":212,"voice_limit":120,"voice_slots_used":1}
        /// </param>
        /// <param name="isNewUser">
        /// Whether the user is new. This field is deprecated and will be removed in the future. Use 'created_at' instead.
        /// </param>
        /// <param name="canUseDelayedPaymentMethods">
        /// This field is deprecated and will be removed in a future major version. Instead use subscription.trust_on_invoice_creation.
        /// </param>
        /// <param name="isOnboardingCompleted">
        /// Whether the user's onboarding is completed.
        /// </param>
        /// <param name="isOnboardingChecklistCompleted">
        /// Whether the user's onboarding checklist is completed.
        /// </param>
        /// <param name="createdAt">
        /// The unix timestamp of the user's creation. 0 if the user was created before the unix timestamp was added.
        /// </param>
        /// <param name="seatType">
        /// The seat type of the user.
        /// </param>
        /// <param name="xiApiKey">
        /// The API key of the user.
        /// </param>
        /// <param name="showComplianceTerms">
        /// Whether to show compliance terms (ToS, Privacy Policy, biometric consent) during onboarding. Set for users signing up from the marketing site.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="firstName">
        /// First name of the user.
        /// </param>
        /// <param name="isApiKeyHashed">
        /// Whether the user's API key is hashed.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="xiApiKeyPreview">
        /// The preview of the user's API key.
        /// </param>
        /// <param name="referralLinkCode">
        /// The referral link code of the user.
        /// </param>
        /// <param name="partnerstackPartnerDefaultLink">
        /// The Partnerstack partner default link of the user.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserResponseModel(
            string userId,
            global::G.SubscriptionResponseModel subscription,
            bool isNewUser,
            bool canUseDelayedPaymentMethods,
            bool isOnboardingCompleted,
            bool isOnboardingChecklistCompleted,
            global::System.DateTimeOffset createdAt,
            global::G.SeatType seatType,
            string? xiApiKey,
            bool? showComplianceTerms,
            string? firstName,
            bool? isApiKeyHashed,
            string? xiApiKeyPreview,
            string? referralLinkCode,
            string? partnerstackPartnerDefaultLink)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.Subscription = subscription ?? throw new global::System.ArgumentNullException(nameof(subscription));
            this.IsNewUser = isNewUser;
            this.XiApiKey = xiApiKey;
            this.CanUseDelayedPaymentMethods = canUseDelayedPaymentMethods;
            this.IsOnboardingCompleted = isOnboardingCompleted;
            this.IsOnboardingChecklistCompleted = isOnboardingChecklistCompleted;
            this.ShowComplianceTerms = showComplianceTerms;
            this.FirstName = firstName;
            this.IsApiKeyHashed = isApiKeyHashed;
            this.XiApiKeyPreview = xiApiKeyPreview;
            this.ReferralLinkCode = referralLinkCode;
            this.PartnerstackPartnerDefaultLink = partnerstackPartnerDefaultLink;
            this.CreatedAt = createdAt;
            this.SeatType = seatType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserResponseModel" /> class.
        /// </summary>
        public UserResponseModel()
        {
        }
    }
}
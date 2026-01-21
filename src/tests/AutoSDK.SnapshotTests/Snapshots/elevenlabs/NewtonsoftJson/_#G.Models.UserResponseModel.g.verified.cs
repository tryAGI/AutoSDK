//HintName: G.Models.UserResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"first_name":"John","is_api_key_hashed":false,"is_new_user":false,"is_onboarding_checklist_completed":true,"is_onboarding_completed":true,"subscription":{"allowed_to_extend_character_limit":false,"billing_period":"monthly_period","can_extend_character_limit":false,"can_extend_voice_limit":false,"can_use_instant_voice_cloning":true,"can_use_professional_voice_cloning":true,"character_count":17231,"character_limit":100000,"character_refresh_period":"monthly_period","currency":"usd","max_voice_add_edits":230,"next_character_count_reset_unix":1738356858,"professional_voice_limit":1,"professional_voice_slots_used":0,"status":"free","tier":"trial","voice_add_edit_counter":212,"voice_limit":120,"voice_slots_used":1},"subscription_extras":{"can_bypass_voice_captcha":true,"can_request_manual_pro_voice_verification":true,"concurrency":10,"convai_asr_chars_per_minute":1000,"convai_chars_per_minute":1000,"convai_concurrency":10,"force_logging_disabled":false,"moderation":{"enterprise_background_moderation_enabled":false,"enterprise_check_block_nogo_voice":false,"enterprise_check_nogo_voice":false,"is_in_probation":false,"never_live_moderate":false,"nogo_voice_similar_voice_upload_count":0,"on_watchlist":false},"overused_characters_rolled_over_from_previous_period":1000,"unused_characters_rolled_over_from_previous_period":1000,"usage":{"actual_reported_credits":1000,"manually_gifted_credits_quota":1000,"manually_gifted_credits_used":1000,"paid_usage_based_credits_used":1000,"rollover_credits_quota":1000,"rollover_credits_used":1000,"subscription_cycle_credits_quota":1000,"subscription_cycle_credits_used":1000}},"user_id":"1234567890","xi_api_key":"8so27l7327189x0h939ekx293380l920"}
    /// </summary>
    public sealed partial class UserResponseModel
    {
        /// <summary>
        /// The unique identifier of the user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// Details of the user's subscription.<br/>
        /// Example: {"allowed_to_extend_character_limit":false,"billing_period":"monthly_period","can_extend_character_limit":false,"can_extend_voice_limit":false,"can_use_instant_voice_cloning":true,"can_use_professional_voice_cloning":true,"character_count":17231,"character_limit":100000,"character_refresh_period":"monthly_period","currency":"usd","max_voice_add_edits":230,"next_character_count_reset_unix":1738356858,"professional_voice_limit":1,"professional_voice_slots_used":0,"status":"free","tier":"trial","voice_add_edit_counter":212,"voice_limit":120,"voice_slots_used":1}
        /// </summary>
        /// <example>{"allowed_to_extend_character_limit":false,"billing_period":"monthly_period","can_extend_character_limit":false,"can_extend_voice_limit":false,"can_use_instant_voice_cloning":true,"can_use_professional_voice_cloning":true,"character_count":17231,"character_limit":100000,"character_refresh_period":"monthly_period","currency":"usd","max_voice_add_edits":230,"next_character_count_reset_unix":1738356858,"professional_voice_limit":1,"professional_voice_slots_used":0,"status":"free","tier":"trial","voice_add_edit_counter":212,"voice_limit":120,"voice_slots_used":1}</example>
        [global::Newtonsoft.Json.JsonProperty("subscription", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SubscriptionResponseModel Subscription { get; set; } = default!;

        /// <summary>
        /// Optional additional details about the user's subscription.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("subscription_extras")]
        public global::G.SubscriptionExtrasResponseModel? SubscriptionExtras { get; set; }

        /// <summary>
        /// Whether the user is new.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_new_user", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsNewUser { get; set; } = default!;

        /// <summary>
        /// The API key of the user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("xi_api_key")]
        public string? XiApiKey { get; set; }

        /// <summary>
        /// This field is deprecated and will be removed in a future major version. Instead use subscription.trust_on_invoice_creation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_use_delayed_payment_methods", Required = global::Newtonsoft.Json.Required.Always)]
        public bool CanUseDelayedPaymentMethods { get; set; } = default!;

        /// <summary>
        /// Whether the user's onboarding is completed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_onboarding_completed", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsOnboardingCompleted { get; set; } = default!;

        /// <summary>
        /// Whether the user's onboarding checklist is completed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_onboarding_checklist_completed", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsOnboardingChecklistCompleted { get; set; } = default!;

        /// <summary>
        /// First name of the user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("first_name")]
        public string? FirstName { get; set; }

        /// <summary>
        /// Whether the user's API key is hashed.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_api_key_hashed")]
        public bool? IsApiKeyHashed { get; set; }

        /// <summary>
        /// The preview of the user's API key.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("xi_api_key_preview")]
        public string? XiApiKeyPreview { get; set; }

        /// <summary>
        /// The referral link code of the user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("referral_link_code")]
        public string? ReferralLinkCode { get; set; }

        /// <summary>
        /// The Partnerstack partner default link of the user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("partnerstack_partner_default_link")]
        public string? PartnerstackPartnerDefaultLink { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserResponseModel" /> class.
        /// </summary>
        /// <param name="userId">
        /// The unique identifier of the user.
        /// </param>
        /// <param name="subscription">
        /// Details of the user's subscription.<br/>
        /// Example: {"allowed_to_extend_character_limit":false,"billing_period":"monthly_period","can_extend_character_limit":false,"can_extend_voice_limit":false,"can_use_instant_voice_cloning":true,"can_use_professional_voice_cloning":true,"character_count":17231,"character_limit":100000,"character_refresh_period":"monthly_period","currency":"usd","max_voice_add_edits":230,"next_character_count_reset_unix":1738356858,"professional_voice_limit":1,"professional_voice_slots_used":0,"status":"free","tier":"trial","voice_add_edit_counter":212,"voice_limit":120,"voice_slots_used":1}
        /// </param>
        /// <param name="subscriptionExtras">
        /// Optional additional details about the user's subscription.
        /// </param>
        /// <param name="isNewUser">
        /// Whether the user is new.
        /// </param>
        /// <param name="xiApiKey">
        /// The API key of the user.
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
        public UserResponseModel(
            string userId,
            global::G.SubscriptionResponseModel subscription,
            bool isNewUser,
            bool canUseDelayedPaymentMethods,
            bool isOnboardingCompleted,
            bool isOnboardingChecklistCompleted,
            global::G.SubscriptionExtrasResponseModel? subscriptionExtras,
            string? xiApiKey,
            string? firstName,
            bool? isApiKeyHashed,
            string? xiApiKeyPreview,
            string? referralLinkCode,
            string? partnerstackPartnerDefaultLink)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.Subscription = subscription ?? throw new global::System.ArgumentNullException(nameof(subscription));
            this.IsNewUser = isNewUser;
            this.CanUseDelayedPaymentMethods = canUseDelayedPaymentMethods;
            this.IsOnboardingCompleted = isOnboardingCompleted;
            this.IsOnboardingChecklistCompleted = isOnboardingChecklistCompleted;
            this.SubscriptionExtras = subscriptionExtras;
            this.XiApiKey = xiApiKey;
            this.FirstName = firstName;
            this.IsApiKeyHashed = isApiKeyHashed;
            this.XiApiKeyPreview = xiApiKeyPreview;
            this.ReferralLinkCode = referralLinkCode;
            this.PartnerstackPartnerDefaultLink = partnerstackPartnerDefaultLink;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserResponseModel" /> class.
        /// </summary>
        public UserResponseModel()
        {
        }
    }
}
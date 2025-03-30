//HintName: G.Models.UserResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SubscriptionResponseModel Subscription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription_extras")]
        public global::G.SubscriptionExtrasResponseModel? SubscriptionExtras { get; set; }

        /// <summary>
        /// Whether the user is new.
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
        /// Whether the user can use delayed payment methods.
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
        /// <param name="subscription"></param>
        /// <param name="subscriptionExtras"></param>
        /// <param name="isNewUser">
        /// Whether the user is new.
        /// </param>
        /// <param name="xiApiKey">
        /// The API key of the user.
        /// </param>
        /// <param name="canUseDelayedPaymentMethods">
        /// Whether the user can use delayed payment methods.
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
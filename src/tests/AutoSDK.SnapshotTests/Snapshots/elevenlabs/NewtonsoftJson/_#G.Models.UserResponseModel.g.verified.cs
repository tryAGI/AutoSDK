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
        [global::Newtonsoft.Json.JsonProperty("user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("subscription", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SubscriptionResponseModel Subscription { get; set; } = default!;

        /// <summary>
        /// 
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
        /// Whether the user can use delayed payment methods.
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
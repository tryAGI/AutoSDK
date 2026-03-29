//HintName: G.Models.PatchedLseUserSerializerUpdateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A ModelSerializer that takes additional arguments for<br/>
    /// "fields", "omit" and "expand" in order to<br/>
    /// control which fields are displayed, and whether to replace simple<br/>
    /// values with complex, nested serializations
    /// </summary>
    public sealed partial class PatchedLseUserSerializerUpdateRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("active_organization")]
        public int? ActiveOrganization { get; set; }

        /// <summary>
        /// Allow sending newsletters to user
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allow_newsletters")]
        public bool? AllowNewsletters { get; set; }

        /// <summary>
        /// Custom keyboard shortcuts configuration for the user interface
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_hotkeys")]
        public object? CustomHotkeys { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("date_joined")]
        public global::System.DateTime? DateJoined { get; set; }

        /// <summary>
        /// Included only in requests
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email_notification_settings")]
        public object? EmailNotificationSettings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("first_name")]
        public string? FirstName { get; set; }

        /// <summary>
        /// Included only in requests
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_email_verified")]
        public bool? IsEmailVerified { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_name")]
        public string? LastName { get; set; }

        /// <summary>
        /// Included only in requests
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("onboarding_state")]
        public string? OnboardingState { get; set; }

        /// <summary>
        /// Included only in requests
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("password")]
        public string? Password { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phone")]
        public string? Phone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("username")]
        public string? Username { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedLseUserSerializerUpdateRequest" /> class.
        /// </summary>
        /// <param name="activeOrganization"></param>
        /// <param name="allowNewsletters">
        /// Allow sending newsletters to user
        /// </param>
        /// <param name="customHotkeys">
        /// Custom keyboard shortcuts configuration for the user interface
        /// </param>
        /// <param name="dateJoined"></param>
        /// <param name="emailNotificationSettings">
        /// Included only in requests
        /// </param>
        /// <param name="firstName"></param>
        /// <param name="isEmailVerified">
        /// Included only in requests
        /// </param>
        /// <param name="lastName"></param>
        /// <param name="onboardingState">
        /// Included only in requests
        /// </param>
        /// <param name="password">
        /// Included only in requests
        /// </param>
        /// <param name="phone"></param>
        /// <param name="username"></param>
        public PatchedLseUserSerializerUpdateRequest(
            int? activeOrganization,
            bool? allowNewsletters,
            object? customHotkeys,
            global::System.DateTime? dateJoined,
            object? emailNotificationSettings,
            string? firstName,
            bool? isEmailVerified,
            string? lastName,
            string? onboardingState,
            string? password,
            string? phone,
            string? username)
        {
            this.ActiveOrganization = activeOrganization;
            this.AllowNewsletters = allowNewsletters;
            this.CustomHotkeys = customHotkeys;
            this.DateJoined = dateJoined;
            this.EmailNotificationSettings = emailNotificationSettings;
            this.FirstName = firstName;
            this.IsEmailVerified = isEmailVerified;
            this.LastName = lastName;
            this.OnboardingState = onboardingState;
            this.Password = password;
            this.Phone = phone;
            this.Username = username;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedLseUserSerializerUpdateRequest" /> class.
        /// </summary>
        public PatchedLseUserSerializerUpdateRequest()
        {
        }
    }
}
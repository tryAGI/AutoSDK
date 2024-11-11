//HintName: G.Models.AuthenticatedUser.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// AuthenticatedUser contains the information of an authenticated user, i.e.,<br/>
    /// the public user information plus some fields that should only be accessed by<br/>
    /// the user themselves.
    /// </summary>
    public sealed partial class AuthenticatedUser
    {
        /// <summary>
        /// The name of the user, defined by its ID.<br/>
        /// - Format: `users/{user.id}`.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// User UUID. This field is optionally set by users on creation (it will be<br/>
        /// server-generated if unspecified).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// Resource ID (used in `name` as the last segment). This conforms to<br/>
        /// RFC-1034, which restricts to letters, numbers, and hyphen, with the first<br/>
        /// character a letter, the last a letter or a number, and a 63 character<br/>
        /// maximum.<br/>
        /// Note that the ID can be updated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Creation time.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createTime")]
        public global::System.DateTime? CreateTime { get; set; }

        /// <summary>
        /// Update time.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updateTime")]
        public global::System.DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Email.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email", Required = global::Newtonsoft.Json.Required.Always)]
        public string Email { get; set; } = default!;

        /// <summary>
        /// Stripe customer ID. This field is used in Instill Cloud.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("customerId")]
        public string? CustomerId { get; set; }

        /// <summary>
        /// Role.<br/>
        /// It must be one of the following allowed roles:<br/>
        /// - `manager`<br/>
        /// - `ai-researcher`<br/>
        /// - `ai-engineer`<br/>
        /// - `data-engineer`<br/>
        /// - `data-scientist`<br/>
        /// - `analytics-engineer`<br/>
        /// - `hobbyist`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        public string? Role { get; set; }

        /// <summary>
        /// This defines whether the user is subscribed to Instill AI's newsletter.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("newsletterSubscription", Required = global::Newtonsoft.Json.Required.Always)]
        public bool NewsletterSubscription { get; set; } = default!;

        /// <summary>
        /// Console cookie token.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cookieToken")]
        public string? CookieToken { get; set; }

        /// <summary>
        /// Onboarding Status.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("onboardingStatus")]
        public global::G.OnboardingStatus? OnboardingStatus { get; set; }

        /// <summary>
        /// Profile.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("profile")]
        public global::G.UserProfile? Profile { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticatedUser" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the user, defined by its ID.<br/>
        /// - Format: `users/{user.id}`.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="uid">
        /// User UUID. This field is optionally set by users on creation (it will be<br/>
        /// server-generated if unspecified).
        /// </param>
        /// <param name="id">
        /// Resource ID (used in `name` as the last segment). This conforms to<br/>
        /// RFC-1034, which restricts to letters, numbers, and hyphen, with the first<br/>
        /// character a letter, the last a letter or a number, and a 63 character<br/>
        /// maximum.<br/>
        /// Note that the ID can be updated.
        /// </param>
        /// <param name="createTime">
        /// Creation time.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updateTime">
        /// Update time.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="email">
        /// Email.
        /// </param>
        /// <param name="customerId">
        /// Stripe customer ID. This field is used in Instill Cloud.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="role">
        /// Role.<br/>
        /// It must be one of the following allowed roles:<br/>
        /// - `manager`<br/>
        /// - `ai-researcher`<br/>
        /// - `ai-engineer`<br/>
        /// - `data-engineer`<br/>
        /// - `data-scientist`<br/>
        /// - `analytics-engineer`<br/>
        /// - `hobbyist`
        /// </param>
        /// <param name="newsletterSubscription">
        /// This defines whether the user is subscribed to Instill AI's newsletter.
        /// </param>
        /// <param name="cookieToken">
        /// Console cookie token.
        /// </param>
        /// <param name="onboardingStatus">
        /// Onboarding Status.
        /// </param>
        /// <param name="profile">
        /// Profile.<br/>
        /// Included only in responses
        /// </param>
        public AuthenticatedUser(
            string id,
            string email,
            bool newsletterSubscription,
            string? name,
            string? uid,
            global::System.DateTime? createTime,
            global::System.DateTime? updateTime,
            string? customerId,
            string? role,
            string? cookieToken,
            global::G.OnboardingStatus? onboardingStatus,
            global::G.UserProfile? profile)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.NewsletterSubscription = newsletterSubscription;
            this.Name = name;
            this.Uid = uid;
            this.CreateTime = createTime;
            this.UpdateTime = updateTime;
            this.CustomerId = customerId;
            this.Role = role;
            this.CookieToken = cookieToken;
            this.OnboardingStatus = onboardingStatus;
            this.Profile = profile;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticatedUser" /> class.
        /// </summary>
        public AuthenticatedUser()
        {
        }
    }
}
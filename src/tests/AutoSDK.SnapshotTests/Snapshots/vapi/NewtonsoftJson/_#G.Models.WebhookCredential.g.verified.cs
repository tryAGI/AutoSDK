//HintName: G.Models.WebhookCredential.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookCredential
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public global::G.WebhookCredentialProvider Provider { get; set; }

        /// <summary>
        /// This is the authentication plan. Supports OAuth2 RFC 6749, HMAC signing, and Bearer authentication.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authenticationPlan", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AuthenticationPlan4 AuthenticationPlan { get; set; } = default!;

        /// <summary>
        /// This is the unique identifier for the credential.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// This is the unique identifier for the org that this credential belongs to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("orgId", Required = global::Newtonsoft.Json.Required.Always)]
        public string OrgId { get; set; } = default!;

        /// <summary>
        /// This is the ISO 8601 date-time string of when the credential was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// This is the ISO 8601 date-time string of when the assistant was last updated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updatedAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// This is the authentication session for the credential. Available for credentials that have an authentication plan.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authenticationSession", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Oauth2AuthenticationSession AuthenticationSession { get; set; } = default!;

        /// <summary>
        /// This is the name of credential. This is just for your reference.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCredential" /> class.
        /// </summary>
        /// <param name="authenticationPlan">
        /// This is the authentication plan. Supports OAuth2 RFC 6749, HMAC signing, and Bearer authentication.
        /// </param>
        /// <param name="id">
        /// This is the unique identifier for the credential.
        /// </param>
        /// <param name="orgId">
        /// This is the unique identifier for the org that this credential belongs to.
        /// </param>
        /// <param name="createdAt">
        /// This is the ISO 8601 date-time string of when the credential was created.
        /// </param>
        /// <param name="updatedAt">
        /// This is the ISO 8601 date-time string of when the assistant was last updated.
        /// </param>
        /// <param name="authenticationSession">
        /// This is the authentication session for the credential. Available for credentials that have an authentication plan.
        /// </param>
        /// <param name="provider"></param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
        public WebhookCredential(
            global::G.AuthenticationPlan4 authenticationPlan,
            string id,
            string orgId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::G.Oauth2AuthenticationSession authenticationSession,
            global::G.WebhookCredentialProvider provider,
            string? name)
        {
            this.Provider = provider;
            this.AuthenticationPlan = authenticationPlan;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.AuthenticationSession = authenticationSession ?? throw new global::System.ArgumentNullException(nameof(authenticationSession));
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCredential" /> class.
        /// </summary>
        public WebhookCredential()
        {
        }
    }
}
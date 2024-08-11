//HintName: G.Models.WebhookPersonalAccessTokenRequestCancelled.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookPersonalAccessTokenRequestCancelled
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("action", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPersonalAccessTokenRequestCancelledAction Action { get; set; } = default!;

        /// <summary>
        /// Details of a Personal Access Token Request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("personal_access_token_request", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PersonalAccessTokenRequest? PersonalAccessTokenRequest { get; set; } = default!;

        /// <summary>
        /// A GitHub organization. Webhook payloads contain the `organization` property when the webhook is configured for an<br/>
        /// organization, or when the event occurs from activity in a repository owned by an organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OrganizationSimpleWebhooks? Organization { get; set; } = default!;

        /// <summary>
        /// The GitHub user that triggered the event. This property is included in every webhook payload.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sender", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SimpleUserWebhooks? Sender { get; set; } = default!;

        /// <summary>
        /// The GitHub App installation. Webhook payloads contain the `installation` property when the event is configured<br/>
        /// for and sent to a GitHub App. For more information,<br/>
        /// see "[Using webhooks with GitHub Apps](https://docs.github.com/apps/creating-github-apps/registering-a-github-app/using-webhooks-with-github-apps)."
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("installation", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SimpleInstallation? Installation { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
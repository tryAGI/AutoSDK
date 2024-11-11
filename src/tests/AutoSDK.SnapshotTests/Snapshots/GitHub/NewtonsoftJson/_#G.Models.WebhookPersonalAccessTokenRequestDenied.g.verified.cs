//HintName: G.Models.WebhookPersonalAccessTokenRequestDenied.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookPersonalAccessTokenRequestDenied
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("action")]
        public global::G.WebhookPersonalAccessTokenRequestDeniedAction Action { get; set; }

        /// <summary>
        /// Details of a Personal Access Token Request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("personal_access_token_request", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PersonalAccessTokenRequest PersonalAccessTokenRequest { get; set; } = default!;

        /// <summary>
        /// A GitHub organization. Webhook payloads contain the `organization` property when the webhook is configured for an<br/>
        /// organization, or when the event occurs from activity in a repository owned by an organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OrganizationSimpleWebhooks Organization { get; set; } = default!;

        /// <summary>
        /// An enterprise on GitHub. Webhook payloads contain the `enterprise` property when the webhook is configured<br/>
        /// on an enterprise account or an organization that's part of an enterprise account. For more information,<br/>
        /// see "[About enterprise accounts](https://docs.github.com/admin/overview/about-enterprise-accounts)."
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enterprise")]
        public global::G.EnterpriseWebhooks? Enterprise { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sender", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SimpleUser Sender { get; set; } = default!;

        /// <summary>
        /// The GitHub App installation. Webhook payloads contain the `installation` property when the event is configured<br/>
        /// for and sent to a GitHub App. For more information,<br/>
        /// see "[Using webhooks with GitHub Apps](https://docs.github.com/apps/creating-github-apps/registering-a-github-app/using-webhooks-with-github-apps)."
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("installation", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SimpleInstallation Installation { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPersonalAccessTokenRequestDenied" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="personalAccessTokenRequest">
        /// Details of a Personal Access Token Request.
        /// </param>
        /// <param name="organization">
        /// A GitHub organization. Webhook payloads contain the `organization` property when the webhook is configured for an<br/>
        /// organization, or when the event occurs from activity in a repository owned by an organization.
        /// </param>
        /// <param name="enterprise">
        /// An enterprise on GitHub. Webhook payloads contain the `enterprise` property when the webhook is configured<br/>
        /// on an enterprise account or an organization that's part of an enterprise account. For more information,<br/>
        /// see "[About enterprise accounts](https://docs.github.com/admin/overview/about-enterprise-accounts)."
        /// </param>
        /// <param name="sender">
        /// A GitHub user.
        /// </param>
        /// <param name="installation">
        /// The GitHub App installation. Webhook payloads contain the `installation` property when the event is configured<br/>
        /// for and sent to a GitHub App. For more information,<br/>
        /// see "[Using webhooks with GitHub Apps](https://docs.github.com/apps/creating-github-apps/registering-a-github-app/using-webhooks-with-github-apps)."
        /// </param>
        public WebhookPersonalAccessTokenRequestDenied(
            global::G.PersonalAccessTokenRequest personalAccessTokenRequest,
            global::G.OrganizationSimpleWebhooks organization,
            global::G.SimpleUser sender,
            global::G.SimpleInstallation installation,
            global::G.WebhookPersonalAccessTokenRequestDeniedAction action,
            global::G.EnterpriseWebhooks? enterprise)
        {
            this.PersonalAccessTokenRequest = personalAccessTokenRequest ?? throw new global::System.ArgumentNullException(nameof(personalAccessTokenRequest));
            this.Organization = organization ?? throw new global::System.ArgumentNullException(nameof(organization));
            this.Sender = sender ?? throw new global::System.ArgumentNullException(nameof(sender));
            this.Installation = installation ?? throw new global::System.ArgumentNullException(nameof(installation));
            this.Action = action;
            this.Enterprise = enterprise;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPersonalAccessTokenRequestDenied" /> class.
        /// </summary>
        public WebhookPersonalAccessTokenRequestDenied()
        {
        }
    }
}
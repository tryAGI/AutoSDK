//HintName: G.Models.WebhookDependabotAlertAutoReopened.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookDependabotAlertAutoReopened
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("action")]
        public global::G.WebhookDependabotAlertAutoReopenedAction Action { get; set; }

        /// <summary>
        /// A Dependabot alert.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("alert", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DependabotAlert Alert { get; set; } = default!;

        /// <summary>
        /// The GitHub App installation. Webhook payloads contain the `installation` property when the event is configured<br/>
        /// for and sent to a GitHub App. For more information,<br/>
        /// see "[Using webhooks with GitHub Apps](https://docs.github.com/apps/creating-github-apps/registering-a-github-app/using-webhooks-with-github-apps)."
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("installation")]
        public global::G.SimpleInstallation? Installation { get; set; }

        /// <summary>
        /// A GitHub organization. Webhook payloads contain the `organization` property when the webhook is configured for an<br/>
        /// organization, or when the event occurs from activity in a repository owned by an organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization")]
        public global::G.OrganizationSimpleWebhooks? Organization { get; set; }

        /// <summary>
        /// An enterprise on GitHub. Webhook payloads contain the `enterprise` property when the webhook is configured<br/>
        /// on an enterprise account or an organization that's part of an enterprise account. For more information,<br/>
        /// see "[About enterprise accounts](https://docs.github.com/admin/overview/about-enterprise-accounts)."
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enterprise")]
        public global::G.EnterpriseWebhooks? Enterprise { get; set; }

        /// <summary>
        /// The repository on GitHub where the event occurred. Webhook payloads contain the `repository` property<br/>
        /// when the event occurs from activity in a repository.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RepositoryWebhooks Repository { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sender", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SimpleUser Sender { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDependabotAlertAutoReopened" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="alert">
        /// A Dependabot alert.
        /// </param>
        /// <param name="installation">
        /// The GitHub App installation. Webhook payloads contain the `installation` property when the event is configured<br/>
        /// for and sent to a GitHub App. For more information,<br/>
        /// see "[Using webhooks with GitHub Apps](https://docs.github.com/apps/creating-github-apps/registering-a-github-app/using-webhooks-with-github-apps)."
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
        /// <param name="repository">
        /// The repository on GitHub where the event occurred. Webhook payloads contain the `repository` property<br/>
        /// when the event occurs from activity in a repository.
        /// </param>
        /// <param name="sender">
        /// A GitHub user.
        /// </param>
        public WebhookDependabotAlertAutoReopened(
            global::G.DependabotAlert alert,
            global::G.RepositoryWebhooks repository,
            global::G.SimpleUser sender,
            global::G.WebhookDependabotAlertAutoReopenedAction action,
            global::G.SimpleInstallation? installation,
            global::G.OrganizationSimpleWebhooks? organization,
            global::G.EnterpriseWebhooks? enterprise)
        {
            this.Alert = alert ?? throw new global::System.ArgumentNullException(nameof(alert));
            this.Repository = repository ?? throw new global::System.ArgumentNullException(nameof(repository));
            this.Sender = sender ?? throw new global::System.ArgumentNullException(nameof(sender));
            this.Action = action;
            this.Installation = installation;
            this.Organization = organization;
            this.Enterprise = enterprise;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDependabotAlertAutoReopened" /> class.
        /// </summary>
        public WebhookDependabotAlertAutoReopened()
        {
        }
    }
}
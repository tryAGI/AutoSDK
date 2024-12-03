//HintName: G.Models.WebhookInstallationCreated.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookInstallationCreated
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("action")]
        public global::G.WebhookInstallationCreatedAction Action { get; set; }

        /// <summary>
        /// An enterprise on GitHub. Webhook payloads contain the `enterprise` property when the webhook is configured<br/>
        /// on an enterprise account or an organization that's part of an enterprise account. For more information,<br/>
        /// see "[About enterprise accounts](https://docs.github.com/admin/overview/about-enterprise-accounts)."
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enterprise")]
        public global::G.EnterpriseWebhooks? Enterprise { get; set; }

        /// <summary>
        /// Installation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("installation", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Installation Installation { get; set; } = default!;

        /// <summary>
        /// A GitHub organization. Webhook payloads contain the `organization` property when the webhook is configured for an<br/>
        /// organization, or when the event occurs from activity in a repository owned by an organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization")]
        public global::G.OrganizationSimpleWebhooks? Organization { get; set; }

        /// <summary>
        /// An array of repository objects that the installation can access.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repositories")]
        public global::System.Collections.Generic.IList<global::G.WebhooksRepositorie>? Repositories { get; set; }

        /// <summary>
        /// The repository on GitHub where the event occurred. Webhook payloads contain the `repository` property<br/>
        /// when the event occurs from activity in a repository.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository")]
        public global::G.RepositoryWebhooks? Repository { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requester")]
        public global::G.WebhooksUser? Requester { get; set; }

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
        /// Initializes a new instance of the <see cref="WebhookInstallationCreated" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="enterprise">
        /// An enterprise on GitHub. Webhook payloads contain the `enterprise` property when the webhook is configured<br/>
        /// on an enterprise account or an organization that's part of an enterprise account. For more information,<br/>
        /// see "[About enterprise accounts](https://docs.github.com/admin/overview/about-enterprise-accounts)."
        /// </param>
        /// <param name="installation">
        /// Installation
        /// </param>
        /// <param name="organization">
        /// A GitHub organization. Webhook payloads contain the `organization` property when the webhook is configured for an<br/>
        /// organization, or when the event occurs from activity in a repository owned by an organization.
        /// </param>
        /// <param name="repositories">
        /// An array of repository objects that the installation can access.
        /// </param>
        /// <param name="repository">
        /// The repository on GitHub where the event occurred. Webhook payloads contain the `repository` property<br/>
        /// when the event occurs from activity in a repository.
        /// </param>
        /// <param name="requester"></param>
        /// <param name="sender">
        /// A GitHub user.
        /// </param>
        public WebhookInstallationCreated(
            global::G.Installation installation,
            global::G.SimpleUser sender,
            global::G.WebhookInstallationCreatedAction action,
            global::G.EnterpriseWebhooks? enterprise,
            global::G.OrganizationSimpleWebhooks? organization,
            global::System.Collections.Generic.IList<global::G.WebhooksRepositorie>? repositories,
            global::G.RepositoryWebhooks? repository,
            global::G.WebhooksUser? requester)
        {
            this.Installation = installation ?? throw new global::System.ArgumentNullException(nameof(installation));
            this.Sender = sender ?? throw new global::System.ArgumentNullException(nameof(sender));
            this.Action = action;
            this.Enterprise = enterprise;
            this.Organization = organization;
            this.Repositories = repositories;
            this.Repository = repository;
            this.Requester = requester;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookInstallationCreated" /> class.
        /// </summary>
        public WebhookInstallationCreated()
        {
        }
    }
}
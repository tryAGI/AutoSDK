//HintName: G.Models.WebhookInstallationRepositoriesAdded.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookInstallationRepositoriesAdded
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("action")]
        public global::G.WebhookInstallationRepositoriesAddedAction Action { get; set; }

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
        /// An array of repository objects, which were added to the installation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repositories_added", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.WebhooksRepositoriesAddedItem> RepositoriesAdded { get; set; } = default!;

        /// <summary>
        /// An array of repository objects, which were removed from the installation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repositories_removed", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.WebhookInstallationRepositoriesAddedRepositoriesRemovedItem> RepositoriesRemoved { get; set; } = default!;

        /// <summary>
        /// The repository on GitHub where the event occurred. Webhook payloads contain the `repository` property<br/>
        /// when the event occurs from activity in a repository.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository")]
        public global::G.RepositoryWebhooks? Repository { get; set; }

        /// <summary>
        /// Describe whether all repositories have been selected or there's a selection involved
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository_selection", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhooksRepositorySelection RepositorySelection { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requester", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhooksUser? Requester { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="WebhookInstallationRepositoriesAdded" /> class.
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
        /// <param name="repositoriesAdded">
        /// An array of repository objects, which were added to the installation.
        /// </param>
        /// <param name="repositoriesRemoved">
        /// An array of repository objects, which were removed from the installation.
        /// </param>
        /// <param name="repository">
        /// The repository on GitHub where the event occurred. Webhook payloads contain the `repository` property<br/>
        /// when the event occurs from activity in a repository.
        /// </param>
        /// <param name="repositorySelection">
        /// Describe whether all repositories have been selected or there's a selection involved
        /// </param>
        /// <param name="requester"></param>
        /// <param name="sender">
        /// A GitHub user.
        /// </param>
        public WebhookInstallationRepositoriesAdded(
            global::G.Installation installation,
            global::System.Collections.Generic.IList<global::G.WebhooksRepositoriesAddedItem> repositoriesAdded,
            global::System.Collections.Generic.IList<global::G.WebhookInstallationRepositoriesAddedRepositoriesRemovedItem> repositoriesRemoved,
            global::G.WebhooksRepositorySelection repositorySelection,
            global::G.WebhooksUser? requester,
            global::G.SimpleUser sender,
            global::G.WebhookInstallationRepositoriesAddedAction action,
            global::G.EnterpriseWebhooks? enterprise,
            global::G.OrganizationSimpleWebhooks? organization,
            global::G.RepositoryWebhooks? repository)
        {
            this.Installation = installation ?? throw new global::System.ArgumentNullException(nameof(installation));
            this.RepositoriesAdded = repositoriesAdded ?? throw new global::System.ArgumentNullException(nameof(repositoriesAdded));
            this.RepositoriesRemoved = repositoriesRemoved ?? throw new global::System.ArgumentNullException(nameof(repositoriesRemoved));
            this.RepositorySelection = repositorySelection;
            this.Requester = requester ?? throw new global::System.ArgumentNullException(nameof(requester));
            this.Sender = sender ?? throw new global::System.ArgumentNullException(nameof(sender));
            this.Action = action;
            this.Enterprise = enterprise;
            this.Organization = organization;
            this.Repository = repository;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookInstallationRepositoriesAdded" /> class.
        /// </summary>
        public WebhookInstallationRepositoriesAdded()
        {
        }
    }
}
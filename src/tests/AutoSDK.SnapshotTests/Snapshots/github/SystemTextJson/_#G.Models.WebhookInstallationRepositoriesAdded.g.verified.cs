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
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookInstallationRepositoriesAddedActionJsonConverter))]
        public global::G.WebhookInstallationRepositoriesAddedAction Action { get; set; }

        /// <summary>
        /// An enterprise on GitHub. Webhook payloads contain the `enterprise` property when the webhook is configured<br/>
        /// on an enterprise account or an organization that's part of an enterprise account. For more information,<br/>
        /// see "[About enterprise accounts](https://docs.github.com/admin/overview/about-enterprise-accounts)."
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enterprise")]
        public global::G.EnterpriseWebhooks? Enterprise { get; set; }

        /// <summary>
        /// Installation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("installation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Installation Installation { get; set; }

        /// <summary>
        /// A GitHub organization. Webhook payloads contain the `organization` property when the webhook is configured for an<br/>
        /// organization, or when the event occurs from activity in a repository owned by an organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        public global::G.OrganizationSimpleWebhooks? Organization { get; set; }

        /// <summary>
        /// An array of repository objects, which were added to the installation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repositories_added")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.WebhooksRepositoriesAddedItem> RepositoriesAdded { get; set; }

        /// <summary>
        /// An array of repository objects, which were removed from the installation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repositories_removed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.WebhookInstallationRepositoriesAddedRepositoriesRemovedItem> RepositoriesRemoved { get; set; }

        /// <summary>
        /// The repository on GitHub where the event occurred. Webhook payloads contain the `repository` property<br/>
        /// when the event occurs from activity in a repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        public global::G.RepositoryWebhooks? Repository { get; set; }

        /// <summary>
        /// Describe whether all repositories have been selected or there's a selection involved
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_selection")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksRepositorySelectionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhooksRepositorySelection RepositorySelection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requester")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhooksUser? Requester { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sender")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SimpleUser Sender { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
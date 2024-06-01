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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookInstallationRepositoriesAddedActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required WebhookInstallationRepositoriesAddedAction Action { get; set; }

        /// <summary>
        /// An enterprise on GitHub. Webhook payloads contain the `enterprise` property when the webhook is configured
        /// on an enterprise account or an organization that's part of an enterprise account. For more information,
        /// see "[About enterprise accounts](https://docs.github.com/admin/overview/about-enterprise-accounts)."
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enterprise")]
        public EnterpriseWebhooks? Enterprise { get; set; }

        /// <summary>
        /// Installation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("installation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required Installation Installation { get; set; }

        /// <summary>
        /// A GitHub organization. Webhook payloads contain the `organization` property when the webhook is configured for an
        /// organization, or when the event occurs from activity in a repository owned by an organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        public OrganizationSimpleWebhooks? Organization { get; set; }

        /// <summary>
        /// An array of repository objects, which were added to the installation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repositories_added")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<WebhookInstallationRepositoriesAddedRepositoriesAdded> RepositoriesAdded { get; set; }

        /// <summary>
        /// An array of repository objects, which were removed from the installation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repositories_removed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<WebhookInstallationRepositoriesAddedRepositoriesRemoved> RepositoriesRemoved { get; set; }

        /// <summary>
        /// The repository on GitHub where the event occurred. Webhook payloads contain the `repository` property
        /// when the event occurs from activity in a repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        public RepositoryWebhooks? Repository { get; set; }

        /// <summary>
        /// Describe whether all repositories have been selected or there's a selection involved
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_selection")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookInstallationRepositoriesAddedRepositorySelectionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required WebhookInstallationRepositoriesAddedRepositorySelection RepositorySelection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requester")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required WebhooksUser? Requester { get; set; }

        /// <summary>
        /// The GitHub user that triggered the event. This property is included in every webhook payload.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sender")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required SimpleUserWebhooks Sender { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
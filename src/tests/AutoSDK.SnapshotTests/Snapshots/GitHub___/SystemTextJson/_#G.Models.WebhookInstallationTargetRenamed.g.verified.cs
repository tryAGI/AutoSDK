//HintName: G.Models.WebhookInstallationTargetRenamed.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookInstallationTargetRenamed
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookInstallationTargetRenamedAccount Account { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookInstallationTargetRenamedActionJsonConverter))]
        public global::G.WebhookInstallationTargetRenamedAction Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("changes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookInstallationTargetRenamedChanges Changes { get; set; }

        /// <summary>
        /// An enterprise on GitHub. Webhook payloads contain the `enterprise` property when the webhook is configured<br/>
        /// on an enterprise account or an organization that's part of an enterprise account. For more information,<br/>
        /// see "[About enterprise accounts](https://docs.github.com/admin/overview/about-enterprise-accounts)."
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enterprise")]
        public global::G.EnterpriseWebhooks? Enterprise { get; set; }

        /// <summary>
        /// The GitHub App installation. Webhook payloads contain the `installation` property when the event is configured<br/>
        /// for and sent to a GitHub App. For more information,<br/>
        /// see "[Using webhooks with GitHub Apps](https://docs.github.com/apps/creating-github-apps/registering-a-github-app/using-webhooks-with-github-apps)."
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("installation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SimpleInstallation Installation { get; set; }

        /// <summary>
        /// A GitHub organization. Webhook payloads contain the `organization` property when the webhook is configured for an<br/>
        /// organization, or when the event occurs from activity in a repository owned by an organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        public global::G.OrganizationSimpleWebhooks? Organization { get; set; }

        /// <summary>
        /// The repository on GitHub where the event occurred. Webhook payloads contain the `repository` property<br/>
        /// when the event occurs from activity in a repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        public global::G.RepositoryWebhooks? Repository { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sender")]
        public global::G.SimpleUser? Sender { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookInstallationTargetRenamed" /> class.
        /// </summary>
        /// <param name="account"></param>
        /// <param name="action"></param>
        /// <param name="changes"></param>
        /// <param name="enterprise">
        /// An enterprise on GitHub. Webhook payloads contain the `enterprise` property when the webhook is configured<br/>
        /// on an enterprise account or an organization that's part of an enterprise account. For more information,<br/>
        /// see "[About enterprise accounts](https://docs.github.com/admin/overview/about-enterprise-accounts)."
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
        /// <param name="repository">
        /// The repository on GitHub where the event occurred. Webhook payloads contain the `repository` property<br/>
        /// when the event occurs from activity in a repository.
        /// </param>
        /// <param name="sender">
        /// A GitHub user.
        /// </param>
        /// <param name="targetType"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhookInstallationTargetRenamed(
            global::G.WebhookInstallationTargetRenamedAccount account,
            global::G.WebhookInstallationTargetRenamedChanges changes,
            global::G.SimpleInstallation installation,
            string targetType,
            global::G.WebhookInstallationTargetRenamedAction action,
            global::G.EnterpriseWebhooks? enterprise,
            global::G.OrganizationSimpleWebhooks? organization,
            global::G.RepositoryWebhooks? repository,
            global::G.SimpleUser? sender)
        {
            this.Account = account ?? throw new global::System.ArgumentNullException(nameof(account));
            this.Changes = changes ?? throw new global::System.ArgumentNullException(nameof(changes));
            this.Installation = installation ?? throw new global::System.ArgumentNullException(nameof(installation));
            this.TargetType = targetType ?? throw new global::System.ArgumentNullException(nameof(targetType));
            this.Action = action;
            this.Enterprise = enterprise;
            this.Organization = organization;
            this.Repository = repository;
            this.Sender = sender;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookInstallationTargetRenamed" /> class.
        /// </summary>
        public WebhookInstallationTargetRenamed()
        {
        }
    }
}
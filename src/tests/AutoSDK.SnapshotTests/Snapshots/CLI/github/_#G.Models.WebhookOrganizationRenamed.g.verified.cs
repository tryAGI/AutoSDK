﻿//HintName: G.Models.WebhookOrganizationRenamed.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookOrganizationRenamed
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookOrganizationRenamedActionJsonConverter))]
        public global::G.WebhookOrganizationRenamedAction Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("changes")]
        public global::G.WebhookOrganizationRenamedChanges? Changes { get; set; }

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
        public global::G.SimpleInstallation? Installation { get; set; }

        /// <summary>
        /// The membership between the user and the organization. Not present when the action is `member_invited`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("membership")]
        public global::G.WebhooksMembership? Membership { get; set; }

        /// <summary>
        /// A GitHub organization. Webhook payloads contain the `organization` property when the webhook is configured for an<br/>
        /// organization, or when the event occurs from activity in a repository owned by an organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OrganizationSimpleWebhooks Organization { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SimpleUser Sender { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookOrganizationRenamed" /> class.
        /// </summary>
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
        /// <param name="membership">
        /// The membership between the user and the organization. Not present when the action is `member_invited`.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookOrganizationRenamed(
            global::G.OrganizationSimpleWebhooks organization,
            global::G.SimpleUser sender,
            global::G.WebhookOrganizationRenamedAction action,
            global::G.WebhookOrganizationRenamedChanges? changes,
            global::G.EnterpriseWebhooks? enterprise,
            global::G.SimpleInstallation? installation,
            global::G.WebhooksMembership? membership,
            global::G.RepositoryWebhooks? repository)
        {
            this.Organization = organization ?? throw new global::System.ArgumentNullException(nameof(organization));
            this.Sender = sender ?? throw new global::System.ArgumentNullException(nameof(sender));
            this.Action = action;
            this.Changes = changes;
            this.Enterprise = enterprise;
            this.Installation = installation;
            this.Membership = membership;
            this.Repository = repository;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookOrganizationRenamed" /> class.
        /// </summary>
        public WebhookOrganizationRenamed()
        {
        }
    }
}
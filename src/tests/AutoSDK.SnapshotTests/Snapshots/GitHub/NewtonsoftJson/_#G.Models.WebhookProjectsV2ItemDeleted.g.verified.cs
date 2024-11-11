//HintName: G.Models.WebhookProjectsV2ItemDeleted.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookProjectsV2ItemDeleted
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("action")]
        public global::G.WebhookProjectsV2ItemDeletedAction Action { get; set; }

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
        [global::Newtonsoft.Json.JsonProperty("organization", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OrganizationSimpleWebhooks Organization { get; set; } = default!;

        /// <summary>
        /// An item belonging to a project
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projects_v2_item", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ProjectsV2Item ProjectsV2Item { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="WebhookProjectsV2ItemDeleted" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="installation">
        /// The GitHub App installation. Webhook payloads contain the `installation` property when the event is configured<br/>
        /// for and sent to a GitHub App. For more information,<br/>
        /// see "[Using webhooks with GitHub Apps](https://docs.github.com/apps/creating-github-apps/registering-a-github-app/using-webhooks-with-github-apps)."
        /// </param>
        /// <param name="organization">
        /// A GitHub organization. Webhook payloads contain the `organization` property when the webhook is configured for an<br/>
        /// organization, or when the event occurs from activity in a repository owned by an organization.
        /// </param>
        /// <param name="projectsV2Item">
        /// An item belonging to a project
        /// </param>
        /// <param name="sender">
        /// A GitHub user.
        /// </param>
        public WebhookProjectsV2ItemDeleted(
            global::G.OrganizationSimpleWebhooks organization,
            global::G.ProjectsV2Item projectsV2Item,
            global::G.SimpleUser sender,
            global::G.WebhookProjectsV2ItemDeletedAction action,
            global::G.SimpleInstallation? installation)
        {
            this.Organization = organization ?? throw new global::System.ArgumentNullException(nameof(organization));
            this.ProjectsV2Item = projectsV2Item ?? throw new global::System.ArgumentNullException(nameof(projectsV2Item));
            this.Sender = sender ?? throw new global::System.ArgumentNullException(nameof(sender));
            this.Action = action;
            this.Installation = installation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookProjectsV2ItemDeleted" /> class.
        /// </summary>
        public WebhookProjectsV2ItemDeleted()
        {
        }
    }
}
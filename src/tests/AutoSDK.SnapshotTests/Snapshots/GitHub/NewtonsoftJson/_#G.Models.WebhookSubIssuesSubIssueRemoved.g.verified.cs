//HintName: G.Models.WebhookSubIssuesSubIssueRemoved.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookSubIssuesSubIssueRemoved
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("action")]
        public global::G.WebhookSubIssuesSubIssueRemovedAction Action { get; set; }

        /// <summary>
        /// The ID of the sub-issue.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sub_issue_id", Required = global::Newtonsoft.Json.Required.Always)]
        public double SubIssueId { get; set; } = default!;

        /// <summary>
        /// Issues are a great way to keep track of tasks, enhancements, and bugs for your projects.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sub_issue", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Issue SubIssue { get; set; } = default!;

        /// <summary>
        /// A repository on GitHub.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sub_issue_repo", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Repository SubIssueRepo { get; set; } = default!;

        /// <summary>
        /// The ID of the parent issue.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parent_issue_id", Required = global::Newtonsoft.Json.Required.Always)]
        public double ParentIssueId { get; set; } = default!;

        /// <summary>
        /// Issues are a great way to keep track of tasks, enhancements, and bugs for your projects.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parent_issue", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Issue ParentIssue { get; set; } = default!;

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
        /// The repository on GitHub where the event occurred. Webhook payloads contain the `repository` property<br/>
        /// when the event occurs from activity in a repository.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository")]
        public global::G.RepositoryWebhooks? Repository { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sender")]
        public global::G.SimpleUser? Sender { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSubIssuesSubIssueRemoved" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="subIssueId">
        /// The ID of the sub-issue.
        /// </param>
        /// <param name="subIssue">
        /// Issues are a great way to keep track of tasks, enhancements, and bugs for your projects.
        /// </param>
        /// <param name="subIssueRepo">
        /// A repository on GitHub.
        /// </param>
        /// <param name="parentIssueId">
        /// The ID of the parent issue.
        /// </param>
        /// <param name="parentIssue">
        /// Issues are a great way to keep track of tasks, enhancements, and bugs for your projects.
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
        public WebhookSubIssuesSubIssueRemoved(
            double subIssueId,
            global::G.Issue subIssue,
            global::G.Repository subIssueRepo,
            double parentIssueId,
            global::G.Issue parentIssue,
            global::G.WebhookSubIssuesSubIssueRemovedAction action,
            global::G.SimpleInstallation? installation,
            global::G.OrganizationSimpleWebhooks? organization,
            global::G.RepositoryWebhooks? repository,
            global::G.SimpleUser? sender)
        {
            this.SubIssueId = subIssueId;
            this.SubIssue = subIssue ?? throw new global::System.ArgumentNullException(nameof(subIssue));
            this.SubIssueRepo = subIssueRepo ?? throw new global::System.ArgumentNullException(nameof(subIssueRepo));
            this.ParentIssueId = parentIssueId;
            this.ParentIssue = parentIssue ?? throw new global::System.ArgumentNullException(nameof(parentIssue));
            this.Action = action;
            this.Installation = installation;
            this.Organization = organization;
            this.Repository = repository;
            this.Sender = sender;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSubIssuesSubIssueRemoved" /> class.
        /// </summary>
        public WebhookSubIssuesSubIssueRemoved()
        {
        }
    }
}
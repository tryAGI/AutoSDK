﻿//HintName: G.Models.WebhookDeploymentReviewRejected.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookDeploymentReviewRejected
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("action")]
        public global::G.WebhookDeploymentReviewRejectedAction Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("approver")]
        public global::G.WebhooksApprover? Approver { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// An enterprise on GitHub. Webhook payloads contain the `enterprise` property when the webhook is configured<br/>
        /// on an enterprise account or an organization that's part of an enterprise account. For more information,<br/>
        /// see "[About enterprise accounts](https://docs.github.com/admin/overview/about-enterprise-accounts)."
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enterprise")]
        public global::G.EnterpriseWebhooks? Enterprise { get; set; }

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
        /// The repository on GitHub where the event occurred. Webhook payloads contain the `repository` property<br/>
        /// when the event occurs from activity in a repository.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RepositoryWebhooks Repository { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reviewers")]
        public global::System.Collections.Generic.IList<global::G.WebhooksReviewer>? Reviewers { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sender", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SimpleUser Sender { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("since", Required = global::Newtonsoft.Json.Required.Always)]
        public string Since { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflow_job_run")]
        public global::G.WebhooksWorkflowJobRun? WorkflowJobRun { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflow_job_runs")]
        public global::System.Collections.Generic.IList<global::G.WebhookDeploymentReviewRejectedWorkflowJobRun>? WorkflowJobRuns { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflow_run", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookDeploymentReviewRejectedWorkflowRun? WorkflowRun { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDeploymentReviewRejected" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="approver"></param>
        /// <param name="comment"></param>
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
        /// <param name="reviewers"></param>
        /// <param name="sender">
        /// A GitHub user.
        /// </param>
        /// <param name="since"></param>
        /// <param name="workflowJobRun"></param>
        /// <param name="workflowJobRuns"></param>
        /// <param name="workflowRun"></param>
        public WebhookDeploymentReviewRejected(
            global::G.OrganizationSimpleWebhooks organization,
            global::G.RepositoryWebhooks repository,
            global::G.SimpleUser sender,
            string since,
            global::G.WebhookDeploymentReviewRejectedWorkflowRun? workflowRun,
            global::G.WebhookDeploymentReviewRejectedAction action,
            global::G.WebhooksApprover? approver,
            string? comment,
            global::G.EnterpriseWebhooks? enterprise,
            global::G.SimpleInstallation? installation,
            global::System.Collections.Generic.IList<global::G.WebhooksReviewer>? reviewers,
            global::G.WebhooksWorkflowJobRun? workflowJobRun,
            global::System.Collections.Generic.IList<global::G.WebhookDeploymentReviewRejectedWorkflowJobRun>? workflowJobRuns)
        {
            this.Organization = organization ?? throw new global::System.ArgumentNullException(nameof(organization));
            this.Repository = repository ?? throw new global::System.ArgumentNullException(nameof(repository));
            this.Sender = sender ?? throw new global::System.ArgumentNullException(nameof(sender));
            this.Since = since ?? throw new global::System.ArgumentNullException(nameof(since));
            this.WorkflowRun = workflowRun ?? throw new global::System.ArgumentNullException(nameof(workflowRun));
            this.Action = action;
            this.Approver = approver;
            this.Comment = comment;
            this.Enterprise = enterprise;
            this.Installation = installation;
            this.Reviewers = reviewers;
            this.WorkflowJobRun = workflowJobRun;
            this.WorkflowJobRuns = workflowJobRuns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDeploymentReviewRejected" /> class.
        /// </summary>
        public WebhookDeploymentReviewRejected()
        {
        }
    }
}
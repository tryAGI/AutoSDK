//HintName: G.Models.WebhookDeploymentProtectionRuleRequested.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookDeploymentProtectionRuleRequested
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("action")]
        public WebhookDeploymentProtectionRuleRequestedAction? Action { get; set; }

        /// <summary>
        /// The name of the environment that has the deployment protection rule.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("environment")]
        public string? Environment { get; set; }

        /// <summary>
        /// The event that triggered the deployment protection rule.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event")]
        public string? Event { get; set; }

        /// <summary>
        /// The URL to review the deployment protection rule.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deployment_callback_url")]
        public string? DeploymentCallbackUrl { get; set; }

        /// <summary>
        /// A request for a specific ref(branch,sha,tag) to be deployed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deployment")]
        public Deployment? Deployment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pull_requests")]
        public global::System.Collections.Generic.IList<PullRequest>? PullRequests { get; set; }

        /// <summary>
        /// The repository on GitHub where the event occurred. Webhook payloads contain the `repository` property
        /// when the event occurs from activity in a repository.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository")]
        public RepositoryWebhooks? Repository { get; set; }

        /// <summary>
        /// A GitHub organization. Webhook payloads contain the `organization` property when the webhook is configured for an
        /// organization, or when the event occurs from activity in a repository owned by an organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization")]
        public OrganizationSimpleWebhooks? Organization { get; set; }

        /// <summary>
        /// The GitHub App installation. Webhook payloads contain the `installation` property when the event is configured
        /// for and sent to a GitHub App. For more information,
        /// see "[Using webhooks with GitHub Apps](https://docs.github.com/apps/creating-github-apps/registering-a-github-app/using-webhooks-with-github-apps)."
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("installation")]
        public SimpleInstallation? Installation { get; set; }

        /// <summary>
        /// The GitHub user that triggered the event. This property is included in every webhook payload.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sender")]
        public SimpleUserWebhooks? Sender { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
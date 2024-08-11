//HintName: G.Models.WebhookCheckRunRequestedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookCheckRunRequestedAction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("action", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookCheckRunRequestedActionAction Action { get; set; } = default!;

        /// <summary>
        /// A check performed on the code of a given code change
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("check_run", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CheckRunWithSimpleCheckSuite? CheckRun { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonProperty("repository", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RepositoryWebhooks? Repository { get; set; } = default!;

        /// <summary>
        /// The action requested by the user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requested_action")]
        public global::G.WebhookCheckRunRequestedActionRequestedAction? RequestedAction { get; set; }

        /// <summary>
        /// The GitHub user that triggered the event. This property is included in every webhook payload.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sender", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SimpleUserWebhooks? Sender { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
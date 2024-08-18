//HintName: G.Models.WebhookDiscussionUnanswered.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookDiscussionUnanswered
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("action")]
        public global::G.WebhookDiscussionUnansweredAction Action { get; set; }

        /// <summary>
        /// A Discussion in a repository.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("discussion", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Discussion Discussion { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("old_answer", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhooksAnswer OldAnswer { get; set; } = default!;

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
        public global::G.RepositoryWebhooks Repository { get; set; } = default!;

        /// <summary>
        /// The GitHub user that triggered the event. This property is included in every webhook payload.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sender")]
        public global::G.SimpleUserWebhooks? Sender { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
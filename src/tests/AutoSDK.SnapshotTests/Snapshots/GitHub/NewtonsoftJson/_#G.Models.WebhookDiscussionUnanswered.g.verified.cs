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
        /// Initializes a new instance of the <see cref="WebhookDiscussionUnanswered" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="discussion">
        /// A Discussion in a repository.
        /// </param>
        /// <param name="oldAnswer"></param>
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
        public WebhookDiscussionUnanswered(
            global::G.Discussion discussion,
            global::G.WebhooksAnswer oldAnswer,
            global::G.RepositoryWebhooks repository,
            global::G.WebhookDiscussionUnansweredAction action,
            global::G.OrganizationSimpleWebhooks? organization,
            global::G.SimpleUser? sender)
        {
            this.Discussion = discussion ?? throw new global::System.ArgumentNullException(nameof(discussion));
            this.OldAnswer = oldAnswer ?? throw new global::System.ArgumentNullException(nameof(oldAnswer));
            this.Repository = repository ?? throw new global::System.ArgumentNullException(nameof(repository));
            this.Action = action;
            this.Organization = organization;
            this.Sender = sender;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDiscussionUnanswered" /> class.
        /// </summary>
        public WebhookDiscussionUnanswered()
        {
        }
    }
}
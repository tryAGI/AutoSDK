//HintName: G.Models.WebhookPing.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookPing
    {
        /// <summary>
        /// The webhook that is being pinged
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hook")]
        public global::G.WebhookPingHook? Hook { get; set; }

        /// <summary>
        /// The ID of the webhook that triggered the ping.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hook_id")]
        public int? HookId { get; set; }

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
        /// Random string of GitHub zen.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("zen")]
        public string? Zen { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPing" /> class.
        /// </summary>
        /// <param name="hook">
        /// The webhook that is being pinged
        /// </param>
        /// <param name="hookId">
        /// The ID of the webhook that triggered the ping.
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
        /// <param name="zen">
        /// Random string of GitHub zen.
        /// </param>
        public WebhookPing(
            global::G.WebhookPingHook? hook,
            int? hookId,
            global::G.OrganizationSimpleWebhooks? organization,
            global::G.RepositoryWebhooks? repository,
            global::G.SimpleUser? sender,
            string? zen)
        {
            this.Hook = hook;
            this.HookId = hookId;
            this.Organization = organization;
            this.Repository = repository;
            this.Sender = sender;
            this.Zen = zen;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPing" /> class.
        /// </summary>
        public WebhookPing()
        {
        }
    }
}
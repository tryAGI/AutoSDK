//HintName: G.Models.WebhookMergeGroupDestroyed.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookMergeGroupDestroyed
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookMergeGroupDestroyedActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookMergeGroupDestroyedAction Action { get; set; }

        /// <summary>
        /// Explains why the merge group is being destroyed. The group could have been merged, removed from the queue (dequeued), or invalidated by an earlier queue entry being dequeued (invalidated).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookMergeGroupDestroyedReasonJsonConverter))]
        public global::G.WebhookMergeGroupDestroyedReason? Reason { get; set; }

        /// <summary>
        /// The GitHub App installation. Webhook payloads contain the `installation` property when the event is configured<br/>
        /// for and sent to a GitHub App. For more information,<br/>
        /// see "[Using webhooks with GitHub Apps](https://docs.github.com/apps/creating-github-apps/registering-a-github-app/using-webhooks-with-github-apps)."
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("installation")]
        public global::G.SimpleInstallation? Installation { get; set; }

        /// <summary>
        /// A group of pull requests that the merge queue has grouped together to be merged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merge_group")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MergeGroup MergeGroup { get; set; }

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
        /// The GitHub user that triggered the event. This property is included in every webhook payload.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sender")]
        public global::G.SimpleUserWebhooks? Sender { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
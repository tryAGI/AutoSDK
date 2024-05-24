//HintName: G.Models.WebhookDiscussionTransferredChanges.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookDiscussionTransferredChanges
    {
        /// <summary>
        /// A Discussion in a repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_discussion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required Discussion NewDiscussion { get; set; }

        /// <summary>
        /// The repository on GitHub where the event occurred. Webhook payloads contain the `repository` property
        /// when the event occurs from activity in a repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_repository")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required RepositoryWebhooks NewRepository { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
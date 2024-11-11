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
        [global::Newtonsoft.Json.JsonProperty("new_discussion", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Discussion NewDiscussion { get; set; } = default!;

        /// <summary>
        /// The repository on GitHub where the event occurred. Webhook payloads contain the `repository` property<br/>
        /// when the event occurs from activity in a repository.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("new_repository", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RepositoryWebhooks NewRepository { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDiscussionTransferredChanges" /> class.
        /// </summary>
        /// <param name="newDiscussion">
        /// A Discussion in a repository.
        /// </param>
        /// <param name="newRepository">
        /// The repository on GitHub where the event occurred. Webhook payloads contain the `repository` property<br/>
        /// when the event occurs from activity in a repository.
        /// </param>
        public WebhookDiscussionTransferredChanges(
            global::G.Discussion newDiscussion,
            global::G.RepositoryWebhooks newRepository)
        {
            this.NewDiscussion = newDiscussion ?? throw new global::System.ArgumentNullException(nameof(newDiscussion));
            this.NewRepository = newRepository ?? throw new global::System.ArgumentNullException(nameof(newRepository));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDiscussionTransferredChanges" /> class.
        /// </summary>
        public WebhookDiscussionTransferredChanges()
        {
        }
    }
}
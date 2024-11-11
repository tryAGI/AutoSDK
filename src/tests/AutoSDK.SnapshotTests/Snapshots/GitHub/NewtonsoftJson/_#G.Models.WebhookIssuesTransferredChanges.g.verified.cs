//HintName: G.Models.WebhookIssuesTransferredChanges.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookIssuesTransferredChanges
    {
        /// <summary>
        /// The [issue](https://docs.github.com/rest/issues/issues#get-an-issue) itself.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("new_issue", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookIssuesTransferredChangesNewIssue NewIssue { get; set; } = default!;

        /// <summary>
        /// A git repository
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("new_repository", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookIssuesTransferredChangesNewRepository NewRepository { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookIssuesTransferredChanges" /> class.
        /// </summary>
        /// <param name="newIssue">
        /// The [issue](https://docs.github.com/rest/issues/issues#get-an-issue) itself.
        /// </param>
        /// <param name="newRepository">
        /// A git repository
        /// </param>
        public WebhookIssuesTransferredChanges(
            global::G.WebhookIssuesTransferredChangesNewIssue newIssue,
            global::G.WebhookIssuesTransferredChangesNewRepository newRepository)
        {
            this.NewIssue = newIssue ?? throw new global::System.ArgumentNullException(nameof(newIssue));
            this.NewRepository = newRepository ?? throw new global::System.ArgumentNullException(nameof(newRepository));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookIssuesTransferredChanges" /> class.
        /// </summary>
        public WebhookIssuesTransferredChanges()
        {
        }
    }
}
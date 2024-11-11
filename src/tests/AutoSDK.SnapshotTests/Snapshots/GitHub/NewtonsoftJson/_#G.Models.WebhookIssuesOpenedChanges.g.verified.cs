//HintName: G.Models.WebhookIssuesOpenedChanges.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookIssuesOpenedChanges
    {
        /// <summary>
        /// The [issue](https://docs.github.com/rest/issues/issues#get-an-issue) itself.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("old_issue", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookIssuesOpenedChangesOldIssue? OldIssue { get; set; } = default!;

        /// <summary>
        /// A git repository
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("old_repository", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookIssuesOpenedChangesOldRepository OldRepository { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookIssuesOpenedChanges" /> class.
        /// </summary>
        /// <param name="oldIssue">
        /// The [issue](https://docs.github.com/rest/issues/issues#get-an-issue) itself.
        /// </param>
        /// <param name="oldRepository">
        /// A git repository
        /// </param>
        public WebhookIssuesOpenedChanges(
            global::G.WebhookIssuesOpenedChangesOldIssue? oldIssue,
            global::G.WebhookIssuesOpenedChangesOldRepository oldRepository)
        {
            this.OldIssue = oldIssue ?? throw new global::System.ArgumentNullException(nameof(oldIssue));
            this.OldRepository = oldRepository ?? throw new global::System.ArgumentNullException(nameof(oldRepository));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookIssuesOpenedChanges" /> class.
        /// </summary>
        public WebhookIssuesOpenedChanges()
        {
        }
    }
}
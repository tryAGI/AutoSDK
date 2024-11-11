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
        [global::System.Text.Json.Serialization.JsonPropertyName("old_issue")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookIssuesOpenedChangesOldIssue? OldIssue { get; set; }

        /// <summary>
        /// A git repository
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("old_repository")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookIssuesOpenedChangesOldRepository OldRepository { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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
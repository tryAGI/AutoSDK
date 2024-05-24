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
        public required WebhookIssuesOpenedChangesOldIssue? OldIssue { get; set; }

        /// <summary>
        /// A git repository
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("old_repository")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required WebhookIssuesOpenedChangesOldRepository OldRepository { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
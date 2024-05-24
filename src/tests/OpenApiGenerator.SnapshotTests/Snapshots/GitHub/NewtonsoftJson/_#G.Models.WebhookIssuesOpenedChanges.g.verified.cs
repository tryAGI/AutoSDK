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
        public WebhookIssuesOpenedChangesOldIssue? OldIssue { get; set; } = default!;

        /// <summary>
        /// A git repository
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("old_repository", Required = global::Newtonsoft.Json.Required.Always)]
        public WebhookIssuesOpenedChangesOldRepository OldRepository { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
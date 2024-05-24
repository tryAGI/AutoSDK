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
        public WebhookIssuesTransferredChangesNewIssue NewIssue { get; set; } = default!;

        /// <summary>
        /// A git repository
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("new_repository", Required = global::Newtonsoft.Json.Required.Always)]
        public WebhookIssuesTransferredChangesNewRepository NewRepository { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
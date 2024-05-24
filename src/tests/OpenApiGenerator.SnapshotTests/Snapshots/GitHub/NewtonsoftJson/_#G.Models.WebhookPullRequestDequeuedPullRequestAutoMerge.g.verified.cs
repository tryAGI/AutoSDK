//HintName: G.Models.WebhookPullRequestDequeuedPullRequestAutoMerge.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of auto merging a pull request.
    /// </summary>
    public sealed partial class WebhookPullRequestDequeuedPullRequestAutoMerge
    {
        /// <summary>
        /// Commit message for the merge commit.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit_message", Required = global::Newtonsoft.Json.Required.Always)]
        public string? CommitMessage { get; set; } = default!;

        /// <summary>
        /// Title for the merge commit message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit_title", Required = global::Newtonsoft.Json.Required.Always)]
        public string? CommitTitle { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled_by", Required = global::Newtonsoft.Json.Required.Always)]
        public WebhookPullRequestDequeuedPullRequestAutoMergeEnabledBy? EnabledBy { get; set; } = default!;

        /// <summary>
        /// The merge method to use.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("merge_method", Required = global::Newtonsoft.Json.Required.Always)]
        public WebhookPullRequestDequeuedPullRequestAutoMergeMergeMethod MergeMethod { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
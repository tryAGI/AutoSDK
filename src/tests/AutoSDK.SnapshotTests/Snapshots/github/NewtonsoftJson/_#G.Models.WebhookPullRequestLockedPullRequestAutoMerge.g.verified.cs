//HintName: G.Models.WebhookPullRequestLockedPullRequestAutoMerge.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of auto merging a pull request.
    /// </summary>
    public sealed partial class WebhookPullRequestLockedPullRequestAutoMerge
    {
        /// <summary>
        /// Commit message for the merge commit.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit_message")]
        public string? CommitMessage { get; set; }

        /// <summary>
        /// Title for the merge commit message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit_title")]
        public string? CommitTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled_by")]
        public global::G.WebhookPullRequestLockedPullRequestAutoMergeEnabledBy? EnabledBy { get; set; }

        /// <summary>
        /// The merge method to use.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("merge_method", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPullRequestLockedPullRequestAutoMergeMergeMethod MergeMethod { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestLockedPullRequestAutoMerge" /> class.
        /// </summary>
        /// <param name="mergeMethod">
        /// The merge method to use.
        /// </param>
        /// <param name="commitMessage">
        /// Commit message for the merge commit.
        /// </param>
        /// <param name="commitTitle">
        /// Title for the merge commit message.
        /// </param>
        /// <param name="enabledBy"></param>
        public WebhookPullRequestLockedPullRequestAutoMerge(
            global::G.WebhookPullRequestLockedPullRequestAutoMergeMergeMethod mergeMethod,
            string? commitMessage,
            string? commitTitle,
            global::G.WebhookPullRequestLockedPullRequestAutoMergeEnabledBy? enabledBy)
        {
            this.CommitMessage = commitMessage;
            this.CommitTitle = commitTitle;
            this.EnabledBy = enabledBy;
            this.MergeMethod = mergeMethod;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestLockedPullRequestAutoMerge" /> class.
        /// </summary>
        public WebhookPullRequestLockedPullRequestAutoMerge()
        {
        }
    }
}
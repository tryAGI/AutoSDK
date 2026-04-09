//HintName: G.Models.WebhookPullRequestReviewThreadUnresolvedPullRequestAutoMerge.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of auto merging a pull request.
    /// </summary>
    public sealed partial class WebhookPullRequestReviewThreadUnresolvedPullRequestAutoMerge
    {
        /// <summary>
        /// Commit message for the merge commit.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit_message")]
        public string? CommitMessage { get; set; }

        /// <summary>
        /// Title for the merge commit message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit_title", Required = global::Newtonsoft.Json.Required.Always)]
        public string CommitTitle { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled_by")]
        public global::G.WebhookPullRequestReviewThreadUnresolvedPullRequestAutoMergeEnabledBy? EnabledBy { get; set; }

        /// <summary>
        /// The merge method to use.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("merge_method", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.WebhookPullRequestReviewThreadUnresolvedPullRequestAutoMergeMergeMethodJsonConverter))]
        public global::G.WebhookPullRequestReviewThreadUnresolvedPullRequestAutoMergeMergeMethod MergeMethod { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestReviewThreadUnresolvedPullRequestAutoMerge" /> class.
        /// </summary>
        /// <param name="commitTitle">
        /// Title for the merge commit message.
        /// </param>
        /// <param name="mergeMethod">
        /// The merge method to use.
        /// </param>
        /// <param name="commitMessage">
        /// Commit message for the merge commit.
        /// </param>
        /// <param name="enabledBy"></param>
        public WebhookPullRequestReviewThreadUnresolvedPullRequestAutoMerge(
            string commitTitle,
            global::G.WebhookPullRequestReviewThreadUnresolvedPullRequestAutoMergeMergeMethod mergeMethod,
            string? commitMessage,
            global::G.WebhookPullRequestReviewThreadUnresolvedPullRequestAutoMergeEnabledBy? enabledBy)
        {
            this.CommitMessage = commitMessage;
            this.CommitTitle = commitTitle ?? throw new global::System.ArgumentNullException(nameof(commitTitle));
            this.EnabledBy = enabledBy;
            this.MergeMethod = mergeMethod;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestReviewThreadUnresolvedPullRequestAutoMerge" /> class.
        /// </summary>
        public WebhookPullRequestReviewThreadUnresolvedPullRequestAutoMerge()
        {
        }
    }
}
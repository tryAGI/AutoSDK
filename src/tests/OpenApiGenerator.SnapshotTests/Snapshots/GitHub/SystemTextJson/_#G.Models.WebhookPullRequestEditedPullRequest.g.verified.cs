//HintName: G.Models.WebhookPullRequestEditedPullRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookPullRequestEditedPullRequest
    {
        /// <summary>
        /// Whether to allow auto-merge for pull requests.
        /// <br/>Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_auto_merge")]
        public bool AllowAutoMerge { get; set; } = false;

        /// <summary>
        /// Whether to allow updating the pull request's branch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_update_branch")]
        public bool AllowUpdateBranch { get; set; }

        /// <summary>
        /// Whether to delete head branches when pull requests are merged.
        /// <br/>Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delete_branch_on_merge")]
        public bool DeleteBranchOnMerge { get; set; } = false;

        /// <summary>
        /// The default value for a merge commit message.
        /// - `PR_TITLE` - default to the pull request's title.
        /// - `PR_BODY` - default to the pull request's body.
        /// - `BLANK` - default to a blank commit message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merge_commit_message")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookPullRequestEditedPullRequestMergeCommitMessageJsonConverter))]
        public WebhookPullRequestEditedPullRequestMergeCommitMessage? MergeCommitMessage { get; set; }

        /// <summary>
        /// The default value for a merge commit title.
        /// - `PR_TITLE` - default to the pull request's title.
        /// - `MERGE_MESSAGE` - default to the classic title for a merge message (e.g., "Merge pull request #123 from branch-name").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merge_commit_title")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookPullRequestEditedPullRequestMergeCommitTitleJsonConverter))]
        public WebhookPullRequestEditedPullRequestMergeCommitTitle? MergeCommitTitle { get; set; }

        /// <summary>
        /// The default value for a squash merge commit message:
        /// - `PR_BODY` - default to the pull request's body.
        /// - `COMMIT_MESSAGES` - default to the branch's commit messages.
        /// - `BLANK` - default to a blank commit message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("squash_merge_commit_message")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookPullRequestEditedPullRequestSquashMergeCommitMessageJsonConverter))]
        public WebhookPullRequestEditedPullRequestSquashMergeCommitMessage? SquashMergeCommitMessage { get; set; }

        /// <summary>
        /// The default value for a squash merge commit title:
        /// - `PR_TITLE` - default to the pull request's title.
        /// - `COMMIT_OR_PR_TITLE` - default to the commit's title (if only one commit) or the pull request's title (when more than one commit).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("squash_merge_commit_title")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookPullRequestEditedPullRequestSquashMergeCommitTitleJsonConverter))]
        public WebhookPullRequestEditedPullRequestSquashMergeCommitTitle? SquashMergeCommitTitle { get; set; }

        /// <summary>
        /// Whether a squash merge commit can use the pull request title as default. **This property has been deprecated. Please use `squash_merge_commit_title` instead.**
        /// <br/>Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_squash_pr_title_as_default")]
        public bool UseSquashPrTitleAsDefault { get; set; } = false;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
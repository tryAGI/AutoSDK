﻿//HintName: G.Models.PullRequestWebhookVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PullRequestWebhookVariant2
    {
        /// <summary>
        /// Whether to allow auto-merge for pull requests.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_auto_merge")]
        public bool? AllowAutoMerge { get; set; }

        /// <summary>
        /// Whether to allow updating the pull request's branch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_update_branch")]
        public bool? AllowUpdateBranch { get; set; }

        /// <summary>
        /// Whether to delete head branches when pull requests are merged.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delete_branch_on_merge")]
        public bool? DeleteBranchOnMerge { get; set; }

        /// <summary>
        /// The default value for a merge commit message.<br/>
        /// - `PR_TITLE` - default to the pull request's title.<br/>
        /// - `PR_BODY` - default to the pull request's body.<br/>
        /// - `BLANK` - default to a blank commit message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merge_commit_message")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PullRequestWebhookVariant2MergeCommitMessageJsonConverter))]
        public global::G.PullRequestWebhookVariant2MergeCommitMessage? MergeCommitMessage { get; set; }

        /// <summary>
        /// The default value for a merge commit title.<br/>
        /// - `PR_TITLE` - default to the pull request's title.<br/>
        /// - `MERGE_MESSAGE` - default to the classic title for a merge message (e.g., "Merge pull request #123 from branch-name").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merge_commit_title")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PullRequestWebhookVariant2MergeCommitTitleJsonConverter))]
        public global::G.PullRequestWebhookVariant2MergeCommitTitle? MergeCommitTitle { get; set; }

        /// <summary>
        /// The default value for a squash merge commit message:<br/>
        /// - `PR_BODY` - default to the pull request's body.<br/>
        /// - `COMMIT_MESSAGES` - default to the branch's commit messages.<br/>
        /// - `BLANK` - default to a blank commit message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("squash_merge_commit_message")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PullRequestWebhookVariant2SquashMergeCommitMessageJsonConverter))]
        public global::G.PullRequestWebhookVariant2SquashMergeCommitMessage? SquashMergeCommitMessage { get; set; }

        /// <summary>
        /// The default value for a squash merge commit title:<br/>
        /// - `PR_TITLE` - default to the pull request's title.<br/>
        /// - `COMMIT_OR_PR_TITLE` - default to the commit's title (if only one commit) or the pull request's title (when more than one commit).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("squash_merge_commit_title")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PullRequestWebhookVariant2SquashMergeCommitTitleJsonConverter))]
        public global::G.PullRequestWebhookVariant2SquashMergeCommitTitle? SquashMergeCommitTitle { get; set; }

        /// <summary>
        /// Whether a squash merge commit can use the pull request title as default. **This property has been deprecated. Please use `squash_merge_commit_title` instead.**<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_squash_pr_title_as_default")]
        public bool? UseSquashPrTitleAsDefault { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestWebhookVariant2" /> class.
        /// </summary>
        /// <param name="allowAutoMerge">
        /// Whether to allow auto-merge for pull requests.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="allowUpdateBranch">
        /// Whether to allow updating the pull request's branch.
        /// </param>
        /// <param name="deleteBranchOnMerge">
        /// Whether to delete head branches when pull requests are merged.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="mergeCommitMessage">
        /// The default value for a merge commit message.<br/>
        /// - `PR_TITLE` - default to the pull request's title.<br/>
        /// - `PR_BODY` - default to the pull request's body.<br/>
        /// - `BLANK` - default to a blank commit message.
        /// </param>
        /// <param name="mergeCommitTitle">
        /// The default value for a merge commit title.<br/>
        /// - `PR_TITLE` - default to the pull request's title.<br/>
        /// - `MERGE_MESSAGE` - default to the classic title for a merge message (e.g., "Merge pull request #123 from branch-name").
        /// </param>
        /// <param name="squashMergeCommitMessage">
        /// The default value for a squash merge commit message:<br/>
        /// - `PR_BODY` - default to the pull request's body.<br/>
        /// - `COMMIT_MESSAGES` - default to the branch's commit messages.<br/>
        /// - `BLANK` - default to a blank commit message.
        /// </param>
        /// <param name="squashMergeCommitTitle">
        /// The default value for a squash merge commit title:<br/>
        /// - `PR_TITLE` - default to the pull request's title.<br/>
        /// - `COMMIT_OR_PR_TITLE` - default to the commit's title (if only one commit) or the pull request's title (when more than one commit).
        /// </param>
        /// <param name="useSquashPrTitleAsDefault">
        /// Whether a squash merge commit can use the pull request title as default. **This property has been deprecated. Please use `squash_merge_commit_title` instead.**<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PullRequestWebhookVariant2(
            bool? allowAutoMerge,
            bool? allowUpdateBranch,
            bool? deleteBranchOnMerge,
            global::G.PullRequestWebhookVariant2MergeCommitMessage? mergeCommitMessage,
            global::G.PullRequestWebhookVariant2MergeCommitTitle? mergeCommitTitle,
            global::G.PullRequestWebhookVariant2SquashMergeCommitMessage? squashMergeCommitMessage,
            global::G.PullRequestWebhookVariant2SquashMergeCommitTitle? squashMergeCommitTitle,
            bool? useSquashPrTitleAsDefault)
        {
            this.AllowAutoMerge = allowAutoMerge;
            this.AllowUpdateBranch = allowUpdateBranch;
            this.DeleteBranchOnMerge = deleteBranchOnMerge;
            this.MergeCommitMessage = mergeCommitMessage;
            this.MergeCommitTitle = mergeCommitTitle;
            this.SquashMergeCommitMessage = squashMergeCommitMessage;
            this.SquashMergeCommitTitle = squashMergeCommitTitle;
            this.UseSquashPrTitleAsDefault = useSquashPrTitleAsDefault;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestWebhookVariant2" /> class.
        /// </summary>
        public PullRequestWebhookVariant2()
        {
        }
    }
}
//HintName: G.Models.WebhookPullRequestUnlockedPullRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookPullRequestUnlockedPullRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_links")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookPullRequestUnlockedPullRequestLinks Links { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_lock_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AutoSDK.JsonConverters.WebhookPullRequestUnlockedPullRequestActiveLockReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookPullRequestUnlockedPullRequestActiveLockReason? ActiveLockReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additions")]
        public int Additions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignee")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookPullRequestUnlockedPullRequestAssignee? Assignee { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignees")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.WebhookPullRequestUnlockedPullRequestAssignee2> Assignees { get; set; }

        /// <summary>
        /// How the author is associated with the repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author_association")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AutoSDK.JsonConverters.WebhookPullRequestUnlockedPullRequestAuthorAssociationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookPullRequestUnlockedPullRequestAuthorAssociation AuthorAssociation { get; set; }

        /// <summary>
        /// The status of auto merging a pull request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_merge")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookPullRequestUnlockedPullRequestAutoMerge? AutoMerge { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookPullRequestUnlockedPullRequestBase Base { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Body { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("changed_files")]
        public int ChangedFiles { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("closed_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? ClosedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comments")]
        public int Comments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comments_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CommentsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commits")]
        public int Commits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commits_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CommitsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deletions")]
        public int Deletions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diff_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DiffUrl { get; set; }

        /// <summary>
        /// Indicates whether or not the pull request is a draft.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("draft")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Draft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("head")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookPullRequestUnlockedPullRequestHead Head { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issue_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IssueUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.WebhookPullRequestUnlockedPullRequestLabel> Labels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locked")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Locked { get; set; }

        /// <summary>
        /// Indicates whether maintainers can modify the pull request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maintainer_can_modify")]
        public bool MaintainerCanModify { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merge_commit_sha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? MergeCommitSha { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mergeable")]
        public bool? Mergeable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mergeable_state")]
        public string? MergeableState { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merged")]
        public bool? Merged { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merged_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? MergedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merged_by")]
        public global::G.WebhookPullRequestUnlockedPullRequestMergedBy? MergedBy { get; set; }

        /// <summary>
        /// A collection of related issues and pull requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("milestone")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookPullRequestUnlockedPullRequestMilestone? Milestone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// Number uniquely identifying the pull request within its repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Number { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("patch_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PatchUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rebaseable")]
        public bool? Rebaseable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requested_reviewers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.OneOf<global::G.WebhookPullRequestUnlockedPullRequestRequestedReviewerVariant1, global::G.WebhookPullRequestUnlockedPullRequestRequestedReviewerVariant2>> RequestedReviewers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requested_teams")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.WebhookPullRequestUnlockedPullRequestRequestedTeam> RequestedTeams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("review_comment_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReviewCommentUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("review_comments")]
        public int ReviewComments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("review_comments_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReviewCommentsUrl { get; set; }

        /// <summary>
        /// State of this Pull Request. Either `open` or `closed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AutoSDK.JsonConverters.WebhookPullRequestUnlockedPullRequestStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookPullRequestUnlockedPullRequestState State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statuses_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StatusesUrl { get; set; }

        /// <summary>
        /// The title of the pull request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookPullRequestUnlockedPullRequestUser? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
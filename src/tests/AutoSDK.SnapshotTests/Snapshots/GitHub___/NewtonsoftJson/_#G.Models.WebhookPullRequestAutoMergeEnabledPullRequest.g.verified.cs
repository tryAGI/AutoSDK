//HintName: G.Models.WebhookPullRequestAutoMergeEnabledPullRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookPullRequestAutoMergeEnabledPullRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("_links", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPullRequestAutoMergeEnabledPullRequestLinks Links { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("active_lock_reason", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPullRequestAutoMergeEnabledPullRequestActiveLockReason? ActiveLockReason { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("additions")]
        public int? Additions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assignee", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPullRequestAutoMergeEnabledPullRequestAssignee? Assignee { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assignees", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.WebhookPullRequestAutoMergeEnabledPullRequestAssignee2> Assignees { get; set; } = default!;

        /// <summary>
        /// How the author is associated with the repository.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author_association", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPullRequestAutoMergeEnabledPullRequestAuthorAssociation AuthorAssociation { get; set; } = default!;

        /// <summary>
        /// The status of auto merging a pull request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auto_merge", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPullRequestAutoMergeEnabledPullRequestAutoMerge? AutoMerge { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("base", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPullRequestAutoMergeEnabledPullRequestBase Base { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Body { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("changed_files")]
        public int? ChangedFiles { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("closed_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? ClosedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comments")]
        public int? Comments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comments_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string CommentsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commits")]
        public int? Commits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commits_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string CommitsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deletions")]
        public int? Deletions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("diff_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string DiffUrl { get; set; } = default!;

        /// <summary>
        /// Indicates whether or not the pull request is a draft.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("draft", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Draft { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("head", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPullRequestAutoMergeEnabledPullRequestHead Head { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("issue_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string IssueUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("labels", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.WebhookPullRequestAutoMergeEnabledPullRequestLabel> Labels { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("locked", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Locked { get; set; } = default!;

        /// <summary>
        /// Indicates whether maintainers can modify the pull request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maintainer_can_modify")]
        public bool? MaintainerCanModify { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("merge_commit_sha", Required = global::Newtonsoft.Json.Required.Always)]
        public string? MergeCommitSha { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mergeable")]
        public bool? Mergeable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mergeable_state")]
        public string? MergeableState { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("merged")]
        public bool? Merged { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("merged_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? MergedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("merged_by")]
        public global::G.WebhookPullRequestAutoMergeEnabledPullRequestMergedBy? MergedBy { get; set; }

        /// <summary>
        /// A collection of related issues and pull requests.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("milestone", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPullRequestAutoMergeEnabledPullRequestMilestone? Milestone { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// Number uniquely identifying the pull request within its repository.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("number", Required = global::Newtonsoft.Json.Required.Always)]
        public int Number { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("patch_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string PatchUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rebaseable")]
        public bool? Rebaseable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requested_reviewers", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.WebhookPullRequestAutoMergeEnabledPullRequestRequestedReviewerVariant1, global::G.WebhookPullRequestAutoMergeEnabledPullRequestRequestedReviewerVariant2>> RequestedReviewers { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requested_teams", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.WebhookPullRequestAutoMergeEnabledPullRequestRequestedTeam> RequestedTeams { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("review_comment_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ReviewCommentUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("review_comments")]
        public int? ReviewComments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("review_comments_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ReviewCommentsUrl { get; set; } = default!;

        /// <summary>
        /// State of this Pull Request. Either `open` or `closed`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPullRequestAutoMergeEnabledPullRequestState State { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("statuses_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string StatusesUrl { get; set; } = default!;

        /// <summary>
        /// The title of the pull request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPullRequestAutoMergeEnabledPullRequestUser? User { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestAutoMergeEnabledPullRequest" /> class.
        /// </summary>
        /// <param name="links"></param>
        /// <param name="activeLockReason"></param>
        /// <param name="additions"></param>
        /// <param name="assignee"></param>
        /// <param name="assignees"></param>
        /// <param name="authorAssociation">
        /// How the author is associated with the repository.
        /// </param>
        /// <param name="autoMerge">
        /// The status of auto merging a pull request.
        /// </param>
        /// <param name="base"></param>
        /// <param name="body"></param>
        /// <param name="changedFiles"></param>
        /// <param name="closedAt"></param>
        /// <param name="comments"></param>
        /// <param name="commentsUrl"></param>
        /// <param name="commits"></param>
        /// <param name="commitsUrl"></param>
        /// <param name="createdAt"></param>
        /// <param name="deletions"></param>
        /// <param name="diffUrl"></param>
        /// <param name="draft">
        /// Indicates whether or not the pull request is a draft.
        /// </param>
        /// <param name="head"></param>
        /// <param name="htmlUrl"></param>
        /// <param name="id"></param>
        /// <param name="issueUrl"></param>
        /// <param name="labels"></param>
        /// <param name="locked"></param>
        /// <param name="maintainerCanModify">
        /// Indicates whether maintainers can modify the pull request.
        /// </param>
        /// <param name="mergeCommitSha"></param>
        /// <param name="mergeable"></param>
        /// <param name="mergeableState"></param>
        /// <param name="merged"></param>
        /// <param name="mergedAt"></param>
        /// <param name="mergedBy"></param>
        /// <param name="milestone">
        /// A collection of related issues and pull requests.
        /// </param>
        /// <param name="nodeId"></param>
        /// <param name="number">
        /// Number uniquely identifying the pull request within its repository.
        /// </param>
        /// <param name="patchUrl"></param>
        /// <param name="rebaseable"></param>
        /// <param name="requestedReviewers"></param>
        /// <param name="requestedTeams"></param>
        /// <param name="reviewCommentUrl"></param>
        /// <param name="reviewComments"></param>
        /// <param name="reviewCommentsUrl"></param>
        /// <param name="state">
        /// State of this Pull Request. Either `open` or `closed`.
        /// </param>
        /// <param name="statusesUrl"></param>
        /// <param name="title">
        /// The title of the pull request.
        /// </param>
        /// <param name="updatedAt"></param>
        /// <param name="url"></param>
        /// <param name="user"></param>
        public WebhookPullRequestAutoMergeEnabledPullRequest(
            global::G.WebhookPullRequestAutoMergeEnabledPullRequestLinks links,
            global::G.WebhookPullRequestAutoMergeEnabledPullRequestActiveLockReason? activeLockReason,
            global::G.WebhookPullRequestAutoMergeEnabledPullRequestAssignee? assignee,
            global::System.Collections.Generic.IList<global::G.WebhookPullRequestAutoMergeEnabledPullRequestAssignee2> assignees,
            global::G.WebhookPullRequestAutoMergeEnabledPullRequestAuthorAssociation authorAssociation,
            global::G.WebhookPullRequestAutoMergeEnabledPullRequestAutoMerge? autoMerge,
            global::G.WebhookPullRequestAutoMergeEnabledPullRequestBase @base,
            string? body,
            global::System.DateTime? closedAt,
            string commentsUrl,
            string commitsUrl,
            global::System.DateTime createdAt,
            string diffUrl,
            bool draft,
            global::G.WebhookPullRequestAutoMergeEnabledPullRequestHead head,
            string htmlUrl,
            int id,
            string issueUrl,
            global::System.Collections.Generic.IList<global::G.WebhookPullRequestAutoMergeEnabledPullRequestLabel> labels,
            bool locked,
            string? mergeCommitSha,
            global::System.DateTime? mergedAt,
            global::G.WebhookPullRequestAutoMergeEnabledPullRequestMilestone? milestone,
            string nodeId,
            int number,
            string patchUrl,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.WebhookPullRequestAutoMergeEnabledPullRequestRequestedReviewerVariant1, global::G.WebhookPullRequestAutoMergeEnabledPullRequestRequestedReviewerVariant2>> requestedReviewers,
            global::System.Collections.Generic.IList<global::G.WebhookPullRequestAutoMergeEnabledPullRequestRequestedTeam> requestedTeams,
            string reviewCommentUrl,
            string reviewCommentsUrl,
            global::G.WebhookPullRequestAutoMergeEnabledPullRequestState state,
            string statusesUrl,
            string title,
            global::System.DateTime updatedAt,
            string url,
            global::G.WebhookPullRequestAutoMergeEnabledPullRequestUser? user,
            int? additions,
            int? changedFiles,
            int? comments,
            int? commits,
            int? deletions,
            bool? maintainerCanModify,
            bool? mergeable,
            string? mergeableState,
            bool? merged,
            global::G.WebhookPullRequestAutoMergeEnabledPullRequestMergedBy? mergedBy,
            bool? rebaseable,
            int? reviewComments)
        {
            this.Links = links ?? throw new global::System.ArgumentNullException(nameof(links));
            this.ActiveLockReason = activeLockReason;
            this.Assignee = assignee ?? throw new global::System.ArgumentNullException(nameof(assignee));
            this.Assignees = assignees ?? throw new global::System.ArgumentNullException(nameof(assignees));
            this.AuthorAssociation = authorAssociation;
            this.AutoMerge = autoMerge ?? throw new global::System.ArgumentNullException(nameof(autoMerge));
            this.Base = @base ?? throw new global::System.ArgumentNullException(nameof(@base));
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
            this.ClosedAt = closedAt;
            this.CommentsUrl = commentsUrl ?? throw new global::System.ArgumentNullException(nameof(commentsUrl));
            this.CommitsUrl = commitsUrl ?? throw new global::System.ArgumentNullException(nameof(commitsUrl));
            this.CreatedAt = createdAt;
            this.DiffUrl = diffUrl ?? throw new global::System.ArgumentNullException(nameof(diffUrl));
            this.Draft = draft;
            this.Head = head ?? throw new global::System.ArgumentNullException(nameof(head));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.Id = id;
            this.IssueUrl = issueUrl ?? throw new global::System.ArgumentNullException(nameof(issueUrl));
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
            this.Locked = locked;
            this.MergeCommitSha = mergeCommitSha ?? throw new global::System.ArgumentNullException(nameof(mergeCommitSha));
            this.MergedAt = mergedAt;
            this.Milestone = milestone ?? throw new global::System.ArgumentNullException(nameof(milestone));
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Number = number;
            this.PatchUrl = patchUrl ?? throw new global::System.ArgumentNullException(nameof(patchUrl));
            this.RequestedReviewers = requestedReviewers ?? throw new global::System.ArgumentNullException(nameof(requestedReviewers));
            this.RequestedTeams = requestedTeams ?? throw new global::System.ArgumentNullException(nameof(requestedTeams));
            this.ReviewCommentUrl = reviewCommentUrl ?? throw new global::System.ArgumentNullException(nameof(reviewCommentUrl));
            this.ReviewCommentsUrl = reviewCommentsUrl ?? throw new global::System.ArgumentNullException(nameof(reviewCommentsUrl));
            this.State = state;
            this.StatusesUrl = statusesUrl ?? throw new global::System.ArgumentNullException(nameof(statusesUrl));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.UpdatedAt = updatedAt;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.Additions = additions;
            this.ChangedFiles = changedFiles;
            this.Comments = comments;
            this.Commits = commits;
            this.Deletions = deletions;
            this.MaintainerCanModify = maintainerCanModify;
            this.Mergeable = mergeable;
            this.MergeableState = mergeableState;
            this.Merged = merged;
            this.MergedBy = mergedBy;
            this.Rebaseable = rebaseable;
            this.ReviewComments = reviewComments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestAutoMergeEnabledPullRequest" /> class.
        /// </summary>
        public WebhookPullRequestAutoMergeEnabledPullRequest()
        {
        }
    }
}
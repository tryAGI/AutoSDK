//HintName: G.Models.WebhooksPullRequest5.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhooksPullRequest5
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("_links", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhooksPullRequest5Links Links { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("active_lock_reason")]
        public global::G.WebhooksPullRequest5ActiveLockReason? ActiveLockReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("additions")]
        public int? Additions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assignee")]
        public global::G.WebhooksPullRequest5Assignee? Assignee { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assignees", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.WebhooksPullRequest5Assignee2> Assignees { get; set; } = default!;

        /// <summary>
        /// How the author is associated with the repository.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author_association", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhooksPullRequest5AuthorAssociation AuthorAssociation { get; set; } = default!;

        /// <summary>
        /// The status of auto merging a pull request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auto_merge")]
        public global::G.WebhooksPullRequest5AutoMerge? AutoMerge { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("base", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhooksPullRequest5Base Base { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body")]
        public string? Body { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("changed_files")]
        public int? ChangedFiles { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("closed_at")]
        public global::System.DateTime? ClosedAt { get; set; }

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
        public global::G.WebhooksPullRequest5Head Head { get; set; } = default!;

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
        public global::System.Collections.Generic.IList<global::G.WebhooksPullRequest5Label> Labels { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonProperty("merge_commit_sha")]
        public string? MergeCommitSha { get; set; }

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
        [global::Newtonsoft.Json.JsonProperty("merged_at")]
        public global::System.DateTime? MergedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("merged_by")]
        public global::G.WebhooksPullRequest5MergedBy? MergedBy { get; set; }

        /// <summary>
        /// A collection of related issues and pull requests.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("milestone")]
        public global::G.WebhooksPullRequest5Milestone? Milestone { get; set; }

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
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.WebhooksPullRequest5RequestedReviewerUser, global::G.WebhooksPullRequest5RequestedReviewerTeam>> RequestedReviewers { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requested_teams", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.WebhooksPullRequest5RequestedTeam> RequestedTeams { get; set; } = default!;

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
        public global::G.WebhooksPullRequest5State State { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonProperty("user")]
        public global::G.WebhooksPullRequest5User? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksPullRequest5" /> class.
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
        public WebhooksPullRequest5(
            global::G.WebhooksPullRequest5Links links,
            global::System.Collections.Generic.IList<global::G.WebhooksPullRequest5Assignee2> assignees,
            global::G.WebhooksPullRequest5AuthorAssociation authorAssociation,
            global::G.WebhooksPullRequest5Base @base,
            string commentsUrl,
            string commitsUrl,
            global::System.DateTime createdAt,
            string diffUrl,
            bool draft,
            global::G.WebhooksPullRequest5Head head,
            string htmlUrl,
            int id,
            string issueUrl,
            global::System.Collections.Generic.IList<global::G.WebhooksPullRequest5Label> labels,
            bool locked,
            string nodeId,
            int number,
            string patchUrl,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.WebhooksPullRequest5RequestedReviewerUser, global::G.WebhooksPullRequest5RequestedReviewerTeam>> requestedReviewers,
            global::System.Collections.Generic.IList<global::G.WebhooksPullRequest5RequestedTeam> requestedTeams,
            string reviewCommentUrl,
            string reviewCommentsUrl,
            global::G.WebhooksPullRequest5State state,
            string statusesUrl,
            string title,
            global::System.DateTime updatedAt,
            string url,
            global::G.WebhooksPullRequest5ActiveLockReason? activeLockReason,
            int? additions,
            global::G.WebhooksPullRequest5Assignee? assignee,
            global::G.WebhooksPullRequest5AutoMerge? autoMerge,
            string? body,
            int? changedFiles,
            global::System.DateTime? closedAt,
            int? comments,
            int? commits,
            int? deletions,
            bool? maintainerCanModify,
            string? mergeCommitSha,
            bool? mergeable,
            string? mergeableState,
            bool? merged,
            global::System.DateTime? mergedAt,
            global::G.WebhooksPullRequest5MergedBy? mergedBy,
            global::G.WebhooksPullRequest5Milestone? milestone,
            bool? rebaseable,
            int? reviewComments,
            global::G.WebhooksPullRequest5User? user)
        {
            this.Links = links ?? throw new global::System.ArgumentNullException(nameof(links));
            this.Assignees = assignees ?? throw new global::System.ArgumentNullException(nameof(assignees));
            this.AuthorAssociation = authorAssociation;
            this.Base = @base ?? throw new global::System.ArgumentNullException(nameof(@base));
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
            this.ActiveLockReason = activeLockReason;
            this.Additions = additions;
            this.Assignee = assignee;
            this.AutoMerge = autoMerge;
            this.Body = body;
            this.ChangedFiles = changedFiles;
            this.ClosedAt = closedAt;
            this.Comments = comments;
            this.Commits = commits;
            this.Deletions = deletions;
            this.MaintainerCanModify = maintainerCanModify;
            this.MergeCommitSha = mergeCommitSha;
            this.Mergeable = mergeable;
            this.MergeableState = mergeableState;
            this.Merged = merged;
            this.MergedAt = mergedAt;
            this.MergedBy = mergedBy;
            this.Milestone = milestone;
            this.Rebaseable = rebaseable;
            this.ReviewComments = reviewComments;
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksPullRequest5" /> class.
        /// </summary>
        public WebhooksPullRequest5()
        {
        }
    }
}
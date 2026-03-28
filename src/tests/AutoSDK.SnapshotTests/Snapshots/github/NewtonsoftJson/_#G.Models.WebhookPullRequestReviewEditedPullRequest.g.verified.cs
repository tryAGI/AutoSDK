//HintName: G.Models.WebhookPullRequestReviewEditedPullRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookPullRequestReviewEditedPullRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("_links", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPullRequestReviewEditedPullRequestLinks Links { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("active_lock_reason")]
        public global::G.WebhookPullRequestReviewEditedPullRequestActiveLockReason? ActiveLockReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assignee")]
        public global::G.WebhookPullRequestReviewEditedPullRequestAssignee? Assignee { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assignees", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.WebhookPullRequestReviewEditedPullRequestAssignee2> Assignees { get; set; } = default!;

        /// <summary>
        /// How the author is associated with the repository.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author_association", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPullRequestReviewEditedPullRequestAuthorAssociation AuthorAssociation { get; set; } = default!;

        /// <summary>
        /// The status of auto merging a pull request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auto_merge")]
        public global::G.WebhookPullRequestReviewEditedPullRequestAutoMerge? AutoMerge { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("base", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPullRequestReviewEditedPullRequestBase Base { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body")]
        public string? Body { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("closed_at")]
        public string? ClosedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comments_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string CommentsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commits_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string CommitsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("diff_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string DiffUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("draft", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Draft { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("head", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPullRequestReviewEditedPullRequestHead Head { get; set; } = default!;

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
        public global::System.Collections.Generic.IList<global::G.WebhookPullRequestReviewEditedPullRequestLabel> Labels { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("locked", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Locked { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("merge_commit_sha")]
        public string? MergeCommitSha { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("merged_at")]
        public string? MergedAt { get; set; }

        /// <summary>
        /// A collection of related issues and pull requests.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("milestone")]
        public global::G.WebhookPullRequestReviewEditedPullRequestMilestone? Milestone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// 
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
        [global::Newtonsoft.Json.JsonProperty("requested_reviewers", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.WebhookPullRequestReviewEditedPullRequestRequestedReviewerUser, global::G.WebhookPullRequestReviewEditedPullRequestRequestedReviewerTeam>> RequestedReviewers { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requested_teams", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.WebhookPullRequestReviewEditedPullRequestRequestedTeam> RequestedTeams { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("review_comment_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ReviewCommentUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("review_comments_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ReviewCommentsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPullRequestReviewEditedPullRequestState State { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("statuses_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string StatusesUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user")]
        public global::G.WebhookPullRequestReviewEditedPullRequestUser? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestReviewEditedPullRequest" /> class.
        /// </summary>
        /// <param name="links"></param>
        /// <param name="activeLockReason"></param>
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
        /// <param name="closedAt"></param>
        /// <param name="commentsUrl"></param>
        /// <param name="commitsUrl"></param>
        /// <param name="createdAt"></param>
        /// <param name="diffUrl"></param>
        /// <param name="draft"></param>
        /// <param name="head"></param>
        /// <param name="htmlUrl"></param>
        /// <param name="id"></param>
        /// <param name="issueUrl"></param>
        /// <param name="labels"></param>
        /// <param name="locked"></param>
        /// <param name="mergeCommitSha"></param>
        /// <param name="mergedAt"></param>
        /// <param name="milestone">
        /// A collection of related issues and pull requests.
        /// </param>
        /// <param name="nodeId"></param>
        /// <param name="number"></param>
        /// <param name="patchUrl"></param>
        /// <param name="requestedReviewers"></param>
        /// <param name="requestedTeams"></param>
        /// <param name="reviewCommentUrl"></param>
        /// <param name="reviewCommentsUrl"></param>
        /// <param name="state"></param>
        /// <param name="statusesUrl"></param>
        /// <param name="title"></param>
        /// <param name="updatedAt"></param>
        /// <param name="url"></param>
        /// <param name="user"></param>
        public WebhookPullRequestReviewEditedPullRequest(
            global::G.WebhookPullRequestReviewEditedPullRequestLinks links,
            global::System.Collections.Generic.IList<global::G.WebhookPullRequestReviewEditedPullRequestAssignee2> assignees,
            global::G.WebhookPullRequestReviewEditedPullRequestAuthorAssociation authorAssociation,
            global::G.WebhookPullRequestReviewEditedPullRequestBase @base,
            string commentsUrl,
            string commitsUrl,
            string createdAt,
            string diffUrl,
            bool draft,
            global::G.WebhookPullRequestReviewEditedPullRequestHead head,
            string htmlUrl,
            int id,
            string issueUrl,
            global::System.Collections.Generic.IList<global::G.WebhookPullRequestReviewEditedPullRequestLabel> labels,
            bool locked,
            string nodeId,
            int number,
            string patchUrl,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.WebhookPullRequestReviewEditedPullRequestRequestedReviewerUser, global::G.WebhookPullRequestReviewEditedPullRequestRequestedReviewerTeam>> requestedReviewers,
            global::System.Collections.Generic.IList<global::G.WebhookPullRequestReviewEditedPullRequestRequestedTeam> requestedTeams,
            string reviewCommentUrl,
            string reviewCommentsUrl,
            global::G.WebhookPullRequestReviewEditedPullRequestState state,
            string statusesUrl,
            string title,
            string updatedAt,
            string url,
            global::G.WebhookPullRequestReviewEditedPullRequestActiveLockReason? activeLockReason,
            global::G.WebhookPullRequestReviewEditedPullRequestAssignee? assignee,
            global::G.WebhookPullRequestReviewEditedPullRequestAutoMerge? autoMerge,
            string? body,
            string? closedAt,
            string? mergeCommitSha,
            string? mergedAt,
            global::G.WebhookPullRequestReviewEditedPullRequestMilestone? milestone,
            global::G.WebhookPullRequestReviewEditedPullRequestUser? user)
        {
            this.Links = links ?? throw new global::System.ArgumentNullException(nameof(links));
            this.Assignees = assignees ?? throw new global::System.ArgumentNullException(nameof(assignees));
            this.AuthorAssociation = authorAssociation;
            this.Base = @base ?? throw new global::System.ArgumentNullException(nameof(@base));
            this.CommentsUrl = commentsUrl ?? throw new global::System.ArgumentNullException(nameof(commentsUrl));
            this.CommitsUrl = commitsUrl ?? throw new global::System.ArgumentNullException(nameof(commitsUrl));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
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
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.ActiveLockReason = activeLockReason;
            this.Assignee = assignee;
            this.AutoMerge = autoMerge;
            this.Body = body;
            this.ClosedAt = closedAt;
            this.MergeCommitSha = mergeCommitSha;
            this.MergedAt = mergedAt;
            this.Milestone = milestone;
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestReviewEditedPullRequest" /> class.
        /// </summary>
        public WebhookPullRequestReviewEditedPullRequest()
        {
        }
    }
}
//HintName: G.Models.PullRequestSimple.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Pull Request Simple
    /// </summary>
    public sealed partial class PullRequestSimple
    {
        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/pulls/1347
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/pulls/1347</example>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Example: 1L
        /// </summary>
        /// <example>1L</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public long Id { get; set; } = default!;

        /// <summary>
        /// Example: MDExOlB1bGxSZXF1ZXN0MQ==
        /// </summary>
        /// <example>MDExOlB1bGxSZXF1ZXN0MQ==</example>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// Example: https://github.com/octocat/Hello-World/pull/1347
        /// </summary>
        /// <example>https://github.com/octocat/Hello-World/pull/1347</example>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://github.com/octocat/Hello-World/pull/1347.diff
        /// </summary>
        /// <example>https://github.com/octocat/Hello-World/pull/1347.diff</example>
        [global::Newtonsoft.Json.JsonProperty("diff_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string DiffUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://github.com/octocat/Hello-World/pull/1347.patch
        /// </summary>
        /// <example>https://github.com/octocat/Hello-World/pull/1347.patch</example>
        [global::Newtonsoft.Json.JsonProperty("patch_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string PatchUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/issues/1347
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/issues/1347</example>
        [global::Newtonsoft.Json.JsonProperty("issue_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string IssueUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/pulls/1347/commits
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/pulls/1347/commits</example>
        [global::Newtonsoft.Json.JsonProperty("commits_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string CommitsUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/pulls/1347/comments
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/pulls/1347/comments</example>
        [global::Newtonsoft.Json.JsonProperty("review_comments_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ReviewCommentsUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/pulls/comments{/number}
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/pulls/comments{/number}</example>
        [global::Newtonsoft.Json.JsonProperty("review_comment_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ReviewCommentUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/issues/1347/comments
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/issues/1347/comments</example>
        [global::Newtonsoft.Json.JsonProperty("comments_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string CommentsUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/statuses/6dcb09b5b57875f334f61aebed695e2e4193db5e
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/statuses/6dcb09b5b57875f334f61aebed695e2e4193db5e</example>
        [global::Newtonsoft.Json.JsonProperty("statuses_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string StatusesUrl { get; set; } = default!;

        /// <summary>
        /// Example: 1347
        /// </summary>
        /// <example>1347</example>
        [global::Newtonsoft.Json.JsonProperty("number", Required = global::Newtonsoft.Json.Required.Always)]
        public int Number { get; set; } = default!;

        /// <summary>
        /// Example: open
        /// </summary>
        /// <example>open</example>
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        public string State { get; set; } = default!;

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("locked", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Locked { get; set; } = default!;

        /// <summary>
        /// Example: new-feature
        /// </summary>
        /// <example>new-feature</example>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableSimpleUser? User { get; set; } = default!;

        /// <summary>
        /// Example: Please pull these awesome changes
        /// </summary>
        /// <example>Please pull these awesome changes</example>
        [global::Newtonsoft.Json.JsonProperty("body", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Body { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("labels", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.PullRequestSimpleLabel> Labels { get; set; } = default!;

        /// <summary>
        /// A collection of related issues and pull requests.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("milestone", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableMilestone? Milestone { get; set; } = default!;

        /// <summary>
        /// Example: too heated
        /// </summary>
        /// <example>too heated</example>
        [global::Newtonsoft.Json.JsonProperty("active_lock_reason")]
        public string? ActiveLockReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("closed_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? ClosedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("merged_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? MergedAt { get; set; } = default!;

        /// <summary>
        /// Example: e5bd3914e2e596debea16f433f57875b5b90bcd6
        /// </summary>
        /// <example>e5bd3914e2e596debea16f433f57875b5b90bcd6</example>
        [global::Newtonsoft.Json.JsonProperty("merge_commit_sha", Required = global::Newtonsoft.Json.Required.Always)]
        public string? MergeCommitSha { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assignee", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableSimpleUser? Assignee { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assignees")]
        public global::System.Collections.Generic.IList<global::G.SimpleUser>? Assignees { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requested_reviewers")]
        public global::System.Collections.Generic.IList<global::G.SimpleUser>? RequestedReviewers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requested_teams")]
        public global::System.Collections.Generic.IList<global::G.Team>? RequestedTeams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("head", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PullRequestSimpleHead Head { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("base", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PullRequestSimpleBase Base { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("_links", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PullRequestSimpleLinks Links { get; set; } = default!;

        /// <summary>
        /// How the author is associated with the repository.<br/>
        /// Example: OWNER
        /// </summary>
        /// <example>OWNER</example>
        [global::Newtonsoft.Json.JsonProperty("author_association", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AuthorAssociation AuthorAssociation { get; set; } = default!;

        /// <summary>
        /// The status of auto merging a pull request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auto_merge", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AutoMerge? AutoMerge { get; set; } = default!;

        /// <summary>
        /// Indicates whether or not the pull request is a draft.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("draft")]
        public bool? Draft { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestSimple" /> class.
        /// </summary>
        /// <param name="url">
        /// Example: https://api.github.com/repos/octocat/Hello-World/pulls/1347
        /// </param>
        /// <param name="id">
        /// Example: 1L
        /// </param>
        /// <param name="nodeId">
        /// Example: MDExOlB1bGxSZXF1ZXN0MQ==
        /// </param>
        /// <param name="htmlUrl">
        /// Example: https://github.com/octocat/Hello-World/pull/1347
        /// </param>
        /// <param name="diffUrl">
        /// Example: https://github.com/octocat/Hello-World/pull/1347.diff
        /// </param>
        /// <param name="patchUrl">
        /// Example: https://github.com/octocat/Hello-World/pull/1347.patch
        /// </param>
        /// <param name="issueUrl">
        /// Example: https://api.github.com/repos/octocat/Hello-World/issues/1347
        /// </param>
        /// <param name="commitsUrl">
        /// Example: https://api.github.com/repos/octocat/Hello-World/pulls/1347/commits
        /// </param>
        /// <param name="reviewCommentsUrl">
        /// Example: https://api.github.com/repos/octocat/Hello-World/pulls/1347/comments
        /// </param>
        /// <param name="reviewCommentUrl">
        /// Example: https://api.github.com/repos/octocat/Hello-World/pulls/comments{/number}
        /// </param>
        /// <param name="commentsUrl">
        /// Example: https://api.github.com/repos/octocat/Hello-World/issues/1347/comments
        /// </param>
        /// <param name="statusesUrl">
        /// Example: https://api.github.com/repos/octocat/Hello-World/statuses/6dcb09b5b57875f334f61aebed695e2e4193db5e
        /// </param>
        /// <param name="number">
        /// Example: 1347
        /// </param>
        /// <param name="state">
        /// Example: open
        /// </param>
        /// <param name="locked">
        /// Example: true
        /// </param>
        /// <param name="title">
        /// Example: new-feature
        /// </param>
        /// <param name="user">
        /// A GitHub user.
        /// </param>
        /// <param name="body">
        /// Example: Please pull these awesome changes
        /// </param>
        /// <param name="labels"></param>
        /// <param name="milestone">
        /// A collection of related issues and pull requests.
        /// </param>
        /// <param name="activeLockReason">
        /// Example: too heated
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="closedAt"></param>
        /// <param name="mergedAt"></param>
        /// <param name="mergeCommitSha">
        /// Example: e5bd3914e2e596debea16f433f57875b5b90bcd6
        /// </param>
        /// <param name="assignee">
        /// A GitHub user.
        /// </param>
        /// <param name="assignees"></param>
        /// <param name="requestedReviewers"></param>
        /// <param name="requestedTeams"></param>
        /// <param name="head"></param>
        /// <param name="base"></param>
        /// <param name="links"></param>
        /// <param name="authorAssociation">
        /// How the author is associated with the repository.<br/>
        /// Example: OWNER
        /// </param>
        /// <param name="autoMerge">
        /// The status of auto merging a pull request.
        /// </param>
        /// <param name="draft">
        /// Indicates whether or not the pull request is a draft.<br/>
        /// Example: false
        /// </param>
        public PullRequestSimple(
            string url,
            long id,
            string nodeId,
            string htmlUrl,
            string diffUrl,
            string patchUrl,
            string issueUrl,
            string commitsUrl,
            string reviewCommentsUrl,
            string reviewCommentUrl,
            string commentsUrl,
            string statusesUrl,
            int number,
            string state,
            bool locked,
            string title,
            global::G.NullableSimpleUser? user,
            string? body,
            global::System.Collections.Generic.IList<global::G.PullRequestSimpleLabel> labels,
            global::G.NullableMilestone? milestone,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.DateTime? closedAt,
            global::System.DateTime? mergedAt,
            string? mergeCommitSha,
            global::G.NullableSimpleUser? assignee,
            global::G.PullRequestSimpleHead head,
            global::G.PullRequestSimpleBase @base,
            global::G.PullRequestSimpleLinks links,
            global::G.AuthorAssociation authorAssociation,
            global::G.AutoMerge? autoMerge,
            string? activeLockReason,
            global::System.Collections.Generic.IList<global::G.SimpleUser>? assignees,
            global::System.Collections.Generic.IList<global::G.SimpleUser>? requestedReviewers,
            global::System.Collections.Generic.IList<global::G.Team>? requestedTeams,
            bool? draft)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.DiffUrl = diffUrl ?? throw new global::System.ArgumentNullException(nameof(diffUrl));
            this.PatchUrl = patchUrl ?? throw new global::System.ArgumentNullException(nameof(patchUrl));
            this.IssueUrl = issueUrl ?? throw new global::System.ArgumentNullException(nameof(issueUrl));
            this.CommitsUrl = commitsUrl ?? throw new global::System.ArgumentNullException(nameof(commitsUrl));
            this.ReviewCommentsUrl = reviewCommentsUrl ?? throw new global::System.ArgumentNullException(nameof(reviewCommentsUrl));
            this.ReviewCommentUrl = reviewCommentUrl ?? throw new global::System.ArgumentNullException(nameof(reviewCommentUrl));
            this.CommentsUrl = commentsUrl ?? throw new global::System.ArgumentNullException(nameof(commentsUrl));
            this.StatusesUrl = statusesUrl ?? throw new global::System.ArgumentNullException(nameof(statusesUrl));
            this.Number = number;
            this.State = state ?? throw new global::System.ArgumentNullException(nameof(state));
            this.Locked = locked;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
            this.Milestone = milestone ?? throw new global::System.ArgumentNullException(nameof(milestone));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ClosedAt = closedAt;
            this.MergedAt = mergedAt;
            this.MergeCommitSha = mergeCommitSha ?? throw new global::System.ArgumentNullException(nameof(mergeCommitSha));
            this.Assignee = assignee ?? throw new global::System.ArgumentNullException(nameof(assignee));
            this.Head = head ?? throw new global::System.ArgumentNullException(nameof(head));
            this.Base = @base ?? throw new global::System.ArgumentNullException(nameof(@base));
            this.Links = links ?? throw new global::System.ArgumentNullException(nameof(links));
            this.AuthorAssociation = authorAssociation;
            this.AutoMerge = autoMerge ?? throw new global::System.ArgumentNullException(nameof(autoMerge));
            this.ActiveLockReason = activeLockReason;
            this.Assignees = assignees;
            this.RequestedReviewers = requestedReviewers;
            this.RequestedTeams = requestedTeams;
            this.Draft = draft;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestSimple" /> class.
        /// </summary>
        public PullRequestSimple()
        {
        }
    }
}
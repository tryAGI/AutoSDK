//HintName: G.Models.PullRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Pull requests let you tell others about changes you've pushed to a repository on GitHub. Once a pull request is sent, interested parties can review the set of changes, discuss potential modifications, and even push follow-up commits if necessary.
    /// </summary>
    public sealed partial class PullRequest
    {
        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/pulls/1347
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/pulls/1347</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Example: 1L
        /// </summary>
        /// <example>1L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Id { get; set; }

        /// <summary>
        /// Example: MDExOlB1bGxSZXF1ZXN0MQ==
        /// </summary>
        /// <example>MDExOlB1bGxSZXF1ZXN0MQ==</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// Example: https://github.com/octocat/Hello-World/pull/1347
        /// </summary>
        /// <example>https://github.com/octocat/Hello-World/pull/1347</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// Example: https://github.com/octocat/Hello-World/pull/1347.diff
        /// </summary>
        /// <example>https://github.com/octocat/Hello-World/pull/1347.diff</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("diff_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DiffUrl { get; set; }

        /// <summary>
        /// Example: https://github.com/octocat/Hello-World/pull/1347.patch
        /// </summary>
        /// <example>https://github.com/octocat/Hello-World/pull/1347.patch</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("patch_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PatchUrl { get; set; }

        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/issues/1347
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/issues/1347</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("issue_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IssueUrl { get; set; }

        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/pulls/1347/commits
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/pulls/1347/commits</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("commits_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CommitsUrl { get; set; }

        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/pulls/1347/comments
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/pulls/1347/comments</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("review_comments_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReviewCommentsUrl { get; set; }

        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/pulls/comments{/number}
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/pulls/comments{/number}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("review_comment_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReviewCommentUrl { get; set; }

        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/issues/1347/comments
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/issues/1347/comments</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("comments_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CommentsUrl { get; set; }

        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/statuses/6dcb09b5b57875f334f61aebed695e2e4193db5e
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/statuses/6dcb09b5b57875f334f61aebed695e2e4193db5e</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("statuses_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StatusesUrl { get; set; }

        /// <summary>
        /// Number uniquely identifying the pull request within its repository.<br/>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Number { get; set; }

        /// <summary>
        /// State of this Pull Request. Either `open` or `closed`.<br/>
        /// Example: open
        /// </summary>
        /// <example>open</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PullRequestStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PullRequestState State { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("locked")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Locked { get; set; }

        /// <summary>
        /// The title of the pull request.<br/>
        /// Example: Amazing new feature
        /// </summary>
        /// <example>Amazing new feature</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SimpleUser User { get; set; }

        /// <summary>
        /// Example: Please pull these awesome changes
        /// </summary>
        /// <example>Please pull these awesome changes</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Body { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.PullRequestLabel> Labels { get; set; }

        /// <summary>
        /// A collection of related issues and pull requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("milestone")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.NullableMilestone? Milestone { get; set; }

        /// <summary>
        /// Example: too heated
        /// </summary>
        /// <example>too heated</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_lock_reason")]
        public string? ActiveLockReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("closed_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? ClosedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merged_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? MergedAt { get; set; }

        /// <summary>
        /// Example: e5bd3914e2e596debea16f433f57875b5b90bcd6
        /// </summary>
        /// <example>e5bd3914e2e596debea16f433f57875b5b90bcd6</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("merge_commit_sha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? MergeCommitSha { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignee")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.NullableSimpleUser? Assignee { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignees")]
        public global::System.Collections.Generic.IList<global::G.SimpleUser>? Assignees { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requested_reviewers")]
        public global::System.Collections.Generic.IList<global::G.SimpleUser>? RequestedReviewers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requested_teams")]
        public global::System.Collections.Generic.IList<global::G.TeamSimple>? RequestedTeams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("head")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PullRequestHead Head { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PullRequestBase Base { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_links")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PullRequestLinks Links { get; set; }

        /// <summary>
        /// How the author is associated with the repository.<br/>
        /// Example: OWNER
        /// </summary>
        /// <example>OWNER</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("author_association")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AuthorAssociationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AuthorAssociation AuthorAssociation { get; set; }

        /// <summary>
        /// The status of auto merging a pull request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_merge")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AutoMerge? AutoMerge { get; set; }

        /// <summary>
        /// Indicates whether or not the pull request is a draft.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("draft")]
        public bool? Draft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merged")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Merged { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mergeable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool? Mergeable { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("rebaseable")]
        public bool? Rebaseable { get; set; }

        /// <summary>
        /// Example: clean
        /// </summary>
        /// <example>clean</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mergeable_state")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MergeableState { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merged_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.NullableSimpleUser? MergedBy { get; set; }

        /// <summary>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("comments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Comments { get; set; }

        /// <summary>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("review_comments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ReviewComments { get; set; }

        /// <summary>
        /// Indicates whether maintainers can modify the pull request.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("maintainer_can_modify")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool MaintainerCanModify { get; set; }

        /// <summary>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("commits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Commits { get; set; }

        /// <summary>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("additions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Additions { get; set; }

        /// <summary>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("deletions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Deletions { get; set; }

        /// <summary>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("changed_files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ChangedFiles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequest" /> class.
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
        /// Number uniquely identifying the pull request within its repository.<br/>
        /// Example: 42
        /// </param>
        /// <param name="state">
        /// State of this Pull Request. Either `open` or `closed`.<br/>
        /// Example: open
        /// </param>
        /// <param name="locked">
        /// Example: true
        /// </param>
        /// <param name="title">
        /// The title of the pull request.<br/>
        /// Example: Amazing new feature
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
        /// <param name="merged"></param>
        /// <param name="mergeable">
        /// Example: true
        /// </param>
        /// <param name="rebaseable">
        /// Example: true
        /// </param>
        /// <param name="mergeableState">
        /// Example: clean
        /// </param>
        /// <param name="mergedBy">
        /// A GitHub user.
        /// </param>
        /// <param name="comments">
        /// Example: 10
        /// </param>
        /// <param name="reviewComments">
        /// Example: 0
        /// </param>
        /// <param name="maintainerCanModify">
        /// Indicates whether maintainers can modify the pull request.<br/>
        /// Example: true
        /// </param>
        /// <param name="commits">
        /// Example: 3
        /// </param>
        /// <param name="additions">
        /// Example: 100
        /// </param>
        /// <param name="deletions">
        /// Example: 3
        /// </param>
        /// <param name="changedFiles">
        /// Example: 5
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PullRequest(
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
            global::G.PullRequestState state,
            bool locked,
            string title,
            global::G.SimpleUser user,
            string? body,
            global::System.Collections.Generic.IList<global::G.PullRequestLabel> labels,
            global::G.NullableMilestone? milestone,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.DateTime? closedAt,
            global::System.DateTime? mergedAt,
            string? mergeCommitSha,
            global::G.NullableSimpleUser? assignee,
            global::G.PullRequestHead head,
            global::G.PullRequestBase @base,
            global::G.PullRequestLinks links,
            global::G.AuthorAssociation authorAssociation,
            global::G.AutoMerge? autoMerge,
            bool merged,
            bool? mergeable,
            string mergeableState,
            global::G.NullableSimpleUser? mergedBy,
            int comments,
            int reviewComments,
            bool maintainerCanModify,
            int commits,
            int additions,
            int deletions,
            int changedFiles,
            string? activeLockReason,
            global::System.Collections.Generic.IList<global::G.SimpleUser>? assignees,
            global::System.Collections.Generic.IList<global::G.SimpleUser>? requestedReviewers,
            global::System.Collections.Generic.IList<global::G.TeamSimple>? requestedTeams,
            bool? draft,
            bool? rebaseable)
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
            this.State = state;
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
            this.Merged = merged;
            this.Mergeable = mergeable;
            this.MergeableState = mergeableState ?? throw new global::System.ArgumentNullException(nameof(mergeableState));
            this.MergedBy = mergedBy ?? throw new global::System.ArgumentNullException(nameof(mergedBy));
            this.Comments = comments;
            this.ReviewComments = reviewComments;
            this.MaintainerCanModify = maintainerCanModify;
            this.Commits = commits;
            this.Additions = additions;
            this.Deletions = deletions;
            this.ChangedFiles = changedFiles;
            this.ActiveLockReason = activeLockReason;
            this.Assignees = assignees;
            this.RequestedReviewers = requestedReviewers;
            this.RequestedTeams = requestedTeams;
            this.Draft = draft;
            this.Rebaseable = rebaseable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequest" /> class.
        /// </summary>
        public PullRequest()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::G.PullRequest? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.PullRequest),
                jsonSerializerContext) as global::G.PullRequest;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.PullRequest? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.PullRequest>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.PullRequest?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.PullRequest),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.PullRequest;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.PullRequest?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.PullRequest?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}
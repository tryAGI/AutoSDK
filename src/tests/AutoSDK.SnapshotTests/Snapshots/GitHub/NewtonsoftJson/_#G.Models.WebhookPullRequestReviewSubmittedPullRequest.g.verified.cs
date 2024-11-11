//HintName: G.Models.WebhookPullRequestReviewSubmittedPullRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookPullRequestReviewSubmittedPullRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("_links", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPullRequestReviewSubmittedPullRequestLinks Links { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("active_lock_reason", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPullRequestReviewSubmittedPullRequestActiveLockReason? ActiveLockReason { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assignee", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPullRequestReviewSubmittedPullRequestAssignee? Assignee { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assignees", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.WebhookPullRequestReviewSubmittedPullRequestAssignee2> Assignees { get; set; } = default!;

        /// <summary>
        /// How the author is associated with the repository.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author_association", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPullRequestReviewSubmittedPullRequestAuthorAssociation AuthorAssociation { get; set; } = default!;

        /// <summary>
        /// The status of auto merging a pull request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auto_merge", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPullRequestReviewSubmittedPullRequestAutoMerge? AutoMerge { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("base", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPullRequestReviewSubmittedPullRequestBase Base { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Body { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("closed_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string? ClosedAt { get; set; } = default!;

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
        public global::G.WebhookPullRequestReviewSubmittedPullRequestHead Head { get; set; } = default!;

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
        public global::System.Collections.Generic.IList<global::G.WebhookPullRequestReviewSubmittedPullRequestLabel> Labels { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("locked", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Locked { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("merge_commit_sha", Required = global::Newtonsoft.Json.Required.Always)]
        public string? MergeCommitSha { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("merged_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string? MergedAt { get; set; } = default!;

        /// <summary>
        /// A collection of related issues and pull requests.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("milestone", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPullRequestReviewSubmittedPullRequestMilestone? Milestone { get; set; } = default!;

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
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerVariant1, global::G.WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerVariant2>> RequestedReviewers { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requested_teams", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.WebhookPullRequestReviewSubmittedPullRequestRequestedTeam> RequestedTeams { get; set; } = default!;

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
        public global::G.WebhookPullRequestReviewSubmittedPullRequestState State { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonProperty("user", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPullRequestReviewSubmittedPullRequestUser? User { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestReviewSubmittedPullRequest" /> class.
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
        public WebhookPullRequestReviewSubmittedPullRequest(
            global::G.WebhookPullRequestReviewSubmittedPullRequestLinks links,
            global::G.WebhookPullRequestReviewSubmittedPullRequestActiveLockReason? activeLockReason,
            global::G.WebhookPullRequestReviewSubmittedPullRequestAssignee? assignee,
            global::System.Collections.Generic.IList<global::G.WebhookPullRequestReviewSubmittedPullRequestAssignee2> assignees,
            global::G.WebhookPullRequestReviewSubmittedPullRequestAuthorAssociation authorAssociation,
            global::G.WebhookPullRequestReviewSubmittedPullRequestAutoMerge? autoMerge,
            global::G.WebhookPullRequestReviewSubmittedPullRequestBase @base,
            string? body,
            string? closedAt,
            string commentsUrl,
            string commitsUrl,
            string createdAt,
            string diffUrl,
            bool draft,
            global::G.WebhookPullRequestReviewSubmittedPullRequestHead head,
            string htmlUrl,
            int id,
            string issueUrl,
            global::System.Collections.Generic.IList<global::G.WebhookPullRequestReviewSubmittedPullRequestLabel> labels,
            bool locked,
            string? mergeCommitSha,
            string? mergedAt,
            global::G.WebhookPullRequestReviewSubmittedPullRequestMilestone? milestone,
            string nodeId,
            int number,
            string patchUrl,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerVariant1, global::G.WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerVariant2>> requestedReviewers,
            global::System.Collections.Generic.IList<global::G.WebhookPullRequestReviewSubmittedPullRequestRequestedTeam> requestedTeams,
            string reviewCommentUrl,
            string reviewCommentsUrl,
            global::G.WebhookPullRequestReviewSubmittedPullRequestState state,
            string statusesUrl,
            string title,
            string updatedAt,
            string url,
            global::G.WebhookPullRequestReviewSubmittedPullRequestUser? user)
        {
            this.Links = links ?? throw new global::System.ArgumentNullException(nameof(links));
            this.ActiveLockReason = activeLockReason;
            this.Assignee = assignee ?? throw new global::System.ArgumentNullException(nameof(assignee));
            this.Assignees = assignees ?? throw new global::System.ArgumentNullException(nameof(assignees));
            this.AuthorAssociation = authorAssociation;
            this.AutoMerge = autoMerge ?? throw new global::System.ArgumentNullException(nameof(autoMerge));
            this.Base = @base ?? throw new global::System.ArgumentNullException(nameof(@base));
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
            this.ClosedAt = closedAt ?? throw new global::System.ArgumentNullException(nameof(closedAt));
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
            this.MergeCommitSha = mergeCommitSha ?? throw new global::System.ArgumentNullException(nameof(mergeCommitSha));
            this.MergedAt = mergedAt ?? throw new global::System.ArgumentNullException(nameof(mergedAt));
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
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestReviewSubmittedPullRequest" /> class.
        /// </summary>
        public WebhookPullRequestReviewSubmittedPullRequest()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.WebhookPullRequestReviewSubmittedPullRequest? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.WebhookPullRequestReviewSubmittedPullRequest>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.WebhookPullRequestReviewSubmittedPullRequest?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.WebhookPullRequestReviewSubmittedPullRequest?>(serializer.Deserialize<global::G.WebhookPullRequestReviewSubmittedPullRequest>(jsonReader));
        }

    }
}
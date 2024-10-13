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
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Example: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Example: MDExOlB1bGxSZXF1ZXN0MQ==
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// Example: https://github.com/octocat/Hello-World/pull/1347
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://github.com/octocat/Hello-World/pull/1347.diff
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("diff_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string DiffUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://github.com/octocat/Hello-World/pull/1347.patch
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("patch_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string PatchUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/issues/1347
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("issue_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string IssueUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/pulls/1347/commits
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commits_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string CommitsUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/pulls/1347/comments
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("review_comments_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ReviewCommentsUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/pulls/comments{/number}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("review_comment_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ReviewCommentUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/issues/1347/comments
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comments_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string CommentsUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/statuses/6dcb09b5b57875f334f61aebed695e2e4193db5e
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("statuses_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string StatusesUrl { get; set; } = default!;

        /// <summary>
        /// Number uniquely identifying the pull request within its repository.<br/>
        /// Example: 42
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("number", Required = global::Newtonsoft.Json.Required.Always)]
        public int Number { get; set; } = default!;

        /// <summary>
        /// State of this Pull Request. Either `open` or `closed`.<br/>
        /// Example: open
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PullRequestState State { get; set; } = default!;

        /// <summary>
        /// Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("locked", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Locked { get; set; } = default!;

        /// <summary>
        /// The title of the pull request.<br/>
        /// Example: Amazing new feature
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SimpleUser User { get; set; } = default!;

        /// <summary>
        /// Example: Please pull these awesome changes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Body { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("labels", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.PullRequestLabel> Labels { get; set; } = default!;

        /// <summary>
        /// A collection of related issues and pull requests.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("milestone", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableMilestone? Milestone { get; set; } = default!;

        /// <summary>
        /// Example: too heated
        /// </summary>
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
        public global::System.Collections.Generic.IList<global::G.TeamSimple>? RequestedTeams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("head", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PullRequestHead Head { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("base", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PullRequestBase Base { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("_links", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PullRequestLinks Links { get; set; } = default!;

        /// <summary>
        /// How the author is associated with the repository.<br/>
        /// Example: OWNER
        /// </summary>
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
        [global::Newtonsoft.Json.JsonProperty("draft")]
        public bool? Draft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("merged", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Merged { get; set; } = default!;

        /// <summary>
        /// Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mergeable", Required = global::Newtonsoft.Json.Required.Always)]
        public bool? Mergeable { get; set; } = default!;

        /// <summary>
        /// Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rebaseable")]
        public bool? Rebaseable { get; set; }

        /// <summary>
        /// Example: clean
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mergeable_state", Required = global::Newtonsoft.Json.Required.Always)]
        public string MergeableState { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("merged_by", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableSimpleUser? MergedBy { get; set; } = default!;

        /// <summary>
        /// Example: 10
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comments", Required = global::Newtonsoft.Json.Required.Always)]
        public int Comments { get; set; } = default!;

        /// <summary>
        /// Example: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("review_comments", Required = global::Newtonsoft.Json.Required.Always)]
        public int ReviewComments { get; set; } = default!;

        /// <summary>
        /// Indicates whether maintainers can modify the pull request.<br/>
        /// Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maintainer_can_modify", Required = global::Newtonsoft.Json.Required.Always)]
        public bool MaintainerCanModify { get; set; } = default!;

        /// <summary>
        /// Example: 3
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commits", Required = global::Newtonsoft.Json.Required.Always)]
        public int Commits { get; set; } = default!;

        /// <summary>
        /// Example: 100
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("additions", Required = global::Newtonsoft.Json.Required.Always)]
        public int Additions { get; set; } = default!;

        /// <summary>
        /// Example: 3
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deletions", Required = global::Newtonsoft.Json.Required.Always)]
        public int Deletions { get; set; } = default!;

        /// <summary>
        /// Example: 5
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("changed_files", Required = global::Newtonsoft.Json.Required.Always)]
        public int ChangedFiles { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


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
        public static global::G.PullRequest? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.PullRequest>(
                json,
                jsonSerializerOptions);
        }

    }
}
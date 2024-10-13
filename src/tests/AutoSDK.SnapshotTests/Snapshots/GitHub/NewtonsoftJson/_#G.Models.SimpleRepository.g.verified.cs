//HintName: G.Models.SimpleRepository.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A GitHub repository.
    /// </summary>
    public sealed partial class SimpleRepository
    {
        /// <summary>
        /// A unique identifier of the repository.<br/>
        /// Example: 1296269
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// The GraphQL identifier of the repository.<br/>
        /// Example: MDEwOlJlcG9zaXRvcnkxMjk2MjY5
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// The name of the repository.<br/>
        /// Example: Hello-World
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The full, globally unique, name of the repository.<br/>
        /// Example: octocat/Hello-World
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("full_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string FullName { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SimpleUser Owner { get; set; } = default!;

        /// <summary>
        /// Whether the repository is private.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("private", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Private { get; set; } = default!;

        /// <summary>
        /// The URL to view the repository on GitHub.com.<br/>
        /// Example: https://github.com/octocat/Hello-World
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// The repository description.<br/>
        /// Example: This your first repo!
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Description { get; set; } = default!;

        /// <summary>
        /// Whether the repository is a fork.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fork", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Fork { get; set; } = default!;

        /// <summary>
        /// The URL to get more information about the repository from the GitHub API.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// A template for the API URL to download the repository as an archive.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/{archive_format}{/ref}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("archive_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ArchiveUrl { get; set; } = default!;

        /// <summary>
        /// A template for the API URL to list the available assignees for issues in the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/assignees{/user}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assignees_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string AssigneesUrl { get; set; } = default!;

        /// <summary>
        /// A template for the API URL to create or retrieve a raw Git blob in the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/git/blobs{/sha}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("blobs_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string BlobsUrl { get; set; } = default!;

        /// <summary>
        /// A template for the API URL to get information about branches in the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/branches{/branch}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("branches_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string BranchesUrl { get; set; } = default!;

        /// <summary>
        /// A template for the API URL to get information about collaborators of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/collaborators{/collaborator}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("collaborators_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string CollaboratorsUrl { get; set; } = default!;

        /// <summary>
        /// A template for the API URL to get information about comments on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/comments{/number}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comments_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string CommentsUrl { get; set; } = default!;

        /// <summary>
        /// A template for the API URL to get information about commits on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/commits{/sha}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commits_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string CommitsUrl { get; set; } = default!;

        /// <summary>
        /// A template for the API URL to compare two commits or refs.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/compare/{base}...{head}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("compare_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string CompareUrl { get; set; } = default!;

        /// <summary>
        /// A template for the API URL to get the contents of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/contents/{+path}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("contents_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ContentsUrl { get; set; } = default!;

        /// <summary>
        /// A template for the API URL to list the contributors to the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/contributors
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("contributors_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ContributorsUrl { get; set; } = default!;

        /// <summary>
        /// The API URL to list the deployments of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/deployments
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deployments_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string DeploymentsUrl { get; set; } = default!;

        /// <summary>
        /// The API URL to list the downloads on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/downloads
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("downloads_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string DownloadsUrl { get; set; } = default!;

        /// <summary>
        /// The API URL to list the events of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/events
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("events_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string EventsUrl { get; set; } = default!;

        /// <summary>
        /// The API URL to list the forks of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/forks
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("forks_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ForksUrl { get; set; } = default!;

        /// <summary>
        /// A template for the API URL to get information about Git commits of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/git/commits{/sha}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("git_commits_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string GitCommitsUrl { get; set; } = default!;

        /// <summary>
        /// A template for the API URL to get information about Git refs of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/git/refs{/sha}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("git_refs_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string GitRefsUrl { get; set; } = default!;

        /// <summary>
        /// A template for the API URL to get information about Git tags of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/git/tags{/sha}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("git_tags_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string GitTagsUrl { get; set; } = default!;

        /// <summary>
        /// A template for the API URL to get information about issue comments on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/issues/comments{/number}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("issue_comment_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string IssueCommentUrl { get; set; } = default!;

        /// <summary>
        /// A template for the API URL to get information about issue events on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/issues/events{/number}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("issue_events_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string IssueEventsUrl { get; set; } = default!;

        /// <summary>
        /// A template for the API URL to get information about issues on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/issues{/number}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("issues_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string IssuesUrl { get; set; } = default!;

        /// <summary>
        /// A template for the API URL to get information about deploy keys on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/keys{/key_id}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("keys_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string KeysUrl { get; set; } = default!;

        /// <summary>
        /// A template for the API URL to get information about labels of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/labels{/name}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("labels_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string LabelsUrl { get; set; } = default!;

        /// <summary>
        /// The API URL to get information about the languages of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/languages
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("languages_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string LanguagesUrl { get; set; } = default!;

        /// <summary>
        /// The API URL to merge branches in the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/merges
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("merges_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string MergesUrl { get; set; } = default!;

        /// <summary>
        /// A template for the API URL to get information about milestones of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/milestones{/number}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("milestones_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string MilestonesUrl { get; set; } = default!;

        /// <summary>
        /// A template for the API URL to get information about notifications on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/notifications{?since,all,participating}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("notifications_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string NotificationsUrl { get; set; } = default!;

        /// <summary>
        /// A template for the API URL to get information about pull requests on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/pulls{/number}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pulls_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string PullsUrl { get; set; } = default!;

        /// <summary>
        /// A template for the API URL to get information about releases on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/releases{/id}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("releases_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ReleasesUrl { get; set; } = default!;

        /// <summary>
        /// The API URL to list the stargazers on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/stargazers
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stargazers_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string StargazersUrl { get; set; } = default!;

        /// <summary>
        /// A template for the API URL to get information about statuses of a commit.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/statuses/{sha}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("statuses_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string StatusesUrl { get; set; } = default!;

        /// <summary>
        /// The API URL to list the subscribers on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/subscribers
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("subscribers_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string SubscribersUrl { get; set; } = default!;

        /// <summary>
        /// The API URL to subscribe to notifications for this repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/subscription
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("subscription_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string SubscriptionUrl { get; set; } = default!;

        /// <summary>
        /// The API URL to get information about tags on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/tags
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string TagsUrl { get; set; } = default!;

        /// <summary>
        /// The API URL to list the teams on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/teams
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("teams_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string TeamsUrl { get; set; } = default!;

        /// <summary>
        /// A template for the API URL to create or retrieve a raw Git tree of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/git/trees{/sha}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trees_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string TreesUrl { get; set; } = default!;

        /// <summary>
        /// The API URL to list the hooks on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/hooks
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hooks_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HooksUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
    #if NET6_0_OR_GREATER
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
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.SimpleRepository? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.SimpleRepository>(
                json,
                jsonSerializerOptions);
        }

    }
}
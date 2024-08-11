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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// The GraphQL identifier of the repository.<br/>
        /// Example: MDEwOlJlcG9zaXRvcnkxMjk2MjY5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// The name of the repository.<br/>
        /// Example: Hello-World
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The full, globally unique, name of the repository.<br/>
        /// Example: octocat/Hello-World
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("full_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FullName { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SimpleUser? Owner { get; set; }

        /// <summary>
        /// Whether the repository is private.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Private { get; set; }

        /// <summary>
        /// The URL to view the repository on GitHub.com.<br/>
        /// Example: https://github.com/octocat/Hello-World
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// The repository description.<br/>
        /// Example: This your first repo!
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Description { get; set; }

        /// <summary>
        /// Whether the repository is a fork.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fork")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Fork { get; set; }

        /// <summary>
        /// The URL to get more information about the repository from the GitHub API.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// A template for the API URL to download the repository as an archive.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/{archive_format}{/ref}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archive_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ArchiveUrl { get; set; }

        /// <summary>
        /// A template for the API URL to list the available assignees for issues in the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/assignees{/user}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignees_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AssigneesUrl { get; set; }

        /// <summary>
        /// A template for the API URL to create or retrieve a raw Git blob in the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/git/blobs{/sha}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blobs_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BlobsUrl { get; set; }

        /// <summary>
        /// A template for the API URL to get information about branches in the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/branches{/branch}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branches_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BranchesUrl { get; set; }

        /// <summary>
        /// A template for the API URL to get information about collaborators of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/collaborators{/collaborator}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collaborators_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CollaboratorsUrl { get; set; }

        /// <summary>
        /// A template for the API URL to get information about comments on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/comments{/number}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comments_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CommentsUrl { get; set; }

        /// <summary>
        /// A template for the API URL to get information about commits on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/commits{/sha}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commits_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CommitsUrl { get; set; }

        /// <summary>
        /// A template for the API URL to compare two commits or refs.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/compare/{base}...{head}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compare_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CompareUrl { get; set; }

        /// <summary>
        /// A template for the API URL to get the contents of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/contents/{+path}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contents_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentsUrl { get; set; }

        /// <summary>
        /// A template for the API URL to list the contributors to the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/contributors
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contributors_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContributorsUrl { get; set; }

        /// <summary>
        /// The API URL to list the deployments of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/deployments
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployments_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeploymentsUrl { get; set; }

        /// <summary>
        /// The API URL to list the downloads on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/downloads
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("downloads_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DownloadsUrl { get; set; }

        /// <summary>
        /// The API URL to list the events of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/events
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventsUrl { get; set; }

        /// <summary>
        /// The API URL to list the forks of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/forks
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("forks_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ForksUrl { get; set; }

        /// <summary>
        /// A template for the API URL to get information about Git commits of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/git/commits{/sha}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("git_commits_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GitCommitsUrl { get; set; }

        /// <summary>
        /// A template for the API URL to get information about Git refs of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/git/refs{/sha}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("git_refs_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GitRefsUrl { get; set; }

        /// <summary>
        /// A template for the API URL to get information about Git tags of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/git/tags{/sha}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("git_tags_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GitTagsUrl { get; set; }

        /// <summary>
        /// A template for the API URL to get information about issue comments on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/issues/comments{/number}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issue_comment_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IssueCommentUrl { get; set; }

        /// <summary>
        /// A template for the API URL to get information about issue events on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/issues/events{/number}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issue_events_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IssueEventsUrl { get; set; }

        /// <summary>
        /// A template for the API URL to get information about issues on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/issues{/number}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IssuesUrl { get; set; }

        /// <summary>
        /// A template for the API URL to get information about deploy keys on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/keys{/key_id}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keys_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KeysUrl { get; set; }

        /// <summary>
        /// A template for the API URL to get information about labels of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/labels{/name}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LabelsUrl { get; set; }

        /// <summary>
        /// The API URL to get information about the languages of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/languages
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LanguagesUrl { get; set; }

        /// <summary>
        /// The API URL to merge branches in the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/merges
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merges_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MergesUrl { get; set; }

        /// <summary>
        /// A template for the API URL to get information about milestones of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/milestones{/number}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("milestones_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MilestonesUrl { get; set; }

        /// <summary>
        /// A template for the API URL to get information about notifications on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/notifications{?since,all,participating}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notifications_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NotificationsUrl { get; set; }

        /// <summary>
        /// A template for the API URL to get information about pull requests on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/pulls{/number}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pulls_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PullsUrl { get; set; }

        /// <summary>
        /// A template for the API URL to get information about releases on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/releases{/id}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("releases_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReleasesUrl { get; set; }

        /// <summary>
        /// The API URL to list the stargazers on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/stargazers
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stargazers_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StargazersUrl { get; set; }

        /// <summary>
        /// A template for the API URL to get information about statuses of a commit.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/statuses/{sha}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statuses_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StatusesUrl { get; set; }

        /// <summary>
        /// The API URL to list the subscribers on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/subscribers
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscribers_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SubscribersUrl { get; set; }

        /// <summary>
        /// The API URL to subscribe to notifications for this repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/subscription
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SubscriptionUrl { get; set; }

        /// <summary>
        /// The API URL to get information about tags on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/tags
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TagsUrl { get; set; }

        /// <summary>
        /// The API URL to list the teams on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/teams
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teams_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamsUrl { get; set; }

        /// <summary>
        /// A template for the API URL to create or retrieve a raw Git tree of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/git/trees{/sha}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trees_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TreesUrl { get; set; }

        /// <summary>
        /// The API URL to list the hooks on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/hooks
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hooks_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HooksUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
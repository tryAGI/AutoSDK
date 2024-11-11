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
        /// Example: 1296269L
        /// </summary>
        /// <example>1296269L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Id { get; set; }

        /// <summary>
        /// The GraphQL identifier of the repository.<br/>
        /// Example: MDEwOlJlcG9zaXRvcnkxMjk2MjY5
        /// </summary>
        /// <example>MDEwOlJlcG9zaXRvcnkxMjk2MjY5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// The name of the repository.<br/>
        /// Example: Hello-World
        /// </summary>
        /// <example>Hello-World</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The full, globally unique, name of the repository.<br/>
        /// Example: octocat/Hello-World
        /// </summary>
        /// <example>octocat/Hello-World</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("full_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FullName { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SimpleUser Owner { get; set; }

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
        /// <example>https://github.com/octocat/Hello-World</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// The repository description.<br/>
        /// Example: This your first repo!
        /// </summary>
        /// <example>This your first repo!</example>
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
        /// <example>https://api.github.com/repos/octocat/Hello-World</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// A template for the API URL to download the repository as an archive.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/{archive_format}{/ref}
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/{archive_format}{/ref}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("archive_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ArchiveUrl { get; set; }

        /// <summary>
        /// A template for the API URL to list the available assignees for issues in the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/assignees{/user}
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/assignees{/user}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignees_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AssigneesUrl { get; set; }

        /// <summary>
        /// A template for the API URL to create or retrieve a raw Git blob in the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/git/blobs{/sha}
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/git/blobs{/sha}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("blobs_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BlobsUrl { get; set; }

        /// <summary>
        /// A template for the API URL to get information about branches in the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/branches{/branch}
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/branches{/branch}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("branches_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BranchesUrl { get; set; }

        /// <summary>
        /// A template for the API URL to get information about collaborators of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/collaborators{/collaborator}
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/collaborators{/collaborator}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("collaborators_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CollaboratorsUrl { get; set; }

        /// <summary>
        /// A template for the API URL to get information about comments on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/comments{/number}
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/comments{/number}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("comments_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CommentsUrl { get; set; }

        /// <summary>
        /// A template for the API URL to get information about commits on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/commits{/sha}
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/commits{/sha}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("commits_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CommitsUrl { get; set; }

        /// <summary>
        /// A template for the API URL to compare two commits or refs.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/compare/{base}...{head}
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/compare/{base}...{head}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("compare_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CompareUrl { get; set; }

        /// <summary>
        /// A template for the API URL to get the contents of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/contents/{+path}
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/contents/{+path}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("contents_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentsUrl { get; set; }

        /// <summary>
        /// A template for the API URL to list the contributors to the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/contributors
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/contributors</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("contributors_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContributorsUrl { get; set; }

        /// <summary>
        /// The API URL to list the deployments of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/deployments
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/deployments</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployments_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeploymentsUrl { get; set; }

        /// <summary>
        /// The API URL to list the downloads on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/downloads
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/downloads</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("downloads_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DownloadsUrl { get; set; }

        /// <summary>
        /// The API URL to list the events of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/events
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/events</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("events_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventsUrl { get; set; }

        /// <summary>
        /// The API URL to list the forks of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/forks
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/forks</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("forks_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ForksUrl { get; set; }

        /// <summary>
        /// A template for the API URL to get information about Git commits of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/git/commits{/sha}
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/git/commits{/sha}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("git_commits_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GitCommitsUrl { get; set; }

        /// <summary>
        /// A template for the API URL to get information about Git refs of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/git/refs{/sha}
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/git/refs{/sha}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("git_refs_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GitRefsUrl { get; set; }

        /// <summary>
        /// A template for the API URL to get information about Git tags of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/git/tags{/sha}
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/git/tags{/sha}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("git_tags_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GitTagsUrl { get; set; }

        /// <summary>
        /// A template for the API URL to get information about issue comments on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/issues/comments{/number}
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/issues/comments{/number}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("issue_comment_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IssueCommentUrl { get; set; }

        /// <summary>
        /// A template for the API URL to get information about issue events on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/issues/events{/number}
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/issues/events{/number}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("issue_events_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IssueEventsUrl { get; set; }

        /// <summary>
        /// A template for the API URL to get information about issues on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/issues{/number}
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/issues{/number}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IssuesUrl { get; set; }

        /// <summary>
        /// A template for the API URL to get information about deploy keys on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/keys{/key_id}
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/keys{/key_id}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("keys_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KeysUrl { get; set; }

        /// <summary>
        /// A template for the API URL to get information about labels of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/labels{/name}
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/labels{/name}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LabelsUrl { get; set; }

        /// <summary>
        /// The API URL to get information about the languages of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/languages
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/languages</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LanguagesUrl { get; set; }

        /// <summary>
        /// The API URL to merge branches in the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/merges
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/merges</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("merges_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MergesUrl { get; set; }

        /// <summary>
        /// A template for the API URL to get information about milestones of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/milestones{/number}
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/milestones{/number}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("milestones_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MilestonesUrl { get; set; }

        /// <summary>
        /// A template for the API URL to get information about notifications on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/notifications{?since,all,participating}
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/notifications{?since,all,participating}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("notifications_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NotificationsUrl { get; set; }

        /// <summary>
        /// A template for the API URL to get information about pull requests on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/pulls{/number}
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/pulls{/number}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pulls_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PullsUrl { get; set; }

        /// <summary>
        /// A template for the API URL to get information about releases on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/releases{/id}
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/releases{/id}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("releases_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReleasesUrl { get; set; }

        /// <summary>
        /// The API URL to list the stargazers on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/stargazers
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/stargazers</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("stargazers_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StargazersUrl { get; set; }

        /// <summary>
        /// A template for the API URL to get information about statuses of a commit.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/statuses/{sha}
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/statuses/{sha}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("statuses_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StatusesUrl { get; set; }

        /// <summary>
        /// The API URL to list the subscribers on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/subscribers
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/subscribers</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscribers_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SubscribersUrl { get; set; }

        /// <summary>
        /// The API URL to subscribe to notifications for this repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/subscription
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/subscription</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SubscriptionUrl { get; set; }

        /// <summary>
        /// The API URL to get information about tags on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/tags
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/tags</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TagsUrl { get; set; }

        /// <summary>
        /// The API URL to list the teams on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/teams
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/teams</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("teams_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamsUrl { get; set; }

        /// <summary>
        /// A template for the API URL to create or retrieve a raw Git tree of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/git/trees{/sha}
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/git/trees{/sha}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("trees_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TreesUrl { get; set; }

        /// <summary>
        /// The API URL to list the hooks on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/hooks
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/hooks</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("hooks_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HooksUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleRepository" /> class.
        /// </summary>
        /// <param name="id">
        /// A unique identifier of the repository.<br/>
        /// Example: 1296269L
        /// </param>
        /// <param name="nodeId">
        /// The GraphQL identifier of the repository.<br/>
        /// Example: MDEwOlJlcG9zaXRvcnkxMjk2MjY5
        /// </param>
        /// <param name="name">
        /// The name of the repository.<br/>
        /// Example: Hello-World
        /// </param>
        /// <param name="fullName">
        /// The full, globally unique, name of the repository.<br/>
        /// Example: octocat/Hello-World
        /// </param>
        /// <param name="owner">
        /// A GitHub user.
        /// </param>
        /// <param name="private">
        /// Whether the repository is private.
        /// </param>
        /// <param name="htmlUrl">
        /// The URL to view the repository on GitHub.com.<br/>
        /// Example: https://github.com/octocat/Hello-World
        /// </param>
        /// <param name="description">
        /// The repository description.<br/>
        /// Example: This your first repo!
        /// </param>
        /// <param name="fork">
        /// Whether the repository is a fork.
        /// </param>
        /// <param name="url">
        /// The URL to get more information about the repository from the GitHub API.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World
        /// </param>
        /// <param name="archiveUrl">
        /// A template for the API URL to download the repository as an archive.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/{archive_format}{/ref}
        /// </param>
        /// <param name="assigneesUrl">
        /// A template for the API URL to list the available assignees for issues in the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/assignees{/user}
        /// </param>
        /// <param name="blobsUrl">
        /// A template for the API URL to create or retrieve a raw Git blob in the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/git/blobs{/sha}
        /// </param>
        /// <param name="branchesUrl">
        /// A template for the API URL to get information about branches in the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/branches{/branch}
        /// </param>
        /// <param name="collaboratorsUrl">
        /// A template for the API URL to get information about collaborators of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/collaborators{/collaborator}
        /// </param>
        /// <param name="commentsUrl">
        /// A template for the API URL to get information about comments on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/comments{/number}
        /// </param>
        /// <param name="commitsUrl">
        /// A template for the API URL to get information about commits on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/commits{/sha}
        /// </param>
        /// <param name="compareUrl">
        /// A template for the API URL to compare two commits or refs.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/compare/{base}...{head}
        /// </param>
        /// <param name="contentsUrl">
        /// A template for the API URL to get the contents of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/contents/{+path}
        /// </param>
        /// <param name="contributorsUrl">
        /// A template for the API URL to list the contributors to the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/contributors
        /// </param>
        /// <param name="deploymentsUrl">
        /// The API URL to list the deployments of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/deployments
        /// </param>
        /// <param name="downloadsUrl">
        /// The API URL to list the downloads on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/downloads
        /// </param>
        /// <param name="eventsUrl">
        /// The API URL to list the events of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/events
        /// </param>
        /// <param name="forksUrl">
        /// The API URL to list the forks of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/forks
        /// </param>
        /// <param name="gitCommitsUrl">
        /// A template for the API URL to get information about Git commits of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/git/commits{/sha}
        /// </param>
        /// <param name="gitRefsUrl">
        /// A template for the API URL to get information about Git refs of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/git/refs{/sha}
        /// </param>
        /// <param name="gitTagsUrl">
        /// A template for the API URL to get information about Git tags of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/git/tags{/sha}
        /// </param>
        /// <param name="issueCommentUrl">
        /// A template for the API URL to get information about issue comments on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/issues/comments{/number}
        /// </param>
        /// <param name="issueEventsUrl">
        /// A template for the API URL to get information about issue events on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/issues/events{/number}
        /// </param>
        /// <param name="issuesUrl">
        /// A template for the API URL to get information about issues on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/issues{/number}
        /// </param>
        /// <param name="keysUrl">
        /// A template for the API URL to get information about deploy keys on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/keys{/key_id}
        /// </param>
        /// <param name="labelsUrl">
        /// A template for the API URL to get information about labels of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/labels{/name}
        /// </param>
        /// <param name="languagesUrl">
        /// The API URL to get information about the languages of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/languages
        /// </param>
        /// <param name="mergesUrl">
        /// The API URL to merge branches in the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/merges
        /// </param>
        /// <param name="milestonesUrl">
        /// A template for the API URL to get information about milestones of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/milestones{/number}
        /// </param>
        /// <param name="notificationsUrl">
        /// A template for the API URL to get information about notifications on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/notifications{?since,all,participating}
        /// </param>
        /// <param name="pullsUrl">
        /// A template for the API URL to get information about pull requests on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/pulls{/number}
        /// </param>
        /// <param name="releasesUrl">
        /// A template for the API URL to get information about releases on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/releases{/id}
        /// </param>
        /// <param name="stargazersUrl">
        /// The API URL to list the stargazers on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/stargazers
        /// </param>
        /// <param name="statusesUrl">
        /// A template for the API URL to get information about statuses of a commit.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/statuses/{sha}
        /// </param>
        /// <param name="subscribersUrl">
        /// The API URL to list the subscribers on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/subscribers
        /// </param>
        /// <param name="subscriptionUrl">
        /// The API URL to subscribe to notifications for this repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/subscription
        /// </param>
        /// <param name="tagsUrl">
        /// The API URL to get information about tags on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/tags
        /// </param>
        /// <param name="teamsUrl">
        /// The API URL to list the teams on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/teams
        /// </param>
        /// <param name="treesUrl">
        /// A template for the API URL to create or retrieve a raw Git tree of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/git/trees{/sha}
        /// </param>
        /// <param name="hooksUrl">
        /// The API URL to list the hooks on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/hooks
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public SimpleRepository(
            long id,
            string nodeId,
            string name,
            string fullName,
            global::G.SimpleUser owner,
            bool @private,
            string htmlUrl,
            string? description,
            bool fork,
            string url,
            string archiveUrl,
            string assigneesUrl,
            string blobsUrl,
            string branchesUrl,
            string collaboratorsUrl,
            string commentsUrl,
            string commitsUrl,
            string compareUrl,
            string contentsUrl,
            string contributorsUrl,
            string deploymentsUrl,
            string downloadsUrl,
            string eventsUrl,
            string forksUrl,
            string gitCommitsUrl,
            string gitRefsUrl,
            string gitTagsUrl,
            string issueCommentUrl,
            string issueEventsUrl,
            string issuesUrl,
            string keysUrl,
            string labelsUrl,
            string languagesUrl,
            string mergesUrl,
            string milestonesUrl,
            string notificationsUrl,
            string pullsUrl,
            string releasesUrl,
            string stargazersUrl,
            string statusesUrl,
            string subscribersUrl,
            string subscriptionUrl,
            string tagsUrl,
            string teamsUrl,
            string treesUrl,
            string hooksUrl)
        {
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.FullName = fullName ?? throw new global::System.ArgumentNullException(nameof(fullName));
            this.Owner = owner ?? throw new global::System.ArgumentNullException(nameof(owner));
            this.Private = @private;
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Fork = fork;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.ArchiveUrl = archiveUrl ?? throw new global::System.ArgumentNullException(nameof(archiveUrl));
            this.AssigneesUrl = assigneesUrl ?? throw new global::System.ArgumentNullException(nameof(assigneesUrl));
            this.BlobsUrl = blobsUrl ?? throw new global::System.ArgumentNullException(nameof(blobsUrl));
            this.BranchesUrl = branchesUrl ?? throw new global::System.ArgumentNullException(nameof(branchesUrl));
            this.CollaboratorsUrl = collaboratorsUrl ?? throw new global::System.ArgumentNullException(nameof(collaboratorsUrl));
            this.CommentsUrl = commentsUrl ?? throw new global::System.ArgumentNullException(nameof(commentsUrl));
            this.CommitsUrl = commitsUrl ?? throw new global::System.ArgumentNullException(nameof(commitsUrl));
            this.CompareUrl = compareUrl ?? throw new global::System.ArgumentNullException(nameof(compareUrl));
            this.ContentsUrl = contentsUrl ?? throw new global::System.ArgumentNullException(nameof(contentsUrl));
            this.ContributorsUrl = contributorsUrl ?? throw new global::System.ArgumentNullException(nameof(contributorsUrl));
            this.DeploymentsUrl = deploymentsUrl ?? throw new global::System.ArgumentNullException(nameof(deploymentsUrl));
            this.DownloadsUrl = downloadsUrl ?? throw new global::System.ArgumentNullException(nameof(downloadsUrl));
            this.EventsUrl = eventsUrl ?? throw new global::System.ArgumentNullException(nameof(eventsUrl));
            this.ForksUrl = forksUrl ?? throw new global::System.ArgumentNullException(nameof(forksUrl));
            this.GitCommitsUrl = gitCommitsUrl ?? throw new global::System.ArgumentNullException(nameof(gitCommitsUrl));
            this.GitRefsUrl = gitRefsUrl ?? throw new global::System.ArgumentNullException(nameof(gitRefsUrl));
            this.GitTagsUrl = gitTagsUrl ?? throw new global::System.ArgumentNullException(nameof(gitTagsUrl));
            this.IssueCommentUrl = issueCommentUrl ?? throw new global::System.ArgumentNullException(nameof(issueCommentUrl));
            this.IssueEventsUrl = issueEventsUrl ?? throw new global::System.ArgumentNullException(nameof(issueEventsUrl));
            this.IssuesUrl = issuesUrl ?? throw new global::System.ArgumentNullException(nameof(issuesUrl));
            this.KeysUrl = keysUrl ?? throw new global::System.ArgumentNullException(nameof(keysUrl));
            this.LabelsUrl = labelsUrl ?? throw new global::System.ArgumentNullException(nameof(labelsUrl));
            this.LanguagesUrl = languagesUrl ?? throw new global::System.ArgumentNullException(nameof(languagesUrl));
            this.MergesUrl = mergesUrl ?? throw new global::System.ArgumentNullException(nameof(mergesUrl));
            this.MilestonesUrl = milestonesUrl ?? throw new global::System.ArgumentNullException(nameof(milestonesUrl));
            this.NotificationsUrl = notificationsUrl ?? throw new global::System.ArgumentNullException(nameof(notificationsUrl));
            this.PullsUrl = pullsUrl ?? throw new global::System.ArgumentNullException(nameof(pullsUrl));
            this.ReleasesUrl = releasesUrl ?? throw new global::System.ArgumentNullException(nameof(releasesUrl));
            this.StargazersUrl = stargazersUrl ?? throw new global::System.ArgumentNullException(nameof(stargazersUrl));
            this.StatusesUrl = statusesUrl ?? throw new global::System.ArgumentNullException(nameof(statusesUrl));
            this.SubscribersUrl = subscribersUrl ?? throw new global::System.ArgumentNullException(nameof(subscribersUrl));
            this.SubscriptionUrl = subscriptionUrl ?? throw new global::System.ArgumentNullException(nameof(subscriptionUrl));
            this.TagsUrl = tagsUrl ?? throw new global::System.ArgumentNullException(nameof(tagsUrl));
            this.TeamsUrl = teamsUrl ?? throw new global::System.ArgumentNullException(nameof(teamsUrl));
            this.TreesUrl = treesUrl ?? throw new global::System.ArgumentNullException(nameof(treesUrl));
            this.HooksUrl = hooksUrl ?? throw new global::System.ArgumentNullException(nameof(hooksUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleRepository" /> class.
        /// </summary>
        public SimpleRepository()
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
        public static global::G.SimpleRepository? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.SimpleRepository),
                jsonSerializerContext) as global::G.SimpleRepository;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.SimpleRepository? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.SimpleRepository>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.SimpleRepository?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.SimpleRepository),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.SimpleRepository;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.SimpleRepository?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.SimpleRepository?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}
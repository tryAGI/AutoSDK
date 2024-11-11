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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public long Id { get; set; } = default!;

        /// <summary>
        /// The GraphQL identifier of the repository.<br/>
        /// Example: MDEwOlJlcG9zaXRvcnkxMjk2MjY5
        /// </summary>
        /// <example>MDEwOlJlcG9zaXRvcnkxMjk2MjY5</example>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// The name of the repository.<br/>
        /// Example: Hello-World
        /// </summary>
        /// <example>Hello-World</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The full, globally unique, name of the repository.<br/>
        /// Example: octocat/Hello-World
        /// </summary>
        /// <example>octocat/Hello-World</example>
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
        /// <example>https://github.com/octocat/Hello-World</example>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// The repository description.<br/>
        /// Example: This your first repo!
        /// </summary>
        /// <example>This your first repo!</example>
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
        /// <example>https://api.github.com/repos/octocat/Hello-World</example>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// A template for the API URL to download the repository as an archive.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/{archive_format}{/ref}
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/{archive_format}{/ref}</example>
        [global::Newtonsoft.Json.JsonProperty("archive_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ArchiveUrl { get; set; } = default!;

        /// <summary>
        /// A template for the API URL to list the available assignees for issues in the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/assignees{/user}
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/assignees{/user}</example>
        [global::Newtonsoft.Json.JsonProperty("assignees_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string AssigneesUrl { get; set; } = default!;

        /// <summary>
        /// A template for the API URL to create or retrieve a raw Git blob in the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/git/blobs{/sha}
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/git/blobs{/sha}</example>
        [global::Newtonsoft.Json.JsonProperty("blobs_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string BlobsUrl { get; set; } = default!;

        /// <summary>
        /// A template for the API URL to get information about branches in the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/branches{/branch}
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/branches{/branch}</example>
        [global::Newtonsoft.Json.JsonProperty("branches_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string BranchesUrl { get; set; } = default!;

        /// <summary>
        /// A template for the API URL to get information about collaborators of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/collaborators{/collaborator}
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/collaborators{/collaborator}</example>
        [global::Newtonsoft.Json.JsonProperty("collaborators_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string CollaboratorsUrl { get; set; } = default!;

        /// <summary>
        /// A template for the API URL to get information about comments on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/comments{/number}
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/comments{/number}</example>
        [global::Newtonsoft.Json.JsonProperty("comments_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string CommentsUrl { get; set; } = default!;

        /// <summary>
        /// A template for the API URL to get information about commits on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/commits{/sha}
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/commits{/sha}</example>
        [global::Newtonsoft.Json.JsonProperty("commits_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string CommitsUrl { get; set; } = default!;

        /// <summary>
        /// A template for the API URL to compare two commits or refs.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/compare/{base}...{head}
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/compare/{base}...{head}</example>
        [global::Newtonsoft.Json.JsonProperty("compare_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string CompareUrl { get; set; } = default!;

        /// <summary>
        /// A template for the API URL to get the contents of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/contents/{+path}
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/contents/{+path}</example>
        [global::Newtonsoft.Json.JsonProperty("contents_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ContentsUrl { get; set; } = default!;

        /// <summary>
        /// A template for the API URL to list the contributors to the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/contributors
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/contributors</example>
        [global::Newtonsoft.Json.JsonProperty("contributors_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ContributorsUrl { get; set; } = default!;

        /// <summary>
        /// The API URL to list the deployments of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/deployments
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/deployments</example>
        [global::Newtonsoft.Json.JsonProperty("deployments_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string DeploymentsUrl { get; set; } = default!;

        /// <summary>
        /// The API URL to list the downloads on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/downloads
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/downloads</example>
        [global::Newtonsoft.Json.JsonProperty("downloads_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string DownloadsUrl { get; set; } = default!;

        /// <summary>
        /// The API URL to list the events of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/events
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/events</example>
        [global::Newtonsoft.Json.JsonProperty("events_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string EventsUrl { get; set; } = default!;

        /// <summary>
        /// The API URL to list the forks of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/forks
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/forks</example>
        [global::Newtonsoft.Json.JsonProperty("forks_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ForksUrl { get; set; } = default!;

        /// <summary>
        /// A template for the API URL to get information about Git commits of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/git/commits{/sha}
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/git/commits{/sha}</example>
        [global::Newtonsoft.Json.JsonProperty("git_commits_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string GitCommitsUrl { get; set; } = default!;

        /// <summary>
        /// A template for the API URL to get information about Git refs of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/git/refs{/sha}
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/git/refs{/sha}</example>
        [global::Newtonsoft.Json.JsonProperty("git_refs_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string GitRefsUrl { get; set; } = default!;

        /// <summary>
        /// A template for the API URL to get information about Git tags of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/git/tags{/sha}
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/git/tags{/sha}</example>
        [global::Newtonsoft.Json.JsonProperty("git_tags_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string GitTagsUrl { get; set; } = default!;

        /// <summary>
        /// A template for the API URL to get information about issue comments on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/issues/comments{/number}
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/issues/comments{/number}</example>
        [global::Newtonsoft.Json.JsonProperty("issue_comment_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string IssueCommentUrl { get; set; } = default!;

        /// <summary>
        /// A template for the API URL to get information about issue events on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/issues/events{/number}
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/issues/events{/number}</example>
        [global::Newtonsoft.Json.JsonProperty("issue_events_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string IssueEventsUrl { get; set; } = default!;

        /// <summary>
        /// A template for the API URL to get information about issues on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/issues{/number}
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/issues{/number}</example>
        [global::Newtonsoft.Json.JsonProperty("issues_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string IssuesUrl { get; set; } = default!;

        /// <summary>
        /// A template for the API URL to get information about deploy keys on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/keys{/key_id}
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/keys{/key_id}</example>
        [global::Newtonsoft.Json.JsonProperty("keys_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string KeysUrl { get; set; } = default!;

        /// <summary>
        /// A template for the API URL to get information about labels of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/labels{/name}
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/labels{/name}</example>
        [global::Newtonsoft.Json.JsonProperty("labels_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string LabelsUrl { get; set; } = default!;

        /// <summary>
        /// The API URL to get information about the languages of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/languages
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/languages</example>
        [global::Newtonsoft.Json.JsonProperty("languages_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string LanguagesUrl { get; set; } = default!;

        /// <summary>
        /// The API URL to merge branches in the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/merges
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/merges</example>
        [global::Newtonsoft.Json.JsonProperty("merges_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string MergesUrl { get; set; } = default!;

        /// <summary>
        /// A template for the API URL to get information about milestones of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/milestones{/number}
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/milestones{/number}</example>
        [global::Newtonsoft.Json.JsonProperty("milestones_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string MilestonesUrl { get; set; } = default!;

        /// <summary>
        /// A template for the API URL to get information about notifications on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/notifications{?since,all,participating}
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/notifications{?since,all,participating}</example>
        [global::Newtonsoft.Json.JsonProperty("notifications_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string NotificationsUrl { get; set; } = default!;

        /// <summary>
        /// A template for the API URL to get information about pull requests on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/pulls{/number}
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/pulls{/number}</example>
        [global::Newtonsoft.Json.JsonProperty("pulls_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string PullsUrl { get; set; } = default!;

        /// <summary>
        /// A template for the API URL to get information about releases on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/releases{/id}
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/releases{/id}</example>
        [global::Newtonsoft.Json.JsonProperty("releases_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ReleasesUrl { get; set; } = default!;

        /// <summary>
        /// The API URL to list the stargazers on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/stargazers
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/stargazers</example>
        [global::Newtonsoft.Json.JsonProperty("stargazers_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string StargazersUrl { get; set; } = default!;

        /// <summary>
        /// A template for the API URL to get information about statuses of a commit.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/statuses/{sha}
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/statuses/{sha}</example>
        [global::Newtonsoft.Json.JsonProperty("statuses_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string StatusesUrl { get; set; } = default!;

        /// <summary>
        /// The API URL to list the subscribers on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/subscribers
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/subscribers</example>
        [global::Newtonsoft.Json.JsonProperty("subscribers_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string SubscribersUrl { get; set; } = default!;

        /// <summary>
        /// The API URL to subscribe to notifications for this repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/subscription
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/subscription</example>
        [global::Newtonsoft.Json.JsonProperty("subscription_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string SubscriptionUrl { get; set; } = default!;

        /// <summary>
        /// The API URL to get information about tags on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/tags
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/tags</example>
        [global::Newtonsoft.Json.JsonProperty("tags_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string TagsUrl { get; set; } = default!;

        /// <summary>
        /// The API URL to list the teams on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/teams
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/teams</example>
        [global::Newtonsoft.Json.JsonProperty("teams_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string TeamsUrl { get; set; } = default!;

        /// <summary>
        /// A template for the API URL to create or retrieve a raw Git tree of the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/git/trees{/sha}
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/git/trees{/sha}</example>
        [global::Newtonsoft.Json.JsonProperty("trees_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string TreesUrl { get; set; } = default!;

        /// <summary>
        /// The API URL to list the hooks on the repository.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/hooks
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/hooks</example>
        [global::Newtonsoft.Json.JsonProperty("hooks_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HooksUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
        public static global::G.SimpleRepository? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.SimpleRepository>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.SimpleRepository?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.SimpleRepository?>(serializer.Deserialize<global::G.SimpleRepository>(jsonReader));
        }

    }
}
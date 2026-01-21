//HintName: G.Models.FullRepository.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Full Repository
    /// </summary>
    public sealed partial class FullRepository
    {
        /// <summary>
        /// Example: 1296269
        /// </summary>
        /// <example>1296269</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Id { get; set; }

        /// <summary>
        /// Example: MDEwOlJlcG9zaXRvcnkxMjk2MjY5
        /// </summary>
        /// <example>MDEwOlJlcG9zaXRvcnkxMjk2MjY5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// Example: Hello-World
        /// </summary>
        /// <example>Hello-World</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Private { get; set; }

        /// <summary>
        /// Example: https://github.com/octocat/Hello-World
        /// </summary>
        /// <example>https://github.com/octocat/Hello-World</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// Example: This your first repo!
        /// </summary>
        /// <example>This your first repo!</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fork")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Fork { get; set; }

        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/{archive_format}{/ref}
        /// </summary>
        /// <example>http://api.github.com/repos/octocat/Hello-World/{archive_format}{/ref}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("archive_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ArchiveUrl { get; set; }

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/assignees{/user}
        /// </summary>
        /// <example>http://api.github.com/repos/octocat/Hello-World/assignees{/user}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignees_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AssigneesUrl { get; set; }

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/git/blobs{/sha}
        /// </summary>
        /// <example>http://api.github.com/repos/octocat/Hello-World/git/blobs{/sha}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("blobs_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BlobsUrl { get; set; }

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/branches{/branch}
        /// </summary>
        /// <example>http://api.github.com/repos/octocat/Hello-World/branches{/branch}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("branches_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BranchesUrl { get; set; }

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/collaborators{/collaborator}
        /// </summary>
        /// <example>http://api.github.com/repos/octocat/Hello-World/collaborators{/collaborator}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("collaborators_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CollaboratorsUrl { get; set; }

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/comments{/number}
        /// </summary>
        /// <example>http://api.github.com/repos/octocat/Hello-World/comments{/number}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("comments_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CommentsUrl { get; set; }

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/commits{/sha}
        /// </summary>
        /// <example>http://api.github.com/repos/octocat/Hello-World/commits{/sha}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("commits_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CommitsUrl { get; set; }

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/compare/{base}...{head}
        /// </summary>
        /// <example>http://api.github.com/repos/octocat/Hello-World/compare/{base}...{head}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("compare_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CompareUrl { get; set; }

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/contents/{+path}
        /// </summary>
        /// <example>http://api.github.com/repos/octocat/Hello-World/contents/{+path}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("contents_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentsUrl { get; set; }

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/contributors
        /// </summary>
        /// <example>http://api.github.com/repos/octocat/Hello-World/contributors</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("contributors_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContributorsUrl { get; set; }

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/deployments
        /// </summary>
        /// <example>http://api.github.com/repos/octocat/Hello-World/deployments</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployments_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeploymentsUrl { get; set; }

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/downloads
        /// </summary>
        /// <example>http://api.github.com/repos/octocat/Hello-World/downloads</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("downloads_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DownloadsUrl { get; set; }

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/events
        /// </summary>
        /// <example>http://api.github.com/repos/octocat/Hello-World/events</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("events_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventsUrl { get; set; }

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/forks
        /// </summary>
        /// <example>http://api.github.com/repos/octocat/Hello-World/forks</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("forks_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ForksUrl { get; set; }

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/git/commits{/sha}
        /// </summary>
        /// <example>http://api.github.com/repos/octocat/Hello-World/git/commits{/sha}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("git_commits_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GitCommitsUrl { get; set; }

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/git/refs{/sha}
        /// </summary>
        /// <example>http://api.github.com/repos/octocat/Hello-World/git/refs{/sha}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("git_refs_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GitRefsUrl { get; set; }

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/git/tags{/sha}
        /// </summary>
        /// <example>http://api.github.com/repos/octocat/Hello-World/git/tags{/sha}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("git_tags_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GitTagsUrl { get; set; }

        /// <summary>
        /// Example: git:github.com/octocat/Hello-World.git
        /// </summary>
        /// <example>git:github.com/octocat/Hello-World.git</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("git_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GitUrl { get; set; }

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/issues/comments{/number}
        /// </summary>
        /// <example>http://api.github.com/repos/octocat/Hello-World/issues/comments{/number}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("issue_comment_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IssueCommentUrl { get; set; }

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/issues/events{/number}
        /// </summary>
        /// <example>http://api.github.com/repos/octocat/Hello-World/issues/events{/number}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("issue_events_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IssueEventsUrl { get; set; }

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/issues{/number}
        /// </summary>
        /// <example>http://api.github.com/repos/octocat/Hello-World/issues{/number}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IssuesUrl { get; set; }

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/keys{/key_id}
        /// </summary>
        /// <example>http://api.github.com/repos/octocat/Hello-World/keys{/key_id}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("keys_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KeysUrl { get; set; }

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/labels{/name}
        /// </summary>
        /// <example>http://api.github.com/repos/octocat/Hello-World/labels{/name}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LabelsUrl { get; set; }

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/languages
        /// </summary>
        /// <example>http://api.github.com/repos/octocat/Hello-World/languages</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LanguagesUrl { get; set; }

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/merges
        /// </summary>
        /// <example>http://api.github.com/repos/octocat/Hello-World/merges</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("merges_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MergesUrl { get; set; }

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/milestones{/number}
        /// </summary>
        /// <example>http://api.github.com/repos/octocat/Hello-World/milestones{/number}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("milestones_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MilestonesUrl { get; set; }

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/notifications{?since,all,participating}
        /// </summary>
        /// <example>http://api.github.com/repos/octocat/Hello-World/notifications{?since,all,participating}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("notifications_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NotificationsUrl { get; set; }

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/pulls{/number}
        /// </summary>
        /// <example>http://api.github.com/repos/octocat/Hello-World/pulls{/number}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pulls_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PullsUrl { get; set; }

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/releases{/id}
        /// </summary>
        /// <example>http://api.github.com/repos/octocat/Hello-World/releases{/id}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("releases_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReleasesUrl { get; set; }

        /// <summary>
        /// Example: git@github.com:octocat/Hello-World.git
        /// </summary>
        /// <example>git@github.com:octocat/Hello-World.git</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ssh_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SshUrl { get; set; }

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/stargazers
        /// </summary>
        /// <example>http://api.github.com/repos/octocat/Hello-World/stargazers</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("stargazers_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StargazersUrl { get; set; }

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/statuses/{sha}
        /// </summary>
        /// <example>http://api.github.com/repos/octocat/Hello-World/statuses/{sha}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("statuses_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StatusesUrl { get; set; }

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/subscribers
        /// </summary>
        /// <example>http://api.github.com/repos/octocat/Hello-World/subscribers</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscribers_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SubscribersUrl { get; set; }

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/subscription
        /// </summary>
        /// <example>http://api.github.com/repos/octocat/Hello-World/subscription</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SubscriptionUrl { get; set; }

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/tags
        /// </summary>
        /// <example>http://api.github.com/repos/octocat/Hello-World/tags</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TagsUrl { get; set; }

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/teams
        /// </summary>
        /// <example>http://api.github.com/repos/octocat/Hello-World/teams</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("teams_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamsUrl { get; set; }

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/git/trees{/sha}
        /// </summary>
        /// <example>http://api.github.com/repos/octocat/Hello-World/git/trees{/sha}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("trees_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TreesUrl { get; set; }

        /// <summary>
        /// Example: https://github.com/octocat/Hello-World.git
        /// </summary>
        /// <example>https://github.com/octocat/Hello-World.git</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("clone_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CloneUrl { get; set; }

        /// <summary>
        /// Example: git:git.example.com/octocat/Hello-World
        /// </summary>
        /// <example>git:git.example.com/octocat/Hello-World</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mirror_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? MirrorUrl { get; set; }

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/hooks
        /// </summary>
        /// <example>http://api.github.com/repos/octocat/Hello-World/hooks</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("hooks_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HooksUrl { get; set; }

        /// <summary>
        /// Example: https://svn.github.com/octocat/Hello-World
        /// </summary>
        /// <example>https://svn.github.com/octocat/Hello-World</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("svn_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SvnUrl { get; set; }

        /// <summary>
        /// Example: https://github.com
        /// </summary>
        /// <example>https://github.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("homepage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Homepage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Language { get; set; }

        /// <summary>
        /// Example: 9
        /// </summary>
        /// <example>9</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("forks_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ForksCount { get; set; }

        /// <summary>
        /// Example: 80
        /// </summary>
        /// <example>80</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("stargazers_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StargazersCount { get; set; }

        /// <summary>
        /// Example: 80
        /// </summary>
        /// <example>80</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("watchers_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int WatchersCount { get; set; }

        /// <summary>
        /// The size of the repository, in kilobytes. Size is calculated hourly. When a repository is initially created, the size is 0.<br/>
        /// Example: 108
        /// </summary>
        /// <example>108</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Size { get; set; }

        /// <summary>
        /// Example: master
        /// </summary>
        /// <example>master</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_branch")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DefaultBranch { get; set; }

        /// <summary>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("open_issues_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OpenIssuesCount { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_template")]
        public bool? IsTemplate { get; set; }

        /// <summary>
        /// Example: [octocat, atom, electron, API]
        /// </summary>
        /// <example>[octocat, atom, electron, API]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("topics")]
        public global::System.Collections.Generic.IList<string>? Topics { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_issues")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasIssues { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_projects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasProjects { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_wiki")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasWiki { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_pages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasPages { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_downloads")]
        public bool? HasDownloads { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_discussions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasDiscussions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Archived { get; set; }

        /// <summary>
        /// Returns whether or not this repository disabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Disabled { get; set; }

        /// <summary>
        /// The repository visibility: public, private, or internal.<br/>
        /// Example: public
        /// </summary>
        /// <example>public</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        public string? Visibility { get; set; }

        /// <summary>
        /// Example: 2011-01-26T19:06:43Z
        /// </summary>
        /// <example>2011-01-26T19:06:43Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pushed_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime PushedAt { get; set; }

        /// <summary>
        /// Example: 2011-01-26T19:01:12Z
        /// </summary>
        /// <example>2011-01-26T19:01:12Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Example: 2011-01-26T19:14:43Z
        /// </summary>
        /// <example>2011-01-26T19:14:43Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        public global::G.FullRepositoryPermissions? Permissions { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_rebase_merge")]
        public bool? AllowRebaseMerge { get; set; }

        /// <summary>
        /// A repository on GitHub.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_repository")]
        public global::G.NullableRepository? TemplateRepository { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temp_clone_token")]
        public string? TempCloneToken { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_squash_merge")]
        public bool? AllowSquashMerge { get; set; }

        /// <summary>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_auto_merge")]
        public bool? AllowAutoMerge { get; set; }

        /// <summary>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("delete_branch_on_merge")]
        public bool? DeleteBranchOnMerge { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_merge_commit")]
        public bool? AllowMergeCommit { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_update_branch")]
        public bool? AllowUpdateBranch { get; set; }

        /// <summary>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_squash_pr_title_as_default")]
        public bool? UseSquashPrTitleAsDefault { get; set; }

        /// <summary>
        /// The default value for a squash merge commit title:<br/>
        /// - `PR_TITLE` - default to the pull request's title.<br/>
        /// - `COMMIT_OR_PR_TITLE` - default to the commit's title (if only one commit) or the pull request's title (when more than one commit).<br/>
        /// Example: PR_TITLE
        /// </summary>
        /// <example>PR_TITLE</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("squash_merge_commit_title")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FullRepositorySquashMergeCommitTitleJsonConverter))]
        public global::G.FullRepositorySquashMergeCommitTitle? SquashMergeCommitTitle { get; set; }

        /// <summary>
        /// The default value for a squash merge commit message:<br/>
        /// - `PR_BODY` - default to the pull request's body.<br/>
        /// - `COMMIT_MESSAGES` - default to the branch's commit messages.<br/>
        /// - `BLANK` - default to a blank commit message.<br/>
        /// Example: PR_BODY
        /// </summary>
        /// <example>PR_BODY</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("squash_merge_commit_message")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FullRepositorySquashMergeCommitMessageJsonConverter))]
        public global::G.FullRepositorySquashMergeCommitMessage? SquashMergeCommitMessage { get; set; }

        /// <summary>
        /// The default value for a merge commit title.<br/>
        ///   - `PR_TITLE` - default to the pull request's title.<br/>
        ///   - `MERGE_MESSAGE` - default to the classic title for a merge message (e.g., Merge pull request #123 from branch-name).<br/>
        /// Example: PR_TITLE
        /// </summary>
        /// <example>PR_TITLE</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("merge_commit_title")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FullRepositoryMergeCommitTitleJsonConverter))]
        public global::G.FullRepositoryMergeCommitTitle? MergeCommitTitle { get; set; }

        /// <summary>
        /// The default value for a merge commit message.<br/>
        /// - `PR_TITLE` - default to the pull request's title.<br/>
        /// - `PR_BODY` - default to the pull request's body.<br/>
        /// - `BLANK` - default to a blank commit message.<br/>
        /// Example: PR_BODY
        /// </summary>
        /// <example>PR_BODY</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("merge_commit_message")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FullRepositoryMergeCommitMessageJsonConverter))]
        public global::G.FullRepositoryMergeCommitMessage? MergeCommitMessage { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_forking")]
        public bool? AllowForking { get; set; }

        /// <summary>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("web_commit_signoff_required")]
        public bool? WebCommitSignoffRequired { get; set; }

        /// <summary>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscribers_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SubscribersCount { get; set; }

        /// <summary>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("network_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NetworkCount { get; set; }

        /// <summary>
        /// License Simple
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("license")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.NullableLicenseSimple? License { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        public global::G.NullableSimpleUser? Organization { get; set; }

        /// <summary>
        /// A repository on GitHub.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent")]
        public global::G.Repository? Parent { get; set; }

        /// <summary>
        /// A repository on GitHub.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public global::G.Repository? Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("forks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Forks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("master_branch")]
        public string? MasterBranch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("open_issues")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OpenIssues { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("watchers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Watchers { get; set; }

        /// <summary>
        /// Whether anonymous git access is allowed.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("anonymous_access_enabled")]
        public bool? AnonymousAccessEnabled { get; set; }

        /// <summary>
        /// Code of Conduct Simple
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_of_conduct")]
        public global::G.CodeOfConductSimple? CodeOfConduct { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_and_analysis")]
        public global::G.SecurityAndAnalysis? SecurityAndAnalysis { get; set; }

        /// <summary>
        /// The custom properties that were defined for the repository. The keys are the custom property names, and the values are the corresponding custom property values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_properties")]
        public object? CustomProperties { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FullRepository" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: 1296269
        /// </param>
        /// <param name="nodeId">
        /// Example: MDEwOlJlcG9zaXRvcnkxMjk2MjY5
        /// </param>
        /// <param name="name">
        /// Example: Hello-World
        /// </param>
        /// <param name="fullName">
        /// Example: octocat/Hello-World
        /// </param>
        /// <param name="owner">
        /// A GitHub user.
        /// </param>
        /// <param name="private"></param>
        /// <param name="htmlUrl">
        /// Example: https://github.com/octocat/Hello-World
        /// </param>
        /// <param name="description">
        /// Example: This your first repo!
        /// </param>
        /// <param name="fork"></param>
        /// <param name="url">
        /// Example: https://api.github.com/repos/octocat/Hello-World
        /// </param>
        /// <param name="archiveUrl">
        /// Example: http://api.github.com/repos/octocat/Hello-World/{archive_format}{/ref}
        /// </param>
        /// <param name="assigneesUrl">
        /// Example: http://api.github.com/repos/octocat/Hello-World/assignees{/user}
        /// </param>
        /// <param name="blobsUrl">
        /// Example: http://api.github.com/repos/octocat/Hello-World/git/blobs{/sha}
        /// </param>
        /// <param name="branchesUrl">
        /// Example: http://api.github.com/repos/octocat/Hello-World/branches{/branch}
        /// </param>
        /// <param name="collaboratorsUrl">
        /// Example: http://api.github.com/repos/octocat/Hello-World/collaborators{/collaborator}
        /// </param>
        /// <param name="commentsUrl">
        /// Example: http://api.github.com/repos/octocat/Hello-World/comments{/number}
        /// </param>
        /// <param name="commitsUrl">
        /// Example: http://api.github.com/repos/octocat/Hello-World/commits{/sha}
        /// </param>
        /// <param name="compareUrl">
        /// Example: http://api.github.com/repos/octocat/Hello-World/compare/{base}...{head}
        /// </param>
        /// <param name="contentsUrl">
        /// Example: http://api.github.com/repos/octocat/Hello-World/contents/{+path}
        /// </param>
        /// <param name="contributorsUrl">
        /// Example: http://api.github.com/repos/octocat/Hello-World/contributors
        /// </param>
        /// <param name="deploymentsUrl">
        /// Example: http://api.github.com/repos/octocat/Hello-World/deployments
        /// </param>
        /// <param name="downloadsUrl">
        /// Example: http://api.github.com/repos/octocat/Hello-World/downloads
        /// </param>
        /// <param name="eventsUrl">
        /// Example: http://api.github.com/repos/octocat/Hello-World/events
        /// </param>
        /// <param name="forksUrl">
        /// Example: http://api.github.com/repos/octocat/Hello-World/forks
        /// </param>
        /// <param name="gitCommitsUrl">
        /// Example: http://api.github.com/repos/octocat/Hello-World/git/commits{/sha}
        /// </param>
        /// <param name="gitRefsUrl">
        /// Example: http://api.github.com/repos/octocat/Hello-World/git/refs{/sha}
        /// </param>
        /// <param name="gitTagsUrl">
        /// Example: http://api.github.com/repos/octocat/Hello-World/git/tags{/sha}
        /// </param>
        /// <param name="gitUrl">
        /// Example: git:github.com/octocat/Hello-World.git
        /// </param>
        /// <param name="issueCommentUrl">
        /// Example: http://api.github.com/repos/octocat/Hello-World/issues/comments{/number}
        /// </param>
        /// <param name="issueEventsUrl">
        /// Example: http://api.github.com/repos/octocat/Hello-World/issues/events{/number}
        /// </param>
        /// <param name="issuesUrl">
        /// Example: http://api.github.com/repos/octocat/Hello-World/issues{/number}
        /// </param>
        /// <param name="keysUrl">
        /// Example: http://api.github.com/repos/octocat/Hello-World/keys{/key_id}
        /// </param>
        /// <param name="labelsUrl">
        /// Example: http://api.github.com/repos/octocat/Hello-World/labels{/name}
        /// </param>
        /// <param name="languagesUrl">
        /// Example: http://api.github.com/repos/octocat/Hello-World/languages
        /// </param>
        /// <param name="mergesUrl">
        /// Example: http://api.github.com/repos/octocat/Hello-World/merges
        /// </param>
        /// <param name="milestonesUrl">
        /// Example: http://api.github.com/repos/octocat/Hello-World/milestones{/number}
        /// </param>
        /// <param name="notificationsUrl">
        /// Example: http://api.github.com/repos/octocat/Hello-World/notifications{?since,all,participating}
        /// </param>
        /// <param name="pullsUrl">
        /// Example: http://api.github.com/repos/octocat/Hello-World/pulls{/number}
        /// </param>
        /// <param name="releasesUrl">
        /// Example: http://api.github.com/repos/octocat/Hello-World/releases{/id}
        /// </param>
        /// <param name="sshUrl">
        /// Example: git@github.com:octocat/Hello-World.git
        /// </param>
        /// <param name="stargazersUrl">
        /// Example: http://api.github.com/repos/octocat/Hello-World/stargazers
        /// </param>
        /// <param name="statusesUrl">
        /// Example: http://api.github.com/repos/octocat/Hello-World/statuses/{sha}
        /// </param>
        /// <param name="subscribersUrl">
        /// Example: http://api.github.com/repos/octocat/Hello-World/subscribers
        /// </param>
        /// <param name="subscriptionUrl">
        /// Example: http://api.github.com/repos/octocat/Hello-World/subscription
        /// </param>
        /// <param name="tagsUrl">
        /// Example: http://api.github.com/repos/octocat/Hello-World/tags
        /// </param>
        /// <param name="teamsUrl">
        /// Example: http://api.github.com/repos/octocat/Hello-World/teams
        /// </param>
        /// <param name="treesUrl">
        /// Example: http://api.github.com/repos/octocat/Hello-World/git/trees{/sha}
        /// </param>
        /// <param name="cloneUrl">
        /// Example: https://github.com/octocat/Hello-World.git
        /// </param>
        /// <param name="mirrorUrl">
        /// Example: git:git.example.com/octocat/Hello-World
        /// </param>
        /// <param name="hooksUrl">
        /// Example: http://api.github.com/repos/octocat/Hello-World/hooks
        /// </param>
        /// <param name="svnUrl">
        /// Example: https://svn.github.com/octocat/Hello-World
        /// </param>
        /// <param name="homepage">
        /// Example: https://github.com
        /// </param>
        /// <param name="language"></param>
        /// <param name="forksCount">
        /// Example: 9
        /// </param>
        /// <param name="stargazersCount">
        /// Example: 80
        /// </param>
        /// <param name="watchersCount">
        /// Example: 80
        /// </param>
        /// <param name="size">
        /// The size of the repository, in kilobytes. Size is calculated hourly. When a repository is initially created, the size is 0.<br/>
        /// Example: 108
        /// </param>
        /// <param name="defaultBranch">
        /// Example: master
        /// </param>
        /// <param name="openIssuesCount">
        /// Example: 0
        /// </param>
        /// <param name="isTemplate">
        /// Example: true
        /// </param>
        /// <param name="topics">
        /// Example: [octocat, atom, electron, API]
        /// </param>
        /// <param name="hasIssues">
        /// Example: true
        /// </param>
        /// <param name="hasProjects">
        /// Example: true
        /// </param>
        /// <param name="hasWiki">
        /// Example: true
        /// </param>
        /// <param name="hasPages"></param>
        /// <param name="hasDownloads">
        /// Example: true
        /// </param>
        /// <param name="hasDiscussions">
        /// Example: true
        /// </param>
        /// <param name="archived"></param>
        /// <param name="disabled">
        /// Returns whether or not this repository disabled.
        /// </param>
        /// <param name="visibility">
        /// The repository visibility: public, private, or internal.<br/>
        /// Example: public
        /// </param>
        /// <param name="pushedAt">
        /// Example: 2011-01-26T19:06:43Z
        /// </param>
        /// <param name="createdAt">
        /// Example: 2011-01-26T19:01:12Z
        /// </param>
        /// <param name="updatedAt">
        /// Example: 2011-01-26T19:14:43Z
        /// </param>
        /// <param name="permissions"></param>
        /// <param name="allowRebaseMerge">
        /// Example: true
        /// </param>
        /// <param name="templateRepository">
        /// A repository on GitHub.
        /// </param>
        /// <param name="tempCloneToken"></param>
        /// <param name="allowSquashMerge">
        /// Example: true
        /// </param>
        /// <param name="allowAutoMerge">
        /// Example: false
        /// </param>
        /// <param name="deleteBranchOnMerge">
        /// Example: false
        /// </param>
        /// <param name="allowMergeCommit">
        /// Example: true
        /// </param>
        /// <param name="allowUpdateBranch">
        /// Example: true
        /// </param>
        /// <param name="useSquashPrTitleAsDefault">
        /// Example: false
        /// </param>
        /// <param name="squashMergeCommitTitle">
        /// The default value for a squash merge commit title:<br/>
        /// - `PR_TITLE` - default to the pull request's title.<br/>
        /// - `COMMIT_OR_PR_TITLE` - default to the commit's title (if only one commit) or the pull request's title (when more than one commit).<br/>
        /// Example: PR_TITLE
        /// </param>
        /// <param name="squashMergeCommitMessage">
        /// The default value for a squash merge commit message:<br/>
        /// - `PR_BODY` - default to the pull request's body.<br/>
        /// - `COMMIT_MESSAGES` - default to the branch's commit messages.<br/>
        /// - `BLANK` - default to a blank commit message.<br/>
        /// Example: PR_BODY
        /// </param>
        /// <param name="mergeCommitTitle">
        /// The default value for a merge commit title.<br/>
        ///   - `PR_TITLE` - default to the pull request's title.<br/>
        ///   - `MERGE_MESSAGE` - default to the classic title for a merge message (e.g., Merge pull request #123 from branch-name).<br/>
        /// Example: PR_TITLE
        /// </param>
        /// <param name="mergeCommitMessage">
        /// The default value for a merge commit message.<br/>
        /// - `PR_TITLE` - default to the pull request's title.<br/>
        /// - `PR_BODY` - default to the pull request's body.<br/>
        /// - `BLANK` - default to a blank commit message.<br/>
        /// Example: PR_BODY
        /// </param>
        /// <param name="allowForking">
        /// Example: true
        /// </param>
        /// <param name="webCommitSignoffRequired">
        /// Example: false
        /// </param>
        /// <param name="subscribersCount">
        /// Example: 42
        /// </param>
        /// <param name="networkCount">
        /// Example: 0
        /// </param>
        /// <param name="license">
        /// License Simple
        /// </param>
        /// <param name="organization">
        /// A GitHub user.
        /// </param>
        /// <param name="parent">
        /// A repository on GitHub.
        /// </param>
        /// <param name="source">
        /// A repository on GitHub.
        /// </param>
        /// <param name="forks"></param>
        /// <param name="masterBranch"></param>
        /// <param name="openIssues"></param>
        /// <param name="watchers"></param>
        /// <param name="anonymousAccessEnabled">
        /// Whether anonymous git access is allowed.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="codeOfConduct">
        /// Code of Conduct Simple
        /// </param>
        /// <param name="securityAndAnalysis"></param>
        /// <param name="customProperties">
        /// The custom properties that were defined for the repository. The keys are the custom property names, and the values are the corresponding custom property values.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FullRepository(
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
            string gitUrl,
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
            string sshUrl,
            string stargazersUrl,
            string statusesUrl,
            string subscribersUrl,
            string subscriptionUrl,
            string tagsUrl,
            string teamsUrl,
            string treesUrl,
            string cloneUrl,
            string? mirrorUrl,
            string hooksUrl,
            string svnUrl,
            string? homepage,
            string? language,
            int forksCount,
            int stargazersCount,
            int watchersCount,
            int size,
            string defaultBranch,
            int openIssuesCount,
            bool hasIssues,
            bool hasProjects,
            bool hasWiki,
            bool hasPages,
            bool hasDiscussions,
            bool archived,
            bool disabled,
            global::System.DateTime pushedAt,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            int subscribersCount,
            int networkCount,
            global::G.NullableLicenseSimple? license,
            int forks,
            int openIssues,
            int watchers,
            bool? isTemplate,
            global::System.Collections.Generic.IList<string>? topics,
            bool? hasDownloads,
            string? visibility,
            global::G.FullRepositoryPermissions? permissions,
            bool? allowRebaseMerge,
            global::G.NullableRepository? templateRepository,
            string? tempCloneToken,
            bool? allowSquashMerge,
            bool? allowAutoMerge,
            bool? deleteBranchOnMerge,
            bool? allowMergeCommit,
            bool? allowUpdateBranch,
            bool? useSquashPrTitleAsDefault,
            global::G.FullRepositorySquashMergeCommitTitle? squashMergeCommitTitle,
            global::G.FullRepositorySquashMergeCommitMessage? squashMergeCommitMessage,
            global::G.FullRepositoryMergeCommitTitle? mergeCommitTitle,
            global::G.FullRepositoryMergeCommitMessage? mergeCommitMessage,
            bool? allowForking,
            bool? webCommitSignoffRequired,
            global::G.NullableSimpleUser? organization,
            global::G.Repository? parent,
            global::G.Repository? source,
            string? masterBranch,
            bool? anonymousAccessEnabled,
            global::G.CodeOfConductSimple? codeOfConduct,
            global::G.SecurityAndAnalysis? securityAndAnalysis,
            object? customProperties)
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
            this.GitUrl = gitUrl ?? throw new global::System.ArgumentNullException(nameof(gitUrl));
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
            this.SshUrl = sshUrl ?? throw new global::System.ArgumentNullException(nameof(sshUrl));
            this.StargazersUrl = stargazersUrl ?? throw new global::System.ArgumentNullException(nameof(stargazersUrl));
            this.StatusesUrl = statusesUrl ?? throw new global::System.ArgumentNullException(nameof(statusesUrl));
            this.SubscribersUrl = subscribersUrl ?? throw new global::System.ArgumentNullException(nameof(subscribersUrl));
            this.SubscriptionUrl = subscriptionUrl ?? throw new global::System.ArgumentNullException(nameof(subscriptionUrl));
            this.TagsUrl = tagsUrl ?? throw new global::System.ArgumentNullException(nameof(tagsUrl));
            this.TeamsUrl = teamsUrl ?? throw new global::System.ArgumentNullException(nameof(teamsUrl));
            this.TreesUrl = treesUrl ?? throw new global::System.ArgumentNullException(nameof(treesUrl));
            this.CloneUrl = cloneUrl ?? throw new global::System.ArgumentNullException(nameof(cloneUrl));
            this.MirrorUrl = mirrorUrl ?? throw new global::System.ArgumentNullException(nameof(mirrorUrl));
            this.HooksUrl = hooksUrl ?? throw new global::System.ArgumentNullException(nameof(hooksUrl));
            this.SvnUrl = svnUrl ?? throw new global::System.ArgumentNullException(nameof(svnUrl));
            this.Homepage = homepage ?? throw new global::System.ArgumentNullException(nameof(homepage));
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.ForksCount = forksCount;
            this.StargazersCount = stargazersCount;
            this.WatchersCount = watchersCount;
            this.Size = size;
            this.DefaultBranch = defaultBranch ?? throw new global::System.ArgumentNullException(nameof(defaultBranch));
            this.OpenIssuesCount = openIssuesCount;
            this.HasIssues = hasIssues;
            this.HasProjects = hasProjects;
            this.HasWiki = hasWiki;
            this.HasPages = hasPages;
            this.HasDiscussions = hasDiscussions;
            this.Archived = archived;
            this.Disabled = disabled;
            this.PushedAt = pushedAt;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.SubscribersCount = subscribersCount;
            this.NetworkCount = networkCount;
            this.License = license ?? throw new global::System.ArgumentNullException(nameof(license));
            this.Forks = forks;
            this.OpenIssues = openIssues;
            this.Watchers = watchers;
            this.IsTemplate = isTemplate;
            this.Topics = topics;
            this.HasDownloads = hasDownloads;
            this.Visibility = visibility;
            this.Permissions = permissions;
            this.AllowRebaseMerge = allowRebaseMerge;
            this.TemplateRepository = templateRepository;
            this.TempCloneToken = tempCloneToken;
            this.AllowSquashMerge = allowSquashMerge;
            this.AllowAutoMerge = allowAutoMerge;
            this.DeleteBranchOnMerge = deleteBranchOnMerge;
            this.AllowMergeCommit = allowMergeCommit;
            this.AllowUpdateBranch = allowUpdateBranch;
            this.UseSquashPrTitleAsDefault = useSquashPrTitleAsDefault;
            this.SquashMergeCommitTitle = squashMergeCommitTitle;
            this.SquashMergeCommitMessage = squashMergeCommitMessage;
            this.MergeCommitTitle = mergeCommitTitle;
            this.MergeCommitMessage = mergeCommitMessage;
            this.AllowForking = allowForking;
            this.WebCommitSignoffRequired = webCommitSignoffRequired;
            this.Organization = organization;
            this.Parent = parent;
            this.Source = source;
            this.MasterBranch = masterBranch;
            this.AnonymousAccessEnabled = anonymousAccessEnabled;
            this.CodeOfConduct = codeOfConduct;
            this.SecurityAndAnalysis = securityAndAnalysis;
            this.CustomProperties = customProperties;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FullRepository" /> class.
        /// </summary>
        public FullRepository()
        {
        }
    }
}
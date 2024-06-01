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
        /// <br/>Example: 1296269
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// <br/>Example: MDEwOlJlcG9zaXRvcnkxMjk2MjY5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// <br/>Example: Hello-World
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// <br/>Example: octocat/Hello-World
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("full_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FullName { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required SimpleUser Owner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Private { get; set; }

        /// <summary>
        /// <br/>Example: https://github.com/octocat/Hello-World
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// <br/>Example: This your first repo!
        /// </summary>
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
        /// <br/>Example: https://api.github.com/repos/octocat/Hello-World
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// <br/>Example: http://api.github.com/repos/octocat/Hello-World/{archive_format}{/ref}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archive_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ArchiveUrl { get; set; }

        /// <summary>
        /// <br/>Example: http://api.github.com/repos/octocat/Hello-World/assignees{/user}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignees_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AssigneesUrl { get; set; }

        /// <summary>
        /// <br/>Example: http://api.github.com/repos/octocat/Hello-World/git/blobs{/sha}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blobs_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BlobsUrl { get; set; }

        /// <summary>
        /// <br/>Example: http://api.github.com/repos/octocat/Hello-World/branches{/branch}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branches_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BranchesUrl { get; set; }

        /// <summary>
        /// <br/>Example: http://api.github.com/repos/octocat/Hello-World/collaborators{/collaborator}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collaborators_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CollaboratorsUrl { get; set; }

        /// <summary>
        /// <br/>Example: http://api.github.com/repos/octocat/Hello-World/comments{/number}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comments_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CommentsUrl { get; set; }

        /// <summary>
        /// <br/>Example: http://api.github.com/repos/octocat/Hello-World/commits{/sha}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commits_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CommitsUrl { get; set; }

        /// <summary>
        /// <br/>Example: http://api.github.com/repos/octocat/Hello-World/compare/{base}...{head}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compare_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CompareUrl { get; set; }

        /// <summary>
        /// <br/>Example: http://api.github.com/repos/octocat/Hello-World/contents/{+path}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contents_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentsUrl { get; set; }

        /// <summary>
        /// <br/>Example: http://api.github.com/repos/octocat/Hello-World/contributors
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contributors_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContributorsUrl { get; set; }

        /// <summary>
        /// <br/>Example: http://api.github.com/repos/octocat/Hello-World/deployments
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployments_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeploymentsUrl { get; set; }

        /// <summary>
        /// <br/>Example: http://api.github.com/repos/octocat/Hello-World/downloads
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("downloads_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DownloadsUrl { get; set; }

        /// <summary>
        /// <br/>Example: http://api.github.com/repos/octocat/Hello-World/events
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventsUrl { get; set; }

        /// <summary>
        /// <br/>Example: http://api.github.com/repos/octocat/Hello-World/forks
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("forks_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ForksUrl { get; set; }

        /// <summary>
        /// <br/>Example: http://api.github.com/repos/octocat/Hello-World/git/commits{/sha}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("git_commits_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GitCommitsUrl { get; set; }

        /// <summary>
        /// <br/>Example: http://api.github.com/repos/octocat/Hello-World/git/refs{/sha}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("git_refs_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GitRefsUrl { get; set; }

        /// <summary>
        /// <br/>Example: http://api.github.com/repos/octocat/Hello-World/git/tags{/sha}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("git_tags_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GitTagsUrl { get; set; }

        /// <summary>
        /// <br/>Example: git:github.com/octocat/Hello-World.git
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("git_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GitUrl { get; set; }

        /// <summary>
        /// <br/>Example: http://api.github.com/repos/octocat/Hello-World/issues/comments{/number}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issue_comment_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IssueCommentUrl { get; set; }

        /// <summary>
        /// <br/>Example: http://api.github.com/repos/octocat/Hello-World/issues/events{/number}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issue_events_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IssueEventsUrl { get; set; }

        /// <summary>
        /// <br/>Example: http://api.github.com/repos/octocat/Hello-World/issues{/number}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IssuesUrl { get; set; }

        /// <summary>
        /// <br/>Example: http://api.github.com/repos/octocat/Hello-World/keys{/key_id}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keys_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KeysUrl { get; set; }

        /// <summary>
        /// <br/>Example: http://api.github.com/repos/octocat/Hello-World/labels{/name}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LabelsUrl { get; set; }

        /// <summary>
        /// <br/>Example: http://api.github.com/repos/octocat/Hello-World/languages
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LanguagesUrl { get; set; }

        /// <summary>
        /// <br/>Example: http://api.github.com/repos/octocat/Hello-World/merges
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merges_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MergesUrl { get; set; }

        /// <summary>
        /// <br/>Example: http://api.github.com/repos/octocat/Hello-World/milestones{/number}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("milestones_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MilestonesUrl { get; set; }

        /// <summary>
        /// <br/>Example: http://api.github.com/repos/octocat/Hello-World/notifications{?since,all,participating}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notifications_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NotificationsUrl { get; set; }

        /// <summary>
        /// <br/>Example: http://api.github.com/repos/octocat/Hello-World/pulls{/number}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pulls_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PullsUrl { get; set; }

        /// <summary>
        /// <br/>Example: http://api.github.com/repos/octocat/Hello-World/releases{/id}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("releases_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReleasesUrl { get; set; }

        /// <summary>
        /// <br/>Example: git@github.com:octocat/Hello-World.git
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ssh_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SshUrl { get; set; }

        /// <summary>
        /// <br/>Example: http://api.github.com/repos/octocat/Hello-World/stargazers
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stargazers_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StargazersUrl { get; set; }

        /// <summary>
        /// <br/>Example: http://api.github.com/repos/octocat/Hello-World/statuses/{sha}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statuses_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StatusesUrl { get; set; }

        /// <summary>
        /// <br/>Example: http://api.github.com/repos/octocat/Hello-World/subscribers
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscribers_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SubscribersUrl { get; set; }

        /// <summary>
        /// <br/>Example: http://api.github.com/repos/octocat/Hello-World/subscription
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SubscriptionUrl { get; set; }

        /// <summary>
        /// <br/>Example: http://api.github.com/repos/octocat/Hello-World/tags
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TagsUrl { get; set; }

        /// <summary>
        /// <br/>Example: http://api.github.com/repos/octocat/Hello-World/teams
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teams_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamsUrl { get; set; }

        /// <summary>
        /// <br/>Example: http://api.github.com/repos/octocat/Hello-World/git/trees{/sha}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trees_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TreesUrl { get; set; }

        /// <summary>
        /// <br/>Example: https://github.com/octocat/Hello-World.git
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clone_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CloneUrl { get; set; }

        /// <summary>
        /// <br/>Example: git:git.example.com/octocat/Hello-World
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mirror_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? MirrorUrl { get; set; }

        /// <summary>
        /// <br/>Example: http://api.github.com/repos/octocat/Hello-World/hooks
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hooks_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HooksUrl { get; set; }

        /// <summary>
        /// <br/>Example: https://svn.github.com/octocat/Hello-World
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("svn_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SvnUrl { get; set; }

        /// <summary>
        /// <br/>Example: https://github.com
        /// </summary>
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
        /// <br/>Example: 9
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("forks_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ForksCount { get; set; }

        /// <summary>
        /// <br/>Example: 80
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stargazers_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StargazersCount { get; set; }

        /// <summary>
        /// <br/>Example: 80
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("watchers_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int WatchersCount { get; set; }

        /// <summary>
        /// The size of the repository, in kilobytes. Size is calculated hourly. When a repository is initially created, the size is 0.
        /// <br/>Example: 108
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Size { get; set; }

        /// <summary>
        /// <br/>Example: master
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_branch")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DefaultBranch { get; set; }

        /// <summary>
        /// <br/>Example: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("open_issues_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OpenIssuesCount { get; set; }

        /// <summary>
        /// <br/>Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_template")]
        public bool IsTemplate { get; set; }

        /// <summary>
        /// <br/>Example: [octocat, atom, electron, API]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topics")]
        public global::System.Collections.Generic.IList<string?>? Topics { get; set; }

        /// <summary>
        /// <br/>Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_issues")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasIssues { get; set; }

        /// <summary>
        /// <br/>Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_projects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasProjects { get; set; }

        /// <summary>
        /// <br/>Example: true
        /// </summary>
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
        /// <br/>Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_downloads")]
        public bool HasDownloads { get; set; }

        /// <summary>
        /// <br/>Example: true
        /// </summary>
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
        /// The repository visibility: public, private, or internal.
        /// <br/>Example: public
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        public string? Visibility { get; set; }

        /// <summary>
        /// <br/>Example: 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pushed_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime PushedAt { get; set; }

        /// <summary>
        /// <br/>Example: 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// <br/>Example: 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        public FullRepositoryPermissions? Permissions { get; set; }

        /// <summary>
        /// <br/>Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_rebase_merge")]
        public bool AllowRebaseMerge { get; set; }

        /// <summary>
        /// A repository on GitHub.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_repository")]
        public NullableRepository? TemplateRepository { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temp_clone_token")]
        public string? TempCloneToken { get; set; }

        /// <summary>
        /// <br/>Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_squash_merge")]
        public bool AllowSquashMerge { get; set; }

        /// <summary>
        /// <br/>Example: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_auto_merge")]
        public bool AllowAutoMerge { get; set; }

        /// <summary>
        /// <br/>Example: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delete_branch_on_merge")]
        public bool DeleteBranchOnMerge { get; set; }

        /// <summary>
        /// <br/>Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_merge_commit")]
        public bool AllowMergeCommit { get; set; }

        /// <summary>
        /// <br/>Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_update_branch")]
        public bool AllowUpdateBranch { get; set; }

        /// <summary>
        /// <br/>Example: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_squash_pr_title_as_default")]
        public bool UseSquashPrTitleAsDefault { get; set; }

        /// <summary>
        /// The default value for a squash merge commit title:
        /// - `PR_TITLE` - default to the pull request's title.
        /// - `COMMIT_OR_PR_TITLE` - default to the commit's title (if only one commit) or the pull request's title (when more than one commit).
        /// <br/>Example: PR_TITLE
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("squash_merge_commit_title")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.FullRepositorySquashMergeCommitTitleJsonConverter))]
        public FullRepositorySquashMergeCommitTitle? SquashMergeCommitTitle { get; set; }

        /// <summary>
        /// The default value for a squash merge commit message:
        /// - `PR_BODY` - default to the pull request's body.
        /// - `COMMIT_MESSAGES` - default to the branch's commit messages.
        /// - `BLANK` - default to a blank commit message.
        /// <br/>Example: PR_BODY
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("squash_merge_commit_message")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.FullRepositorySquashMergeCommitMessageJsonConverter))]
        public FullRepositorySquashMergeCommitMessage? SquashMergeCommitMessage { get; set; }

        /// <summary>
        /// The default value for a merge commit title.
        ///   - `PR_TITLE` - default to the pull request's title.
        ///   - `MERGE_MESSAGE` - default to the classic title for a merge message (e.g., Merge pull request #123 from branch-name).
        /// <br/>Example: PR_TITLE
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merge_commit_title")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.FullRepositoryMergeCommitTitleJsonConverter))]
        public FullRepositoryMergeCommitTitle? MergeCommitTitle { get; set; }

        /// <summary>
        /// The default value for a merge commit message.
        /// - `PR_TITLE` - default to the pull request's title.
        /// - `PR_BODY` - default to the pull request's body.
        /// - `BLANK` - default to a blank commit message.
        /// <br/>Example: PR_BODY
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merge_commit_message")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.FullRepositoryMergeCommitMessageJsonConverter))]
        public FullRepositoryMergeCommitMessage? MergeCommitMessage { get; set; }

        /// <summary>
        /// <br/>Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_forking")]
        public bool AllowForking { get; set; }

        /// <summary>
        /// <br/>Example: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("web_commit_signoff_required")]
        public bool WebCommitSignoffRequired { get; set; }

        /// <summary>
        /// <br/>Example: 42
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscribers_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SubscribersCount { get; set; }

        /// <summary>
        /// <br/>Example: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("network_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NetworkCount { get; set; }

        /// <summary>
        /// License Simple
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("license")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required NullableLicenseSimple? License { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        public NullableSimpleUser? Organization { get; set; }

        /// <summary>
        /// A repository on GitHub.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent")]
        public Repository? Parent { get; set; }

        /// <summary>
        /// A repository on GitHub.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public Repository? Source { get; set; }

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
        /// Whether anonymous git access is allowed.
        /// <br/>Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("anonymous_access_enabled")]
        public bool AnonymousAccessEnabled { get; set; } = true;

        /// <summary>
        /// Code of Conduct Simple
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_of_conduct")]
        public CodeOfConductSimple? CodeOfConduct { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_and_analysis")]
        public SecurityAndAnalysis? SecurityAndAnalysis { get; set; }

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
    }
}
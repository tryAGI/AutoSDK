//HintName: G.Models.WebhookPullRequestEnqueuedPullRequestBaseRepo.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A git repository
    /// </summary>
    public sealed partial class WebhookPullRequestEnqueuedPullRequestBaseRepo
    {
        /// <summary>
        /// Whether to allow auto-merge for pull requests.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_auto_merge")]
        public bool? AllowAutoMerge { get; set; }

        /// <summary>
        /// Whether to allow private forks
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_forking")]
        public bool? AllowForking { get; set; }

        /// <summary>
        /// Whether to allow merge commits for pull requests.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_merge_commit")]
        public bool? AllowMergeCommit { get; set; }

        /// <summary>
        /// Whether to allow rebase merges for pull requests.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_rebase_merge")]
        public bool? AllowRebaseMerge { get; set; }

        /// <summary>
        /// Whether to allow squash merges for pull requests.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_squash_merge")]
        public bool? AllowSquashMerge { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_update_branch")]
        public bool? AllowUpdateBranch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archive_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ArchiveUrl { get; set; }

        /// <summary>
        /// Whether the repository is archived.<br/>
        /// Default Value: false
        /// </summary>
        /// <default>false</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Archived { get; set; } = false;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignees_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AssigneesUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blobs_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BlobsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branches_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BranchesUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clone_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CloneUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collaborators_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CollaboratorsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comments_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CommentsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commits_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CommitsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compare_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CompareUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contents_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contributors_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContributorsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<int?, global::System.DateTime?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<int?, global::System.DateTime?> CreatedAt { get; set; }

        /// <summary>
        /// The default branch of the repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_branch")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DefaultBranch { get; set; }

        /// <summary>
        /// Whether to delete head branches when pull requests are merged<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delete_branch_on_merge")]
        public bool? DeleteBranchOnMerge { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployments_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeploymentsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Description { get; set; }

        /// <summary>
        /// Returns whether or not this repository is disabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled")]
        public bool? Disabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("downloads_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DownloadsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fork")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Fork { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("forks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Forks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("forks_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ForksCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("forks_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ForksUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("full_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FullName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("git_commits_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GitCommitsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("git_refs_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GitRefsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("git_tags_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GitTagsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("git_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GitUrl { get; set; }

        /// <summary>
        /// Whether downloads are enabled.<br/>
        /// Default Value: true
        /// </summary>
        /// <default>true</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_downloads")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasDownloads { get; set; } = true;

        /// <summary>
        /// Whether issues are enabled.<br/>
        /// Default Value: true
        /// </summary>
        /// <default>true</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_issues")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasIssues { get; set; } = true;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_pages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasPages { get; set; }

        /// <summary>
        /// Whether projects are enabled.<br/>
        /// Default Value: true
        /// </summary>
        /// <default>true</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_projects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasProjects { get; set; } = true;

        /// <summary>
        /// Whether the wiki is enabled.<br/>
        /// Default Value: true
        /// </summary>
        /// <default>true</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_wiki")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasWiki { get; set; } = true;

        /// <summary>
        /// Whether discussions are enabled.<br/>
        /// Default Value: false
        /// </summary>
        /// <default>false</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_discussions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasDiscussions { get; set; } = false;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("homepage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Homepage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hooks_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HooksUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// Unique identifier of the repository
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_template")]
        public bool? IsTemplate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issue_comment_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IssueCommentUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issue_events_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IssueEventsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IssuesUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keys_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KeysUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LabelsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LanguagesUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("license")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookPullRequestEnqueuedPullRequestBaseRepoLicense? License { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("master_branch")]
        public string? MasterBranch { get; set; }

        /// <summary>
        /// The default value for a merge commit message.<br/>
        /// - `PR_TITLE` - default to the pull request's title.<br/>
        /// - `PR_BODY` - default to the pull request's body.<br/>
        /// - `BLANK` - default to a blank commit message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merge_commit_message")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookPullRequestEnqueuedPullRequestBaseRepoMergeCommitMessageJsonConverter))]
        public global::G.WebhookPullRequestEnqueuedPullRequestBaseRepoMergeCommitMessage? MergeCommitMessage { get; set; }

        /// <summary>
        /// The default value for a merge commit title.<br/>
        /// - `PR_TITLE` - default to the pull request's title.<br/>
        /// - `MERGE_MESSAGE` - default to the classic title for a merge message (e.g., Merge pull request #123 from branch-name).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merge_commit_title")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookPullRequestEnqueuedPullRequestBaseRepoMergeCommitTitleJsonConverter))]
        public global::G.WebhookPullRequestEnqueuedPullRequestBaseRepoMergeCommitTitle? MergeCommitTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merges_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MergesUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("milestones_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MilestonesUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mirror_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? MirrorUrl { get; set; }

        /// <summary>
        /// The name of the repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notifications_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NotificationsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("open_issues")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OpenIssues { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("open_issues_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OpenIssuesCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        public string? Organization { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookPullRequestEnqueuedPullRequestBaseRepoOwner? Owner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        public global::G.WebhookPullRequestEnqueuedPullRequestBaseRepoPermissions? Permissions { get; set; }

        /// <summary>
        /// Whether the repository is private or public.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Private { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public")]
        public bool? Public { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pulls_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PullsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pushed_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<int?, global::System.DateTime?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<int?, global::System.DateTime?>? PushedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("releases_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReleasesUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_name")]
        public string? RoleName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Size { get; set; }

        /// <summary>
        /// The default value for a squash merge commit message:<br/>
        /// - `PR_BODY` - default to the pull request's body.<br/>
        /// - `COMMIT_MESSAGES` - default to the branch's commit messages.<br/>
        /// - `BLANK` - default to a blank commit message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("squash_merge_commit_message")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookPullRequestEnqueuedPullRequestBaseRepoSquashMergeCommitMessageJsonConverter))]
        public global::G.WebhookPullRequestEnqueuedPullRequestBaseRepoSquashMergeCommitMessage? SquashMergeCommitMessage { get; set; }

        /// <summary>
        /// The default value for a squash merge commit title:<br/>
        /// - `PR_TITLE` - default to the pull request's title.<br/>
        /// - `COMMIT_OR_PR_TITLE` - default to the commit's title (if only one commit) or the pull request's title (when more than one commit).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("squash_merge_commit_title")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookPullRequestEnqueuedPullRequestBaseRepoSquashMergeCommitTitleJsonConverter))]
        public global::G.WebhookPullRequestEnqueuedPullRequestBaseRepoSquashMergeCommitTitle? SquashMergeCommitTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ssh_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SshUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stargazers")]
        public int? Stargazers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stargazers_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StargazersCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stargazers_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StargazersUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statuses_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StatusesUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscribers_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SubscribersUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SubscriptionUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("svn_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SvnUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TagsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teams_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topics")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Topics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trees_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TreesUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Whether a squash merge commit can use the pull request title as default. **This property has been deprecated. Please use `squash_merge_commit_title` instead.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_squash_pr_title_as_default")]
        public bool? UseSquashPrTitleAsDefault { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookPullRequestEnqueuedPullRequestBaseRepoVisibilityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookPullRequestEnqueuedPullRequestBaseRepoVisibility Visibility { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("watchers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Watchers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("watchers_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int WatchersCount { get; set; }

        /// <summary>
        /// Whether to require contributors to sign off on web-based commits
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("web_commit_signoff_required")]
        public bool? WebCommitSignoffRequired { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestEnqueuedPullRequestBaseRepo" /> class.
        /// </summary>
        /// <param name="allowAutoMerge">
        /// Whether to allow auto-merge for pull requests.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="allowForking">
        /// Whether to allow private forks
        /// </param>
        /// <param name="allowMergeCommit">
        /// Whether to allow merge commits for pull requests.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="allowRebaseMerge">
        /// Whether to allow rebase merges for pull requests.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="allowSquashMerge">
        /// Whether to allow squash merges for pull requests.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="allowUpdateBranch"></param>
        /// <param name="archiveUrl"></param>
        /// <param name="archived">
        /// Whether the repository is archived.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="assigneesUrl"></param>
        /// <param name="blobsUrl"></param>
        /// <param name="branchesUrl"></param>
        /// <param name="cloneUrl"></param>
        /// <param name="collaboratorsUrl"></param>
        /// <param name="commentsUrl"></param>
        /// <param name="commitsUrl"></param>
        /// <param name="compareUrl"></param>
        /// <param name="contentsUrl"></param>
        /// <param name="contributorsUrl"></param>
        /// <param name="createdAt"></param>
        /// <param name="defaultBranch">
        /// The default branch of the repository.
        /// </param>
        /// <param name="deleteBranchOnMerge">
        /// Whether to delete head branches when pull requests are merged<br/>
        /// Default Value: false
        /// </param>
        /// <param name="deploymentsUrl"></param>
        /// <param name="description"></param>
        /// <param name="disabled">
        /// Returns whether or not this repository is disabled.
        /// </param>
        /// <param name="downloadsUrl"></param>
        /// <param name="eventsUrl"></param>
        /// <param name="fork"></param>
        /// <param name="forks"></param>
        /// <param name="forksCount"></param>
        /// <param name="forksUrl"></param>
        /// <param name="fullName"></param>
        /// <param name="gitCommitsUrl"></param>
        /// <param name="gitRefsUrl"></param>
        /// <param name="gitTagsUrl"></param>
        /// <param name="gitUrl"></param>
        /// <param name="hasDownloads">
        /// Whether downloads are enabled.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="hasIssues">
        /// Whether issues are enabled.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="hasPages"></param>
        /// <param name="hasProjects">
        /// Whether projects are enabled.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="hasWiki">
        /// Whether the wiki is enabled.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="hasDiscussions">
        /// Whether discussions are enabled.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="homepage"></param>
        /// <param name="hooksUrl"></param>
        /// <param name="htmlUrl"></param>
        /// <param name="id">
        /// Unique identifier of the repository
        /// </param>
        /// <param name="isTemplate"></param>
        /// <param name="issueCommentUrl"></param>
        /// <param name="issueEventsUrl"></param>
        /// <param name="issuesUrl"></param>
        /// <param name="keysUrl"></param>
        /// <param name="labelsUrl"></param>
        /// <param name="language"></param>
        /// <param name="languagesUrl"></param>
        /// <param name="license"></param>
        /// <param name="masterBranch"></param>
        /// <param name="mergeCommitMessage">
        /// The default value for a merge commit message.<br/>
        /// - `PR_TITLE` - default to the pull request's title.<br/>
        /// - `PR_BODY` - default to the pull request's body.<br/>
        /// - `BLANK` - default to a blank commit message.
        /// </param>
        /// <param name="mergeCommitTitle">
        /// The default value for a merge commit title.<br/>
        /// - `PR_TITLE` - default to the pull request's title.<br/>
        /// - `MERGE_MESSAGE` - default to the classic title for a merge message (e.g., Merge pull request #123 from branch-name).
        /// </param>
        /// <param name="mergesUrl"></param>
        /// <param name="milestonesUrl"></param>
        /// <param name="mirrorUrl"></param>
        /// <param name="name">
        /// The name of the repository.
        /// </param>
        /// <param name="nodeId"></param>
        /// <param name="notificationsUrl"></param>
        /// <param name="openIssues"></param>
        /// <param name="openIssuesCount"></param>
        /// <param name="organization"></param>
        /// <param name="owner"></param>
        /// <param name="permissions"></param>
        /// <param name="private">
        /// Whether the repository is private or public.
        /// </param>
        /// <param name="public"></param>
        /// <param name="pullsUrl"></param>
        /// <param name="pushedAt"></param>
        /// <param name="releasesUrl"></param>
        /// <param name="roleName"></param>
        /// <param name="size"></param>
        /// <param name="squashMergeCommitMessage">
        /// The default value for a squash merge commit message:<br/>
        /// - `PR_BODY` - default to the pull request's body.<br/>
        /// - `COMMIT_MESSAGES` - default to the branch's commit messages.<br/>
        /// - `BLANK` - default to a blank commit message.
        /// </param>
        /// <param name="squashMergeCommitTitle">
        /// The default value for a squash merge commit title:<br/>
        /// - `PR_TITLE` - default to the pull request's title.<br/>
        /// - `COMMIT_OR_PR_TITLE` - default to the commit's title (if only one commit) or the pull request's title (when more than one commit).
        /// </param>
        /// <param name="sshUrl"></param>
        /// <param name="stargazers"></param>
        /// <param name="stargazersCount"></param>
        /// <param name="stargazersUrl"></param>
        /// <param name="statusesUrl"></param>
        /// <param name="subscribersUrl"></param>
        /// <param name="subscriptionUrl"></param>
        /// <param name="svnUrl"></param>
        /// <param name="tagsUrl"></param>
        /// <param name="teamsUrl"></param>
        /// <param name="topics"></param>
        /// <param name="treesUrl"></param>
        /// <param name="updatedAt"></param>
        /// <param name="url"></param>
        /// <param name="useSquashPrTitleAsDefault">
        /// Whether a squash merge commit can use the pull request title as default. **This property has been deprecated. Please use `squash_merge_commit_title` instead.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="visibility"></param>
        /// <param name="watchers"></param>
        /// <param name="watchersCount"></param>
        /// <param name="webCommitSignoffRequired">
        /// Whether to require contributors to sign off on web-based commits
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhookPullRequestEnqueuedPullRequestBaseRepo(
            string archiveUrl,
            bool archived,
            string assigneesUrl,
            string blobsUrl,
            string branchesUrl,
            string cloneUrl,
            string collaboratorsUrl,
            string commentsUrl,
            string commitsUrl,
            string compareUrl,
            string contentsUrl,
            string contributorsUrl,
            global::G.OneOf<int?, global::System.DateTime?> createdAt,
            string defaultBranch,
            string deploymentsUrl,
            string? description,
            string downloadsUrl,
            string eventsUrl,
            bool fork,
            int forks,
            int forksCount,
            string forksUrl,
            string fullName,
            string gitCommitsUrl,
            string gitRefsUrl,
            string gitTagsUrl,
            string gitUrl,
            bool hasDownloads,
            bool hasIssues,
            bool hasPages,
            bool hasProjects,
            bool hasWiki,
            bool hasDiscussions,
            string? homepage,
            string hooksUrl,
            string htmlUrl,
            long id,
            string issueCommentUrl,
            string issueEventsUrl,
            string issuesUrl,
            string keysUrl,
            string labelsUrl,
            string? language,
            string languagesUrl,
            global::G.WebhookPullRequestEnqueuedPullRequestBaseRepoLicense? license,
            string mergesUrl,
            string milestonesUrl,
            string? mirrorUrl,
            string name,
            string nodeId,
            string notificationsUrl,
            int openIssues,
            int openIssuesCount,
            global::G.WebhookPullRequestEnqueuedPullRequestBaseRepoOwner? owner,
            bool @private,
            string pullsUrl,
            global::G.OneOf<int?, global::System.DateTime?>? pushedAt,
            string releasesUrl,
            int size,
            string sshUrl,
            int stargazersCount,
            string stargazersUrl,
            string statusesUrl,
            string subscribersUrl,
            string subscriptionUrl,
            string svnUrl,
            string tagsUrl,
            string teamsUrl,
            global::System.Collections.Generic.IList<string> topics,
            string treesUrl,
            global::System.DateTime updatedAt,
            string url,
            global::G.WebhookPullRequestEnqueuedPullRequestBaseRepoVisibility visibility,
            int watchers,
            int watchersCount,
            bool? allowAutoMerge,
            bool? allowForking,
            bool? allowMergeCommit,
            bool? allowRebaseMerge,
            bool? allowSquashMerge,
            bool? allowUpdateBranch,
            bool? deleteBranchOnMerge,
            bool? disabled,
            bool? isTemplate,
            string? masterBranch,
            global::G.WebhookPullRequestEnqueuedPullRequestBaseRepoMergeCommitMessage? mergeCommitMessage,
            global::G.WebhookPullRequestEnqueuedPullRequestBaseRepoMergeCommitTitle? mergeCommitTitle,
            string? organization,
            global::G.WebhookPullRequestEnqueuedPullRequestBaseRepoPermissions? permissions,
            bool? @public,
            string? roleName,
            global::G.WebhookPullRequestEnqueuedPullRequestBaseRepoSquashMergeCommitMessage? squashMergeCommitMessage,
            global::G.WebhookPullRequestEnqueuedPullRequestBaseRepoSquashMergeCommitTitle? squashMergeCommitTitle,
            int? stargazers,
            bool? useSquashPrTitleAsDefault,
            bool? webCommitSignoffRequired)
        {
            this.ArchiveUrl = archiveUrl ?? throw new global::System.ArgumentNullException(nameof(archiveUrl));
            this.Archived = archived;
            this.AssigneesUrl = assigneesUrl ?? throw new global::System.ArgumentNullException(nameof(assigneesUrl));
            this.BlobsUrl = blobsUrl ?? throw new global::System.ArgumentNullException(nameof(blobsUrl));
            this.BranchesUrl = branchesUrl ?? throw new global::System.ArgumentNullException(nameof(branchesUrl));
            this.CloneUrl = cloneUrl ?? throw new global::System.ArgumentNullException(nameof(cloneUrl));
            this.CollaboratorsUrl = collaboratorsUrl ?? throw new global::System.ArgumentNullException(nameof(collaboratorsUrl));
            this.CommentsUrl = commentsUrl ?? throw new global::System.ArgumentNullException(nameof(commentsUrl));
            this.CommitsUrl = commitsUrl ?? throw new global::System.ArgumentNullException(nameof(commitsUrl));
            this.CompareUrl = compareUrl ?? throw new global::System.ArgumentNullException(nameof(compareUrl));
            this.ContentsUrl = contentsUrl ?? throw new global::System.ArgumentNullException(nameof(contentsUrl));
            this.ContributorsUrl = contributorsUrl ?? throw new global::System.ArgumentNullException(nameof(contributorsUrl));
            this.CreatedAt = createdAt;
            this.DefaultBranch = defaultBranch ?? throw new global::System.ArgumentNullException(nameof(defaultBranch));
            this.DeploymentsUrl = deploymentsUrl ?? throw new global::System.ArgumentNullException(nameof(deploymentsUrl));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.DownloadsUrl = downloadsUrl ?? throw new global::System.ArgumentNullException(nameof(downloadsUrl));
            this.EventsUrl = eventsUrl ?? throw new global::System.ArgumentNullException(nameof(eventsUrl));
            this.Fork = fork;
            this.Forks = forks;
            this.ForksCount = forksCount;
            this.ForksUrl = forksUrl ?? throw new global::System.ArgumentNullException(nameof(forksUrl));
            this.FullName = fullName ?? throw new global::System.ArgumentNullException(nameof(fullName));
            this.GitCommitsUrl = gitCommitsUrl ?? throw new global::System.ArgumentNullException(nameof(gitCommitsUrl));
            this.GitRefsUrl = gitRefsUrl ?? throw new global::System.ArgumentNullException(nameof(gitRefsUrl));
            this.GitTagsUrl = gitTagsUrl ?? throw new global::System.ArgumentNullException(nameof(gitTagsUrl));
            this.GitUrl = gitUrl ?? throw new global::System.ArgumentNullException(nameof(gitUrl));
            this.HasDownloads = hasDownloads;
            this.HasIssues = hasIssues;
            this.HasPages = hasPages;
            this.HasProjects = hasProjects;
            this.HasWiki = hasWiki;
            this.HasDiscussions = hasDiscussions;
            this.Homepage = homepage ?? throw new global::System.ArgumentNullException(nameof(homepage));
            this.HooksUrl = hooksUrl ?? throw new global::System.ArgumentNullException(nameof(hooksUrl));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.Id = id;
            this.IssueCommentUrl = issueCommentUrl ?? throw new global::System.ArgumentNullException(nameof(issueCommentUrl));
            this.IssueEventsUrl = issueEventsUrl ?? throw new global::System.ArgumentNullException(nameof(issueEventsUrl));
            this.IssuesUrl = issuesUrl ?? throw new global::System.ArgumentNullException(nameof(issuesUrl));
            this.KeysUrl = keysUrl ?? throw new global::System.ArgumentNullException(nameof(keysUrl));
            this.LabelsUrl = labelsUrl ?? throw new global::System.ArgumentNullException(nameof(labelsUrl));
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.LanguagesUrl = languagesUrl ?? throw new global::System.ArgumentNullException(nameof(languagesUrl));
            this.License = license ?? throw new global::System.ArgumentNullException(nameof(license));
            this.MergesUrl = mergesUrl ?? throw new global::System.ArgumentNullException(nameof(mergesUrl));
            this.MilestonesUrl = milestonesUrl ?? throw new global::System.ArgumentNullException(nameof(milestonesUrl));
            this.MirrorUrl = mirrorUrl ?? throw new global::System.ArgumentNullException(nameof(mirrorUrl));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.NotificationsUrl = notificationsUrl ?? throw new global::System.ArgumentNullException(nameof(notificationsUrl));
            this.OpenIssues = openIssues;
            this.OpenIssuesCount = openIssuesCount;
            this.Owner = owner ?? throw new global::System.ArgumentNullException(nameof(owner));
            this.Private = @private;
            this.PullsUrl = pullsUrl ?? throw new global::System.ArgumentNullException(nameof(pullsUrl));
            this.PushedAt = pushedAt;
            this.ReleasesUrl = releasesUrl ?? throw new global::System.ArgumentNullException(nameof(releasesUrl));
            this.Size = size;
            this.SshUrl = sshUrl ?? throw new global::System.ArgumentNullException(nameof(sshUrl));
            this.StargazersCount = stargazersCount;
            this.StargazersUrl = stargazersUrl ?? throw new global::System.ArgumentNullException(nameof(stargazersUrl));
            this.StatusesUrl = statusesUrl ?? throw new global::System.ArgumentNullException(nameof(statusesUrl));
            this.SubscribersUrl = subscribersUrl ?? throw new global::System.ArgumentNullException(nameof(subscribersUrl));
            this.SubscriptionUrl = subscriptionUrl ?? throw new global::System.ArgumentNullException(nameof(subscriptionUrl));
            this.SvnUrl = svnUrl ?? throw new global::System.ArgumentNullException(nameof(svnUrl));
            this.TagsUrl = tagsUrl ?? throw new global::System.ArgumentNullException(nameof(tagsUrl));
            this.TeamsUrl = teamsUrl ?? throw new global::System.ArgumentNullException(nameof(teamsUrl));
            this.Topics = topics ?? throw new global::System.ArgumentNullException(nameof(topics));
            this.TreesUrl = treesUrl ?? throw new global::System.ArgumentNullException(nameof(treesUrl));
            this.UpdatedAt = updatedAt;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Visibility = visibility;
            this.Watchers = watchers;
            this.WatchersCount = watchersCount;
            this.AllowAutoMerge = allowAutoMerge;
            this.AllowForking = allowForking;
            this.AllowMergeCommit = allowMergeCommit;
            this.AllowRebaseMerge = allowRebaseMerge;
            this.AllowSquashMerge = allowSquashMerge;
            this.AllowUpdateBranch = allowUpdateBranch;
            this.DeleteBranchOnMerge = deleteBranchOnMerge;
            this.Disabled = disabled;
            this.IsTemplate = isTemplate;
            this.MasterBranch = masterBranch;
            this.MergeCommitMessage = mergeCommitMessage;
            this.MergeCommitTitle = mergeCommitTitle;
            this.Organization = organization;
            this.Permissions = permissions;
            this.Public = @public;
            this.RoleName = roleName;
            this.SquashMergeCommitMessage = squashMergeCommitMessage;
            this.SquashMergeCommitTitle = squashMergeCommitTitle;
            this.Stargazers = stargazers;
            this.UseSquashPrTitleAsDefault = useSquashPrTitleAsDefault;
            this.WebCommitSignoffRequired = webCommitSignoffRequired;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestEnqueuedPullRequestBaseRepo" /> class.
        /// </summary>
        public WebhookPullRequestEnqueuedPullRequestBaseRepo()
        {
        }
    }
}
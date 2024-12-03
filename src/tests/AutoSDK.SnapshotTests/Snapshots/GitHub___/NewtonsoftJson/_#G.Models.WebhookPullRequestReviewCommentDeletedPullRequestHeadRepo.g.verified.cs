//HintName: G.Models.WebhookPullRequestReviewCommentDeletedPullRequestHeadRepo.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A git repository
    /// </summary>
    public sealed partial class WebhookPullRequestReviewCommentDeletedPullRequestHeadRepo
    {
        /// <summary>
        /// Whether to allow auto-merge for pull requests.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allow_auto_merge")]
        public bool? AllowAutoMerge { get; set; }

        /// <summary>
        /// Whether to allow private forks
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allow_forking")]
        public bool? AllowForking { get; set; }

        /// <summary>
        /// Whether to allow merge commits for pull requests.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allow_merge_commit")]
        public bool? AllowMergeCommit { get; set; }

        /// <summary>
        /// Whether to allow rebase merges for pull requests.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allow_rebase_merge")]
        public bool? AllowRebaseMerge { get; set; }

        /// <summary>
        /// Whether to allow squash merges for pull requests.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allow_squash_merge")]
        public bool? AllowSquashMerge { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allow_update_branch")]
        public bool? AllowUpdateBranch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("archive_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ArchiveUrl { get; set; } = default!;

        /// <summary>
        /// Whether the repository is archived.<br/>
        /// Default Value: false
        /// </summary>
        /// <default>false</default>
        [global::Newtonsoft.Json.JsonProperty("archived", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Archived { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assignees_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string AssigneesUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("blobs_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string BlobsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("branches_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string BranchesUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("clone_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string CloneUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("collaborators_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string CollaboratorsUrl { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonProperty("compare_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string CompareUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("contents_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ContentsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("contributors_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ContributorsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<int?, global::System.DateTime?> CreatedAt { get; set; } = default!;

        /// <summary>
        /// The default branch of the repository.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default_branch", Required = global::Newtonsoft.Json.Required.Always)]
        public string DefaultBranch { get; set; } = default!;

        /// <summary>
        /// Whether to delete head branches when pull requests are merged<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delete_branch_on_merge")]
        public bool? DeleteBranchOnMerge { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deployments_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string DeploymentsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Description { get; set; } = default!;

        /// <summary>
        /// Returns whether or not this repository is disabled.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("disabled")]
        public bool? Disabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("downloads_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string DownloadsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("events_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string EventsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fork", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Fork { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("forks", Required = global::Newtonsoft.Json.Required.Always)]
        public int Forks { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("forks_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int ForksCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("forks_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ForksUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("full_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string FullName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("git_commits_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string GitCommitsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("git_refs_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string GitRefsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("git_tags_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string GitTagsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("git_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string GitUrl { get; set; } = default!;

        /// <summary>
        /// Whether downloads are enabled.<br/>
        /// Default Value: true
        /// </summary>
        /// <default>true</default>
        [global::Newtonsoft.Json.JsonProperty("has_downloads", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasDownloads { get; set; } = default!;

        /// <summary>
        /// Whether issues are enabled.<br/>
        /// Default Value: true
        /// </summary>
        /// <default>true</default>
        [global::Newtonsoft.Json.JsonProperty("has_issues", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasIssues { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_pages", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasPages { get; set; } = default!;

        /// <summary>
        /// Whether projects are enabled.<br/>
        /// Default Value: true
        /// </summary>
        /// <default>true</default>
        [global::Newtonsoft.Json.JsonProperty("has_projects", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasProjects { get; set; } = default!;

        /// <summary>
        /// Whether the wiki is enabled.<br/>
        /// Default Value: true
        /// </summary>
        /// <default>true</default>
        [global::Newtonsoft.Json.JsonProperty("has_wiki", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasWiki { get; set; } = default!;

        /// <summary>
        /// Whether discussions are enabled.<br/>
        /// Default Value: false
        /// </summary>
        /// <default>false</default>
        [global::Newtonsoft.Json.JsonProperty("has_discussions", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasDiscussions { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("homepage", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Homepage { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hooks_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HooksUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// Unique identifier of the repository
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public long Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_template")]
        public bool? IsTemplate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("issue_comment_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string IssueCommentUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("issue_events_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string IssueEventsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("issues_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string IssuesUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("keys_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string KeysUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("labels_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string LabelsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Language { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("languages_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string LanguagesUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("license", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPullRequestReviewCommentDeletedPullRequestHeadRepoLicense? License { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("master_branch")]
        public string? MasterBranch { get; set; }

        /// <summary>
        /// The default value for a merge commit message.<br/>
        /// - `PR_TITLE` - default to the pull request's title.<br/>
        /// - `PR_BODY` - default to the pull request's body.<br/>
        /// - `BLANK` - default to a blank commit message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("merge_commit_message")]
        public global::G.WebhookPullRequestReviewCommentDeletedPullRequestHeadRepoMergeCommitMessage? MergeCommitMessage { get; set; }

        /// <summary>
        /// The default value for a merge commit title.<br/>
        /// - `PR_TITLE` - default to the pull request's title.<br/>
        /// - `MERGE_MESSAGE` - default to the classic title for a merge message (e.g., Merge pull request #123 from branch-name).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("merge_commit_title")]
        public global::G.WebhookPullRequestReviewCommentDeletedPullRequestHeadRepoMergeCommitTitle? MergeCommitTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("merges_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string MergesUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("milestones_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string MilestonesUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mirror_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string? MirrorUrl { get; set; } = default!;

        /// <summary>
        /// The name of the repository.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("notifications_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string NotificationsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("open_issues", Required = global::Newtonsoft.Json.Required.Always)]
        public int OpenIssues { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("open_issues_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int OpenIssuesCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization")]
        public string? Organization { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPullRequestReviewCommentDeletedPullRequestHeadRepoOwner? Owner { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permissions")]
        public global::G.WebhookPullRequestReviewCommentDeletedPullRequestHeadRepoPermissions? Permissions { get; set; }

        /// <summary>
        /// Whether the repository is private or public.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("private", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Private { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("public")]
        public bool? Public { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pulls_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string PullsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pushed_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<int?, global::System.DateTime?>? PushedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("releases_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ReleasesUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role_name")]
        public string? RoleName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size", Required = global::Newtonsoft.Json.Required.Always)]
        public int Size { get; set; } = default!;

        /// <summary>
        /// The default value for a squash merge commit message:<br/>
        /// - `PR_BODY` - default to the pull request's body.<br/>
        /// - `COMMIT_MESSAGES` - default to the branch's commit messages.<br/>
        /// - `BLANK` - default to a blank commit message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("squash_merge_commit_message")]
        public global::G.WebhookPullRequestReviewCommentDeletedPullRequestHeadRepoSquashMergeCommitMessage? SquashMergeCommitMessage { get; set; }

        /// <summary>
        /// The default value for a squash merge commit title:<br/>
        /// - `PR_TITLE` - default to the pull request's title.<br/>
        /// - `COMMIT_OR_PR_TITLE` - default to the commit's title (if only one commit) or the pull request's title (when more than one commit).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("squash_merge_commit_title")]
        public global::G.WebhookPullRequestReviewCommentDeletedPullRequestHeadRepoSquashMergeCommitTitle? SquashMergeCommitTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ssh_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string SshUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stargazers")]
        public int? Stargazers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stargazers_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int StargazersCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stargazers_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string StargazersUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("statuses_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string StatusesUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("subscribers_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string SubscribersUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("subscription_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string SubscriptionUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("svn_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string SvnUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string TagsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("teams_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string TeamsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("topics", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Topics { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trees_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string TreesUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Whether a squash merge commit can use the pull request title as default. **This property has been deprecated. Please use `squash_merge_commit_title` instead.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("use_squash_pr_title_as_default")]
        public bool? UseSquashPrTitleAsDefault { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("visibility", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPullRequestReviewCommentDeletedPullRequestHeadRepoVisibility Visibility { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("watchers", Required = global::Newtonsoft.Json.Required.Always)]
        public int Watchers { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("watchers_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int WatchersCount { get; set; } = default!;

        /// <summary>
        /// Whether to require contributors to sign off on web-based commits
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("web_commit_signoff_required")]
        public bool? WebCommitSignoffRequired { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestReviewCommentDeletedPullRequestHeadRepo" /> class.
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
        public WebhookPullRequestReviewCommentDeletedPullRequestHeadRepo(
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
            global::G.WebhookPullRequestReviewCommentDeletedPullRequestHeadRepoLicense? license,
            string mergesUrl,
            string milestonesUrl,
            string? mirrorUrl,
            string name,
            string nodeId,
            string notificationsUrl,
            int openIssues,
            int openIssuesCount,
            global::G.WebhookPullRequestReviewCommentDeletedPullRequestHeadRepoOwner? owner,
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
            global::G.WebhookPullRequestReviewCommentDeletedPullRequestHeadRepoVisibility visibility,
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
            global::G.WebhookPullRequestReviewCommentDeletedPullRequestHeadRepoMergeCommitMessage? mergeCommitMessage,
            global::G.WebhookPullRequestReviewCommentDeletedPullRequestHeadRepoMergeCommitTitle? mergeCommitTitle,
            string? organization,
            global::G.WebhookPullRequestReviewCommentDeletedPullRequestHeadRepoPermissions? permissions,
            bool? @public,
            string? roleName,
            global::G.WebhookPullRequestReviewCommentDeletedPullRequestHeadRepoSquashMergeCommitMessage? squashMergeCommitMessage,
            global::G.WebhookPullRequestReviewCommentDeletedPullRequestHeadRepoSquashMergeCommitTitle? squashMergeCommitTitle,
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
        /// Initializes a new instance of the <see cref="WebhookPullRequestReviewCommentDeletedPullRequestHeadRepo" /> class.
        /// </summary>
        public WebhookPullRequestReviewCommentDeletedPullRequestHeadRepo()
        {
        }
    }
}
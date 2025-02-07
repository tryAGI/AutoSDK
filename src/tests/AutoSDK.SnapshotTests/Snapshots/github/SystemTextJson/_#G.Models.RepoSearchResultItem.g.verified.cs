//HintName: G.Models.RepoSearchResultItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Repo Search Result Item
    /// </summary>
    public sealed partial class RepoSearchResultItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("full_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FullName { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.NullableSimpleUser? Owner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Private { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// 
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pushed_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime PushedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("homepage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Homepage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stargazers_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StargazersCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("watchers_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int WatchersCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("forks_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ForksCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("open_issues_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OpenIssuesCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("master_branch")]
        public string? MasterBranch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_branch")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DefaultBranch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Score { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("forks_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ForksUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keys_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KeysUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collaborators_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CollaboratorsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teams_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hooks_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HooksUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issue_events_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IssueEventsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignees_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AssigneesUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branches_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BranchesUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TagsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blobs_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BlobsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("git_tags_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GitTagsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("git_refs_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GitRefsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trees_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TreesUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statuses_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StatusesUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LanguagesUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stargazers_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StargazersUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contributors_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContributorsUrl { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("commits_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CommitsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("git_commits_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GitCommitsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comments_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CommentsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issue_comment_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IssueCommentUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contents_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compare_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CompareUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merges_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MergesUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archive_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ArchiveUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("downloads_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DownloadsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IssuesUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pulls_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PullsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("milestones_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MilestonesUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notifications_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NotificationsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LabelsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("releases_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReleasesUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployments_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeploymentsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("git_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GitUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ssh_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SshUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clone_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CloneUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("svn_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SvnUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("forks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Forks { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topics")]
        public global::System.Collections.Generic.IList<string>? Topics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mirror_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? MirrorUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_issues")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasIssues { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_projects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasProjects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_pages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasPages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_wiki")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasWiki { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_downloads")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasDownloads { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_discussions")]
        public bool? HasDiscussions { get; set; }

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
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        public string? Visibility { get; set; }

        /// <summary>
        /// License Simple
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("license")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.NullableLicenseSimple? License { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        public global::G.RepoSearchResultItemPermissions? Permissions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_matches")]
        public global::System.Collections.Generic.IList<global::G.SearchResultTextMatche>? TextMatches { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temp_clone_token")]
        public string? TempCloneToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_merge_commit")]
        public bool? AllowMergeCommit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_squash_merge")]
        public bool? AllowSquashMerge { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_rebase_merge")]
        public bool? AllowRebaseMerge { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_auto_merge")]
        public bool? AllowAutoMerge { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delete_branch_on_merge")]
        public bool? DeleteBranchOnMerge { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_forking")]
        public bool? AllowForking { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_template")]
        public bool? IsTemplate { get; set; }

        /// <summary>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("web_commit_signoff_required")]
        public bool? WebCommitSignoffRequired { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepoSearchResultItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nodeId"></param>
        /// <param name="name"></param>
        /// <param name="fullName"></param>
        /// <param name="owner">
        /// A GitHub user.
        /// </param>
        /// <param name="private"></param>
        /// <param name="htmlUrl"></param>
        /// <param name="description"></param>
        /// <param name="fork"></param>
        /// <param name="url"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="pushedAt"></param>
        /// <param name="homepage"></param>
        /// <param name="size"></param>
        /// <param name="stargazersCount"></param>
        /// <param name="watchersCount"></param>
        /// <param name="language"></param>
        /// <param name="forksCount"></param>
        /// <param name="openIssuesCount"></param>
        /// <param name="masterBranch"></param>
        /// <param name="defaultBranch"></param>
        /// <param name="score"></param>
        /// <param name="forksUrl"></param>
        /// <param name="keysUrl"></param>
        /// <param name="collaboratorsUrl"></param>
        /// <param name="teamsUrl"></param>
        /// <param name="hooksUrl"></param>
        /// <param name="issueEventsUrl"></param>
        /// <param name="eventsUrl"></param>
        /// <param name="assigneesUrl"></param>
        /// <param name="branchesUrl"></param>
        /// <param name="tagsUrl"></param>
        /// <param name="blobsUrl"></param>
        /// <param name="gitTagsUrl"></param>
        /// <param name="gitRefsUrl"></param>
        /// <param name="treesUrl"></param>
        /// <param name="statusesUrl"></param>
        /// <param name="languagesUrl"></param>
        /// <param name="stargazersUrl"></param>
        /// <param name="contributorsUrl"></param>
        /// <param name="subscribersUrl"></param>
        /// <param name="subscriptionUrl"></param>
        /// <param name="commitsUrl"></param>
        /// <param name="gitCommitsUrl"></param>
        /// <param name="commentsUrl"></param>
        /// <param name="issueCommentUrl"></param>
        /// <param name="contentsUrl"></param>
        /// <param name="compareUrl"></param>
        /// <param name="mergesUrl"></param>
        /// <param name="archiveUrl"></param>
        /// <param name="downloadsUrl"></param>
        /// <param name="issuesUrl"></param>
        /// <param name="pullsUrl"></param>
        /// <param name="milestonesUrl"></param>
        /// <param name="notificationsUrl"></param>
        /// <param name="labelsUrl"></param>
        /// <param name="releasesUrl"></param>
        /// <param name="deploymentsUrl"></param>
        /// <param name="gitUrl"></param>
        /// <param name="sshUrl"></param>
        /// <param name="cloneUrl"></param>
        /// <param name="svnUrl"></param>
        /// <param name="forks"></param>
        /// <param name="openIssues"></param>
        /// <param name="watchers"></param>
        /// <param name="topics"></param>
        /// <param name="mirrorUrl"></param>
        /// <param name="hasIssues"></param>
        /// <param name="hasProjects"></param>
        /// <param name="hasPages"></param>
        /// <param name="hasWiki"></param>
        /// <param name="hasDownloads"></param>
        /// <param name="hasDiscussions"></param>
        /// <param name="archived"></param>
        /// <param name="disabled">
        /// Returns whether or not this repository disabled.
        /// </param>
        /// <param name="visibility">
        /// The repository visibility: public, private, or internal.
        /// </param>
        /// <param name="license">
        /// License Simple
        /// </param>
        /// <param name="permissions"></param>
        /// <param name="textMatches"></param>
        /// <param name="tempCloneToken"></param>
        /// <param name="allowMergeCommit"></param>
        /// <param name="allowSquashMerge"></param>
        /// <param name="allowRebaseMerge"></param>
        /// <param name="allowAutoMerge"></param>
        /// <param name="deleteBranchOnMerge"></param>
        /// <param name="allowForking"></param>
        /// <param name="isTemplate"></param>
        /// <param name="webCommitSignoffRequired">
        /// Example: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RepoSearchResultItem(
            int id,
            string nodeId,
            string name,
            string fullName,
            global::G.NullableSimpleUser? owner,
            bool @private,
            string htmlUrl,
            string? description,
            bool fork,
            string url,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.DateTime pushedAt,
            string? homepage,
            int size,
            int stargazersCount,
            int watchersCount,
            string? language,
            int forksCount,
            int openIssuesCount,
            string defaultBranch,
            double score,
            string forksUrl,
            string keysUrl,
            string collaboratorsUrl,
            string teamsUrl,
            string hooksUrl,
            string issueEventsUrl,
            string eventsUrl,
            string assigneesUrl,
            string branchesUrl,
            string tagsUrl,
            string blobsUrl,
            string gitTagsUrl,
            string gitRefsUrl,
            string treesUrl,
            string statusesUrl,
            string languagesUrl,
            string stargazersUrl,
            string contributorsUrl,
            string subscribersUrl,
            string subscriptionUrl,
            string commitsUrl,
            string gitCommitsUrl,
            string commentsUrl,
            string issueCommentUrl,
            string contentsUrl,
            string compareUrl,
            string mergesUrl,
            string archiveUrl,
            string downloadsUrl,
            string issuesUrl,
            string pullsUrl,
            string milestonesUrl,
            string notificationsUrl,
            string labelsUrl,
            string releasesUrl,
            string deploymentsUrl,
            string gitUrl,
            string sshUrl,
            string cloneUrl,
            string svnUrl,
            int forks,
            int openIssues,
            int watchers,
            string? mirrorUrl,
            bool hasIssues,
            bool hasProjects,
            bool hasPages,
            bool hasWiki,
            bool hasDownloads,
            bool archived,
            bool disabled,
            global::G.NullableLicenseSimple? license,
            string? masterBranch,
            global::System.Collections.Generic.IList<string>? topics,
            bool? hasDiscussions,
            string? visibility,
            global::G.RepoSearchResultItemPermissions? permissions,
            global::System.Collections.Generic.IList<global::G.SearchResultTextMatche>? textMatches,
            string? tempCloneToken,
            bool? allowMergeCommit,
            bool? allowSquashMerge,
            bool? allowRebaseMerge,
            bool? allowAutoMerge,
            bool? deleteBranchOnMerge,
            bool? allowForking,
            bool? isTemplate,
            bool? webCommitSignoffRequired)
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
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.PushedAt = pushedAt;
            this.Homepage = homepage ?? throw new global::System.ArgumentNullException(nameof(homepage));
            this.Size = size;
            this.StargazersCount = stargazersCount;
            this.WatchersCount = watchersCount;
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.ForksCount = forksCount;
            this.OpenIssuesCount = openIssuesCount;
            this.DefaultBranch = defaultBranch ?? throw new global::System.ArgumentNullException(nameof(defaultBranch));
            this.Score = score;
            this.ForksUrl = forksUrl ?? throw new global::System.ArgumentNullException(nameof(forksUrl));
            this.KeysUrl = keysUrl ?? throw new global::System.ArgumentNullException(nameof(keysUrl));
            this.CollaboratorsUrl = collaboratorsUrl ?? throw new global::System.ArgumentNullException(nameof(collaboratorsUrl));
            this.TeamsUrl = teamsUrl ?? throw new global::System.ArgumentNullException(nameof(teamsUrl));
            this.HooksUrl = hooksUrl ?? throw new global::System.ArgumentNullException(nameof(hooksUrl));
            this.IssueEventsUrl = issueEventsUrl ?? throw new global::System.ArgumentNullException(nameof(issueEventsUrl));
            this.EventsUrl = eventsUrl ?? throw new global::System.ArgumentNullException(nameof(eventsUrl));
            this.AssigneesUrl = assigneesUrl ?? throw new global::System.ArgumentNullException(nameof(assigneesUrl));
            this.BranchesUrl = branchesUrl ?? throw new global::System.ArgumentNullException(nameof(branchesUrl));
            this.TagsUrl = tagsUrl ?? throw new global::System.ArgumentNullException(nameof(tagsUrl));
            this.BlobsUrl = blobsUrl ?? throw new global::System.ArgumentNullException(nameof(blobsUrl));
            this.GitTagsUrl = gitTagsUrl ?? throw new global::System.ArgumentNullException(nameof(gitTagsUrl));
            this.GitRefsUrl = gitRefsUrl ?? throw new global::System.ArgumentNullException(nameof(gitRefsUrl));
            this.TreesUrl = treesUrl ?? throw new global::System.ArgumentNullException(nameof(treesUrl));
            this.StatusesUrl = statusesUrl ?? throw new global::System.ArgumentNullException(nameof(statusesUrl));
            this.LanguagesUrl = languagesUrl ?? throw new global::System.ArgumentNullException(nameof(languagesUrl));
            this.StargazersUrl = stargazersUrl ?? throw new global::System.ArgumentNullException(nameof(stargazersUrl));
            this.ContributorsUrl = contributorsUrl ?? throw new global::System.ArgumentNullException(nameof(contributorsUrl));
            this.SubscribersUrl = subscribersUrl ?? throw new global::System.ArgumentNullException(nameof(subscribersUrl));
            this.SubscriptionUrl = subscriptionUrl ?? throw new global::System.ArgumentNullException(nameof(subscriptionUrl));
            this.CommitsUrl = commitsUrl ?? throw new global::System.ArgumentNullException(nameof(commitsUrl));
            this.GitCommitsUrl = gitCommitsUrl ?? throw new global::System.ArgumentNullException(nameof(gitCommitsUrl));
            this.CommentsUrl = commentsUrl ?? throw new global::System.ArgumentNullException(nameof(commentsUrl));
            this.IssueCommentUrl = issueCommentUrl ?? throw new global::System.ArgumentNullException(nameof(issueCommentUrl));
            this.ContentsUrl = contentsUrl ?? throw new global::System.ArgumentNullException(nameof(contentsUrl));
            this.CompareUrl = compareUrl ?? throw new global::System.ArgumentNullException(nameof(compareUrl));
            this.MergesUrl = mergesUrl ?? throw new global::System.ArgumentNullException(nameof(mergesUrl));
            this.ArchiveUrl = archiveUrl ?? throw new global::System.ArgumentNullException(nameof(archiveUrl));
            this.DownloadsUrl = downloadsUrl ?? throw new global::System.ArgumentNullException(nameof(downloadsUrl));
            this.IssuesUrl = issuesUrl ?? throw new global::System.ArgumentNullException(nameof(issuesUrl));
            this.PullsUrl = pullsUrl ?? throw new global::System.ArgumentNullException(nameof(pullsUrl));
            this.MilestonesUrl = milestonesUrl ?? throw new global::System.ArgumentNullException(nameof(milestonesUrl));
            this.NotificationsUrl = notificationsUrl ?? throw new global::System.ArgumentNullException(nameof(notificationsUrl));
            this.LabelsUrl = labelsUrl ?? throw new global::System.ArgumentNullException(nameof(labelsUrl));
            this.ReleasesUrl = releasesUrl ?? throw new global::System.ArgumentNullException(nameof(releasesUrl));
            this.DeploymentsUrl = deploymentsUrl ?? throw new global::System.ArgumentNullException(nameof(deploymentsUrl));
            this.GitUrl = gitUrl ?? throw new global::System.ArgumentNullException(nameof(gitUrl));
            this.SshUrl = sshUrl ?? throw new global::System.ArgumentNullException(nameof(sshUrl));
            this.CloneUrl = cloneUrl ?? throw new global::System.ArgumentNullException(nameof(cloneUrl));
            this.SvnUrl = svnUrl ?? throw new global::System.ArgumentNullException(nameof(svnUrl));
            this.Forks = forks;
            this.OpenIssues = openIssues;
            this.Watchers = watchers;
            this.MirrorUrl = mirrorUrl ?? throw new global::System.ArgumentNullException(nameof(mirrorUrl));
            this.HasIssues = hasIssues;
            this.HasProjects = hasProjects;
            this.HasPages = hasPages;
            this.HasWiki = hasWiki;
            this.HasDownloads = hasDownloads;
            this.Archived = archived;
            this.Disabled = disabled;
            this.License = license ?? throw new global::System.ArgumentNullException(nameof(license));
            this.MasterBranch = masterBranch;
            this.Topics = topics;
            this.HasDiscussions = hasDiscussions;
            this.Visibility = visibility;
            this.Permissions = permissions;
            this.TextMatches = textMatches;
            this.TempCloneToken = tempCloneToken;
            this.AllowMergeCommit = allowMergeCommit;
            this.AllowSquashMerge = allowSquashMerge;
            this.AllowRebaseMerge = allowRebaseMerge;
            this.AllowAutoMerge = allowAutoMerge;
            this.DeleteBranchOnMerge = deleteBranchOnMerge;
            this.AllowForking = allowForking;
            this.IsTemplate = isTemplate;
            this.WebCommitSignoffRequired = webCommitSignoffRequired;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepoSearchResultItem" /> class.
        /// </summary>
        public RepoSearchResultItem()
        {
        }
    }
}
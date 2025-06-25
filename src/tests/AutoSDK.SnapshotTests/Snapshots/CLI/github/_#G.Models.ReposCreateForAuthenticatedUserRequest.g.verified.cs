//HintName: G.Models.ReposCreateForAuthenticatedUserRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposCreateForAuthenticatedUserRequest
    {
        /// <summary>
        /// The name of the repository.<br/>
        /// Example: Team Environment
        /// </summary>
        /// <example>Team Environment</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A short description of the repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// A URL with more information about the repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("homepage")]
        public string? Homepage { get; set; }

        /// <summary>
        /// Whether the repository is private.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        public bool? Private { get; set; }

        /// <summary>
        /// Whether issues are enabled.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_issues")]
        public bool? HasIssues { get; set; }

        /// <summary>
        /// Whether projects are enabled.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_projects")]
        public bool? HasProjects { get; set; }

        /// <summary>
        /// Whether the wiki is enabled.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_wiki")]
        public bool? HasWiki { get; set; }

        /// <summary>
        /// Whether discussions are enabled.<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_discussions")]
        public bool? HasDiscussions { get; set; }

        /// <summary>
        /// The id of the team that will be granted access to this repository. This is only valid when creating a repository in an organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        public int? TeamId { get; set; }

        /// <summary>
        /// Whether the repository is initialized with a minimal README.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_init")]
        public bool? AutoInit { get; set; }

        /// <summary>
        /// The desired language or platform to apply to the .gitignore.<br/>
        /// Example: Haskell
        /// </summary>
        /// <example>Haskell</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitignore_template")]
        public string? GitignoreTemplate { get; set; }

        /// <summary>
        /// The license keyword of the open source license for this repository.<br/>
        /// Example: mit
        /// </summary>
        /// <example>mit</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("license_template")]
        public string? LicenseTemplate { get; set; }

        /// <summary>
        /// Whether to allow squash merges for pull requests.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_squash_merge")]
        public bool? AllowSquashMerge { get; set; }

        /// <summary>
        /// Whether to allow merge commits for pull requests.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_merge_commit")]
        public bool? AllowMergeCommit { get; set; }

        /// <summary>
        /// Whether to allow rebase merges for pull requests.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_rebase_merge")]
        public bool? AllowRebaseMerge { get; set; }

        /// <summary>
        /// Whether to allow Auto-merge to be used on pull requests.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_auto_merge")]
        public bool? AllowAutoMerge { get; set; }

        /// <summary>
        /// Whether to delete head branches when pull requests are merged<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("delete_branch_on_merge")]
        public bool? DeleteBranchOnMerge { get; set; }

        /// <summary>
        /// Required when using `squash_merge_commit_message`.<br/>
        /// The default value for a squash merge commit title:<br/>
        /// - `PR_TITLE` - default to the pull request's title.<br/>
        /// - `COMMIT_OR_PR_TITLE` - default to the commit's title (if only one commit) or the pull request's title (when more than one commit).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("squash_merge_commit_title")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ReposCreateForAuthenticatedUserRequestSquashMergeCommitTitleJsonConverter))]
        public global::G.ReposCreateForAuthenticatedUserRequestSquashMergeCommitTitle? SquashMergeCommitTitle { get; set; }

        /// <summary>
        /// The default value for a squash merge commit message:<br/>
        /// - `PR_BODY` - default to the pull request's body.<br/>
        /// - `COMMIT_MESSAGES` - default to the branch's commit messages.<br/>
        /// - `BLANK` - default to a blank commit message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("squash_merge_commit_message")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ReposCreateForAuthenticatedUserRequestSquashMergeCommitMessageJsonConverter))]
        public global::G.ReposCreateForAuthenticatedUserRequestSquashMergeCommitMessage? SquashMergeCommitMessage { get; set; }

        /// <summary>
        /// Required when using `merge_commit_message`.<br/>
        /// The default value for a merge commit title.<br/>
        /// - `PR_TITLE` - default to the pull request's title.<br/>
        /// - `MERGE_MESSAGE` - default to the classic title for a merge message (e.g., Merge pull request #123 from branch-name).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merge_commit_title")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ReposCreateForAuthenticatedUserRequestMergeCommitTitleJsonConverter))]
        public global::G.ReposCreateForAuthenticatedUserRequestMergeCommitTitle? MergeCommitTitle { get; set; }

        /// <summary>
        /// The default value for a merge commit message.<br/>
        /// - `PR_TITLE` - default to the pull request's title.<br/>
        /// - `PR_BODY` - default to the pull request's body.<br/>
        /// - `BLANK` - default to a blank commit message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merge_commit_message")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ReposCreateForAuthenticatedUserRequestMergeCommitMessageJsonConverter))]
        public global::G.ReposCreateForAuthenticatedUserRequestMergeCommitMessage? MergeCommitMessage { get; set; }

        /// <summary>
        /// Whether downloads are enabled.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_downloads")]
        public bool? HasDownloads { get; set; }

        /// <summary>
        /// Whether this repository acts as a template that can be used to generate new repositories.<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_template")]
        public bool? IsTemplate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposCreateForAuthenticatedUserRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the repository.<br/>
        /// Example: Team Environment
        /// </param>
        /// <param name="description">
        /// A short description of the repository.
        /// </param>
        /// <param name="homepage">
        /// A URL with more information about the repository.
        /// </param>
        /// <param name="private">
        /// Whether the repository is private.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="hasIssues">
        /// Whether issues are enabled.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="hasProjects">
        /// Whether projects are enabled.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="hasWiki">
        /// Whether the wiki is enabled.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="hasDiscussions">
        /// Whether discussions are enabled.<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </param>
        /// <param name="teamId">
        /// The id of the team that will be granted access to this repository. This is only valid when creating a repository in an organization.
        /// </param>
        /// <param name="autoInit">
        /// Whether the repository is initialized with a minimal README.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="gitignoreTemplate">
        /// The desired language or platform to apply to the .gitignore.<br/>
        /// Example: Haskell
        /// </param>
        /// <param name="licenseTemplate">
        /// The license keyword of the open source license for this repository.<br/>
        /// Example: mit
        /// </param>
        /// <param name="allowSquashMerge">
        /// Whether to allow squash merges for pull requests.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="allowMergeCommit">
        /// Whether to allow merge commits for pull requests.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="allowRebaseMerge">
        /// Whether to allow rebase merges for pull requests.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="allowAutoMerge">
        /// Whether to allow Auto-merge to be used on pull requests.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="deleteBranchOnMerge">
        /// Whether to delete head branches when pull requests are merged<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="squashMergeCommitTitle">
        /// Required when using `squash_merge_commit_message`.<br/>
        /// The default value for a squash merge commit title:<br/>
        /// - `PR_TITLE` - default to the pull request's title.<br/>
        /// - `COMMIT_OR_PR_TITLE` - default to the commit's title (if only one commit) or the pull request's title (when more than one commit).
        /// </param>
        /// <param name="squashMergeCommitMessage">
        /// The default value for a squash merge commit message:<br/>
        /// - `PR_BODY` - default to the pull request's body.<br/>
        /// - `COMMIT_MESSAGES` - default to the branch's commit messages.<br/>
        /// - `BLANK` - default to a blank commit message.
        /// </param>
        /// <param name="mergeCommitTitle">
        /// Required when using `merge_commit_message`.<br/>
        /// The default value for a merge commit title.<br/>
        /// - `PR_TITLE` - default to the pull request's title.<br/>
        /// - `MERGE_MESSAGE` - default to the classic title for a merge message (e.g., Merge pull request #123 from branch-name).
        /// </param>
        /// <param name="mergeCommitMessage">
        /// The default value for a merge commit message.<br/>
        /// - `PR_TITLE` - default to the pull request's title.<br/>
        /// - `PR_BODY` - default to the pull request's body.<br/>
        /// - `BLANK` - default to a blank commit message.
        /// </param>
        /// <param name="hasDownloads">
        /// Whether downloads are enabled.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="isTemplate">
        /// Whether this repository acts as a template that can be used to generate new repositories.<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReposCreateForAuthenticatedUserRequest(
            string name,
            string? description,
            string? homepage,
            bool? @private,
            bool? hasIssues,
            bool? hasProjects,
            bool? hasWiki,
            bool? hasDiscussions,
            int? teamId,
            bool? autoInit,
            string? gitignoreTemplate,
            string? licenseTemplate,
            bool? allowSquashMerge,
            bool? allowMergeCommit,
            bool? allowRebaseMerge,
            bool? allowAutoMerge,
            bool? deleteBranchOnMerge,
            global::G.ReposCreateForAuthenticatedUserRequestSquashMergeCommitTitle? squashMergeCommitTitle,
            global::G.ReposCreateForAuthenticatedUserRequestSquashMergeCommitMessage? squashMergeCommitMessage,
            global::G.ReposCreateForAuthenticatedUserRequestMergeCommitTitle? mergeCommitTitle,
            global::G.ReposCreateForAuthenticatedUserRequestMergeCommitMessage? mergeCommitMessage,
            bool? hasDownloads,
            bool? isTemplate)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Homepage = homepage;
            this.Private = @private;
            this.HasIssues = hasIssues;
            this.HasProjects = hasProjects;
            this.HasWiki = hasWiki;
            this.HasDiscussions = hasDiscussions;
            this.TeamId = teamId;
            this.AutoInit = autoInit;
            this.GitignoreTemplate = gitignoreTemplate;
            this.LicenseTemplate = licenseTemplate;
            this.AllowSquashMerge = allowSquashMerge;
            this.AllowMergeCommit = allowMergeCommit;
            this.AllowRebaseMerge = allowRebaseMerge;
            this.AllowAutoMerge = allowAutoMerge;
            this.DeleteBranchOnMerge = deleteBranchOnMerge;
            this.SquashMergeCommitTitle = squashMergeCommitTitle;
            this.SquashMergeCommitMessage = squashMergeCommitMessage;
            this.MergeCommitTitle = mergeCommitTitle;
            this.MergeCommitMessage = mergeCommitMessage;
            this.HasDownloads = hasDownloads;
            this.IsTemplate = isTemplate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposCreateForAuthenticatedUserRequest" /> class.
        /// </summary>
        public ReposCreateForAuthenticatedUserRequest()
        {
        }
    }
}
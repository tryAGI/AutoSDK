﻿//HintName: G.Models.ReposCreateForAuthenticatedUserRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposCreateForAuthenticatedUserRequest
    {
        /// <summary>
        /// The name of the repository.
        /// <br/>Example: Team Environment
        /// </summary>
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
        /// Whether the repository is private.
        /// <br/>Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        public bool Private { get; set; } = false;

        /// <summary>
        /// Whether issues are enabled.
        /// <br/>Default Value: true
        /// <br/>Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_issues")]
        public bool HasIssues { get; set; } = true;

        /// <summary>
        /// Whether projects are enabled.
        /// <br/>Default Value: true
        /// <br/>Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_projects")]
        public bool HasProjects { get; set; } = true;

        /// <summary>
        /// Whether the wiki is enabled.
        /// <br/>Default Value: true
        /// <br/>Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_wiki")]
        public bool HasWiki { get; set; } = true;

        /// <summary>
        /// Whether discussions are enabled.
        /// <br/>Default Value: false
        /// <br/>Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_discussions")]
        public bool HasDiscussions { get; set; } = false;

        /// <summary>
        /// The id of the team that will be granted access to this repository. This is only valid when creating a repository in an organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        public int TeamId { get; set; }

        /// <summary>
        /// Whether the repository is initialized with a minimal README.
        /// <br/>Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_init")]
        public bool AutoInit { get; set; } = false;

        /// <summary>
        /// The desired language or platform to apply to the .gitignore.
        /// <br/>Example: Haskell
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitignore_template")]
        public string? GitignoreTemplate { get; set; }

        /// <summary>
        /// The license keyword of the open source license for this repository.
        /// <br/>Example: mit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("license_template")]
        public string? LicenseTemplate { get; set; }

        /// <summary>
        /// Whether to allow squash merges for pull requests.
        /// <br/>Default Value: true
        /// <br/>Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_squash_merge")]
        public bool AllowSquashMerge { get; set; } = true;

        /// <summary>
        /// Whether to allow merge commits for pull requests.
        /// <br/>Default Value: true
        /// <br/>Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_merge_commit")]
        public bool AllowMergeCommit { get; set; } = true;

        /// <summary>
        /// Whether to allow rebase merges for pull requests.
        /// <br/>Default Value: true
        /// <br/>Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_rebase_merge")]
        public bool AllowRebaseMerge { get; set; } = true;

        /// <summary>
        /// Whether to allow Auto-merge to be used on pull requests.
        /// <br/>Default Value: false
        /// <br/>Example: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_auto_merge")]
        public bool AllowAutoMerge { get; set; } = false;

        /// <summary>
        /// Whether to delete head branches when pull requests are merged
        /// <br/>Default Value: false
        /// <br/>Example: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delete_branch_on_merge")]
        public bool DeleteBranchOnMerge { get; set; } = false;

        /// <summary>
        /// The default value for a squash merge commit title:
        /// - `PR_TITLE` - default to the pull request's title.
        /// - `COMMIT_OR_PR_TITLE` - default to the commit's title (if only one commit) or the pull request's title (when more than one commit).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("squash_merge_commit_title")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.ReposCreateForAuthenticatedUserRequestSquashMergeCommitTitleJsonConverter))]
        public ReposCreateForAuthenticatedUserRequestSquashMergeCommitTitle? SquashMergeCommitTitle { get; set; }

        /// <summary>
        /// The default value for a squash merge commit message:
        /// - `PR_BODY` - default to the pull request's body.
        /// - `COMMIT_MESSAGES` - default to the branch's commit messages.
        /// - `BLANK` - default to a blank commit message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("squash_merge_commit_message")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.ReposCreateForAuthenticatedUserRequestSquashMergeCommitMessageJsonConverter))]
        public ReposCreateForAuthenticatedUserRequestSquashMergeCommitMessage? SquashMergeCommitMessage { get; set; }

        /// <summary>
        /// The default value for a merge commit title.
        /// - `PR_TITLE` - default to the pull request's title.
        /// - `MERGE_MESSAGE` - default to the classic title for a merge message (e.g., Merge pull request #123 from branch-name).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merge_commit_title")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.ReposCreateForAuthenticatedUserRequestMergeCommitTitleJsonConverter))]
        public ReposCreateForAuthenticatedUserRequestMergeCommitTitle? MergeCommitTitle { get; set; }

        /// <summary>
        /// The default value for a merge commit message.
        /// - `PR_TITLE` - default to the pull request's title.
        /// - `PR_BODY` - default to the pull request's body.
        /// - `BLANK` - default to a blank commit message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merge_commit_message")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.ReposCreateForAuthenticatedUserRequestMergeCommitMessageJsonConverter))]
        public ReposCreateForAuthenticatedUserRequestMergeCommitMessage? MergeCommitMessage { get; set; }

        /// <summary>
        /// Whether downloads are enabled.
        /// <br/>Default Value: true
        /// <br/>Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_downloads")]
        public bool HasDownloads { get; set; } = true;

        /// <summary>
        /// Whether this repository acts as a template that can be used to generate new repositories.
        /// <br/>Default Value: false
        /// <br/>Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_template")]
        public bool IsTemplate { get; set; } = false;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
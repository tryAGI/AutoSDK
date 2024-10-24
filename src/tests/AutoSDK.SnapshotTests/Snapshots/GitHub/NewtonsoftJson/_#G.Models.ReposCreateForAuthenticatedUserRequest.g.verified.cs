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
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// A short description of the repository.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// A URL with more information about the repository.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("homepage")]
        public string? Homepage { get; set; }

        /// <summary>
        /// Whether the repository is private.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("private")]
        public bool? Private { get; set; }

        /// <summary>
        /// Whether issues are enabled.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_issues")]
        public bool? HasIssues { get; set; }

        /// <summary>
        /// Whether projects are enabled.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_projects")]
        public bool? HasProjects { get; set; }

        /// <summary>
        /// Whether the wiki is enabled.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_wiki")]
        public bool? HasWiki { get; set; }

        /// <summary>
        /// Whether discussions are enabled.<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_discussions")]
        public bool? HasDiscussions { get; set; }

        /// <summary>
        /// The id of the team that will be granted access to this repository. This is only valid when creating a repository in an organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("team_id")]
        public int? TeamId { get; set; }

        /// <summary>
        /// Whether the repository is initialized with a minimal README.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auto_init")]
        public bool? AutoInit { get; set; }

        /// <summary>
        /// The desired language or platform to apply to the .gitignore.<br/>
        /// Example: Haskell
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gitignore_template")]
        public string? GitignoreTemplate { get; set; }

        /// <summary>
        /// The license keyword of the open source license for this repository.<br/>
        /// Example: mit
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("license_template")]
        public string? LicenseTemplate { get; set; }

        /// <summary>
        /// Whether to allow squash merges for pull requests.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allow_squash_merge")]
        public bool? AllowSquashMerge { get; set; }

        /// <summary>
        /// Whether to allow merge commits for pull requests.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allow_merge_commit")]
        public bool? AllowMergeCommit { get; set; }

        /// <summary>
        /// Whether to allow rebase merges for pull requests.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allow_rebase_merge")]
        public bool? AllowRebaseMerge { get; set; }

        /// <summary>
        /// Whether to allow Auto-merge to be used on pull requests.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allow_auto_merge")]
        public bool? AllowAutoMerge { get; set; }

        /// <summary>
        /// Whether to delete head branches when pull requests are merged<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delete_branch_on_merge")]
        public bool? DeleteBranchOnMerge { get; set; }

        /// <summary>
        /// Required when using `squash_merge_commit_message`.<br/>
        /// The default value for a squash merge commit title:<br/>
        /// - `PR_TITLE` - default to the pull request's title.<br/>
        /// - `COMMIT_OR_PR_TITLE` - default to the commit's title (if only one commit) or the pull request's title (when more than one commit).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("squash_merge_commit_title")]
        public global::G.ReposCreateForAuthenticatedUserRequestSquashMergeCommitTitle? SquashMergeCommitTitle { get; set; }

        /// <summary>
        /// The default value for a squash merge commit message:<br/>
        /// - `PR_BODY` - default to the pull request's body.<br/>
        /// - `COMMIT_MESSAGES` - default to the branch's commit messages.<br/>
        /// - `BLANK` - default to a blank commit message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("squash_merge_commit_message")]
        public global::G.ReposCreateForAuthenticatedUserRequestSquashMergeCommitMessage? SquashMergeCommitMessage { get; set; }

        /// <summary>
        /// Required when using `merge_commit_message`.<br/>
        /// The default value for a merge commit title.<br/>
        /// - `PR_TITLE` - default to the pull request's title.<br/>
        /// - `MERGE_MESSAGE` - default to the classic title for a merge message (e.g., Merge pull request #123 from branch-name).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("merge_commit_title")]
        public global::G.ReposCreateForAuthenticatedUserRequestMergeCommitTitle? MergeCommitTitle { get; set; }

        /// <summary>
        /// The default value for a merge commit message.<br/>
        /// - `PR_TITLE` - default to the pull request's title.<br/>
        /// - `PR_BODY` - default to the pull request's body.<br/>
        /// - `BLANK` - default to a blank commit message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("merge_commit_message")]
        public global::G.ReposCreateForAuthenticatedUserRequestMergeCommitMessage? MergeCommitMessage { get; set; }

        /// <summary>
        /// Whether downloads are enabled.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_downloads")]
        public bool? HasDownloads { get; set; }

        /// <summary>
        /// Whether this repository acts as a template that can be used to generate new repositories.<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_template")]
        public bool? IsTemplate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


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
        public static global::G.ReposCreateForAuthenticatedUserRequest? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ReposCreateForAuthenticatedUserRequest>(
                json,
                jsonSerializerOptions);
        }

    }
}
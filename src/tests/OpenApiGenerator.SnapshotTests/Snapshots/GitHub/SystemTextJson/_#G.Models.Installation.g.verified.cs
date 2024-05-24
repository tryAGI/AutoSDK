//HintName: G.Models.Installation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Installation
    /// </summary>
    public sealed partial class Installation
    {
        /// <summary>
        /// The ID of the installation.
        /// <br/>Example: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object? Account { get; set; }

        /// <summary>
        /// Describe whether all repositories have been selected or there's a selection involved
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_selection")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RepositorySelection { get; set; }

        /// <summary>
        /// <br/>Example: https://api.github.com/app/installations/1/access_tokens
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_tokens_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccessTokensUrl { get; set; }

        /// <summary>
        /// <br/>Example: https://api.github.com/installation/repositories
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repositories_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RepositoriesUrl { get; set; }

        /// <summary>
        /// <br/>Example: https://github.com/organizations/github/settings/installations/1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// <br/>Example: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AppId { get; set; }

        /// <summary>
        /// The ID of the user or organization this token is being scoped to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TargetId { get; set; }

        /// <summary>
        /// <br/>Example: Organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetType { get; set; }

        /// <summary>
        /// The permissions granted to the user access token.
        /// <br/>Example: 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required AppPermissions Permissions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Events { get; set; }

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
        /// <br/>Example: config.yaml
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("single_file_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? SingleFileName { get; set; }

        /// <summary>
        /// <br/>Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_multiple_single_files")]
        public bool HasMultipleSingleFiles { get; set; }

        /// <summary>
        /// <br/>Example: [config.yml, .github/issue_TEMPLATE.md]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("single_file_paths")]
        public global::System.Collections.Generic.IList<string?>? SingleFilePaths { get; set; }

        /// <summary>
        /// <br/>Example: github-actions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app_slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AppSlug { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suspended_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required NullableSimpleUser? SuspendedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suspended_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? SuspendedAt { get; set; }

        /// <summary>
        /// <br/>Example: "test_13f1e99741e3e004@d7e1eb0bc0a1ba12.com"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contact_email")]
        public string? ContactEmail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
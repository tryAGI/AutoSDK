//HintName: G.Models.OrganizationProgrammaticAccessGrantRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Minimal representation of an organization programmatic access grant request for enumerations
    /// </summary>
    public sealed partial class OrganizationProgrammaticAccessGrantRequest
    {
        /// <summary>
        /// Unique identifier of the request for access via fine-grained personal access token. The `pat_request_id` used to review PAT requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// Reason for requesting access.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Reason { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required SimpleUser Owner { get; set; }

        /// <summary>
        /// Type of repository selection requested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_selection")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RepositorySelection { get; set; }

        /// <summary>
        /// URL to the list of repositories requested to be accessed via fine-grained personal access token. Should only be followed when `repository_selection` is `subset`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repositories_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RepositoriesUrl { get; set; }

        /// <summary>
        /// Permissions requested, categorized by type of permission.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required OrganizationProgrammaticAccessGrantRequestPermissions Permissions { get; set; }

        /// <summary>
        /// Date and time when the request for access was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Whether the associated fine-grained personal access token has expired.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_expired")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool TokenExpired { get; set; }

        /// <summary>
        /// Date and time when the associated fine-grained personal access token expires.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? TokenExpiresAt { get; set; }

        /// <summary>
        /// Date and time when the associated fine-grained personal access token was last used for authentication.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_last_used_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? TokenLastUsedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
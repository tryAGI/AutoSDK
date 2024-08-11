//HintName: G.Models.PersonalAccessTokenRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Details of a Personal Access Token Request.
    /// </summary>
    public sealed partial class PersonalAccessTokenRequest
    {
        /// <summary>
        /// Unique identifier of the request for access via fine-grained personal access token. Used as the `pat_request_id` parameter in the list and review API calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SimpleUser? Owner { get; set; }

        /// <summary>
        /// New requested permissions, categorized by type of permission.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions_added")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PersonalAccessTokenRequestPermissionsAdded PermissionsAdded { get; set; }

        /// <summary>
        /// Requested permissions that elevate access for a previously approved request for access, categorized by type of permission.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions_upgraded")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PersonalAccessTokenRequestPermissionsUpgraded PermissionsUpgraded { get; set; }

        /// <summary>
        /// Permissions requested, categorized by type of permission. This field incorporates `permissions_added` and `permissions_upgraded`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions_result")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PersonalAccessTokenRequestPermissionsResult PermissionsResult { get; set; }

        /// <summary>
        /// Type of repository selection requested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_selection")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.PersonalAccessTokenRequestRepositorySelectionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PersonalAccessTokenRequestRepositorySelection RepositorySelection { get; set; }

        /// <summary>
        /// The number of repositories the token is requesting access to. This field is only populated when `repository_selection` is `subset`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? RepositoryCount { get; set; }

        /// <summary>
        /// An array of repository objects the token is requesting access to. This field is only populated when `repository_selection` is `subset`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repositories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.PersonalAccessTokenRequestRepositorie>? Repositories { get; set; }

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
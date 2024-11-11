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
        public required global::G.SimpleUser Owner { get; set; }

        /// <summary>
        /// Type of repository selection requested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_selection")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OrganizationProgrammaticAccessGrantRequestRepositorySelectionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OrganizationProgrammaticAccessGrantRequestRepositorySelection RepositorySelection { get; set; }

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
        public required global::G.OrganizationProgrammaticAccessGrantRequestPermissions Permissions { get; set; }

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

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationProgrammaticAccessGrantRequest" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the request for access via fine-grained personal access token. The `pat_request_id` used to review PAT requests.
        /// </param>
        /// <param name="reason">
        /// Reason for requesting access.
        /// </param>
        /// <param name="owner">
        /// A GitHub user.
        /// </param>
        /// <param name="repositorySelection">
        /// Type of repository selection requested.
        /// </param>
        /// <param name="repositoriesUrl">
        /// URL to the list of repositories requested to be accessed via fine-grained personal access token. Should only be followed when `repository_selection` is `subset`.
        /// </param>
        /// <param name="permissions">
        /// Permissions requested, categorized by type of permission.
        /// </param>
        /// <param name="createdAt">
        /// Date and time when the request for access was created.
        /// </param>
        /// <param name="tokenExpired">
        /// Whether the associated fine-grained personal access token has expired.
        /// </param>
        /// <param name="tokenExpiresAt">
        /// Date and time when the associated fine-grained personal access token expires.
        /// </param>
        /// <param name="tokenLastUsedAt">
        /// Date and time when the associated fine-grained personal access token was last used for authentication.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public OrganizationProgrammaticAccessGrantRequest(
            int id,
            string? reason,
            global::G.SimpleUser owner,
            global::G.OrganizationProgrammaticAccessGrantRequestRepositorySelection repositorySelection,
            string repositoriesUrl,
            global::G.OrganizationProgrammaticAccessGrantRequestPermissions permissions,
            string createdAt,
            bool tokenExpired,
            string? tokenExpiresAt,
            string? tokenLastUsedAt)
        {
            this.Id = id;
            this.Reason = reason ?? throw new global::System.ArgumentNullException(nameof(reason));
            this.Owner = owner ?? throw new global::System.ArgumentNullException(nameof(owner));
            this.RepositorySelection = repositorySelection;
            this.RepositoriesUrl = repositoriesUrl ?? throw new global::System.ArgumentNullException(nameof(repositoriesUrl));
            this.Permissions = permissions ?? throw new global::System.ArgumentNullException(nameof(permissions));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.TokenExpired = tokenExpired;
            this.TokenExpiresAt = tokenExpiresAt ?? throw new global::System.ArgumentNullException(nameof(tokenExpiresAt));
            this.TokenLastUsedAt = tokenLastUsedAt ?? throw new global::System.ArgumentNullException(nameof(tokenLastUsedAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationProgrammaticAccessGrantRequest" /> class.
        /// </summary>
        public OrganizationProgrammaticAccessGrantRequest()
        {
        }
    }
}
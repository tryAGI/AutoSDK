//HintName: G.Models.OrganizationProgrammaticAccessGrant.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Minimal representation of an organization programmatic access grant for enumerations
    /// </summary>
    public sealed partial class OrganizationProgrammaticAccessGrant
    {
        /// <summary>
        /// Unique identifier of the fine-grained personal access token. The `pat_id` used to get details about an approved fine-grained personal access token.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SimpleUser Owner { get; set; } = default!;

        /// <summary>
        /// Type of repository selection requested.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository_selection", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OrganizationProgrammaticAccessGrantRepositorySelection RepositorySelection { get; set; } = default!;

        /// <summary>
        /// URL to the list of repositories the fine-grained personal access token can access. Only follow when `repository_selection` is `subset`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repositories_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string RepositoriesUrl { get; set; } = default!;

        /// <summary>
        /// Permissions requested, categorized by type of permission.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permissions", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OrganizationProgrammaticAccessGrantPermissions Permissions { get; set; } = default!;

        /// <summary>
        /// Date and time when the fine-grained personal access token was approved to access the organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("access_granted_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string AccessGrantedAt { get; set; } = default!;

        /// <summary>
        /// Whether the associated fine-grained personal access token has expired.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token_expired", Required = global::Newtonsoft.Json.Required.Always)]
        public bool TokenExpired { get; set; } = default!;

        /// <summary>
        /// Date and time when the associated fine-grained personal access token expires.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token_expires_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string? TokenExpiresAt { get; set; } = default!;

        /// <summary>
        /// Date and time when the associated fine-grained personal access token was last used for authentication.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token_last_used_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string? TokenLastUsedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationProgrammaticAccessGrant" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the fine-grained personal access token. The `pat_id` used to get details about an approved fine-grained personal access token.
        /// </param>
        /// <param name="owner">
        /// A GitHub user.
        /// </param>
        /// <param name="repositorySelection">
        /// Type of repository selection requested.
        /// </param>
        /// <param name="repositoriesUrl">
        /// URL to the list of repositories the fine-grained personal access token can access. Only follow when `repository_selection` is `subset`.
        /// </param>
        /// <param name="permissions">
        /// Permissions requested, categorized by type of permission.
        /// </param>
        /// <param name="accessGrantedAt">
        /// Date and time when the fine-grained personal access token was approved to access the organization.
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
        public OrganizationProgrammaticAccessGrant(
            int id,
            global::G.SimpleUser owner,
            global::G.OrganizationProgrammaticAccessGrantRepositorySelection repositorySelection,
            string repositoriesUrl,
            global::G.OrganizationProgrammaticAccessGrantPermissions permissions,
            string accessGrantedAt,
            bool tokenExpired,
            string? tokenExpiresAt,
            string? tokenLastUsedAt)
        {
            this.Id = id;
            this.Owner = owner ?? throw new global::System.ArgumentNullException(nameof(owner));
            this.RepositorySelection = repositorySelection;
            this.RepositoriesUrl = repositoriesUrl ?? throw new global::System.ArgumentNullException(nameof(repositoriesUrl));
            this.Permissions = permissions ?? throw new global::System.ArgumentNullException(nameof(permissions));
            this.AccessGrantedAt = accessGrantedAt ?? throw new global::System.ArgumentNullException(nameof(accessGrantedAt));
            this.TokenExpired = tokenExpired;
            this.TokenExpiresAt = tokenExpiresAt ?? throw new global::System.ArgumentNullException(nameof(tokenExpiresAt));
            this.TokenLastUsedAt = tokenLastUsedAt ?? throw new global::System.ArgumentNullException(nameof(tokenLastUsedAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationProgrammaticAccessGrant" /> class.
        /// </summary>
        public OrganizationProgrammaticAccessGrant()
        {
        }
    }
}
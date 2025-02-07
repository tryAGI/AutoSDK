//HintName: G.Models.OrganizationActionsSecret.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Secrets for GitHub Actions for an organization.
    /// </summary>
    public sealed partial class OrganizationActionsSecret
    {
        /// <summary>
        /// The name of the secret.<br/>
        /// Example: SECRET_TOKEN
        /// </summary>
        /// <example>SECRET_TOKEN</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

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
        /// Visibility of a secret
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OrganizationActionsSecretVisibilityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OrganizationActionsSecretVisibility Visibility { get; set; }

        /// <summary>
        /// Example: https://api.github.com/organizations/org/secrets/my_secret/repositories
        /// </summary>
        /// <example>https://api.github.com/organizations/org/secrets/my_secret/repositories</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("selected_repositories_url")]
        public string? SelectedRepositoriesUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationActionsSecret" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the secret.<br/>
        /// Example: SECRET_TOKEN
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="visibility">
        /// Visibility of a secret
        /// </param>
        /// <param name="selectedRepositoriesUrl">
        /// Example: https://api.github.com/organizations/org/secrets/my_secret/repositories
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationActionsSecret(
            string name,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::G.OrganizationActionsSecretVisibility visibility,
            string? selectedRepositoriesUrl)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Visibility = visibility;
            this.SelectedRepositoriesUrl = selectedRepositoriesUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationActionsSecret" /> class.
        /// </summary>
        public OrganizationActionsSecret()
        {
        }
    }
}
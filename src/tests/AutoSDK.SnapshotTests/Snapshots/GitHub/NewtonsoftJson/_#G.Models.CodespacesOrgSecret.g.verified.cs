//HintName: G.Models.CodespacesOrgSecret.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Secrets for a GitHub Codespace.
    /// </summary>
    public sealed partial class CodespacesOrgSecret
    {
        /// <summary>
        /// The name of the secret<br/>
        /// Example: SECRET_NAME
        /// </summary>
        /// <example>SECRET_NAME</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The date and time at which the secret was created, in ISO 8601 format':' YYYY-MM-DDTHH:MM:SSZ.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// The date and time at which the secret was created, in ISO 8601 format':' YYYY-MM-DDTHH:MM:SSZ.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// The type of repositories in the organization that the secret is visible to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("visibility", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CodespacesOrgSecretVisibility Visibility { get; set; } = default!;

        /// <summary>
        /// The API URL at which the list of repositories this secret is visible to can be retrieved<br/>
        /// Example: https://api.github.com/orgs/ORGANIZATION/codespaces/secrets/SECRET_NAME/repositories
        /// </summary>
        /// <example>https://api.github.com/orgs/ORGANIZATION/codespaces/secrets/SECRET_NAME/repositories</example>
        [global::Newtonsoft.Json.JsonProperty("selected_repositories_url")]
        public string? SelectedRepositoriesUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespacesOrgSecret" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the secret<br/>
        /// Example: SECRET_NAME
        /// </param>
        /// <param name="createdAt">
        /// The date and time at which the secret was created, in ISO 8601 format':' YYYY-MM-DDTHH:MM:SSZ.
        /// </param>
        /// <param name="updatedAt">
        /// The date and time at which the secret was created, in ISO 8601 format':' YYYY-MM-DDTHH:MM:SSZ.
        /// </param>
        /// <param name="visibility">
        /// The type of repositories in the organization that the secret is visible to
        /// </param>
        /// <param name="selectedRepositoriesUrl">
        /// The API URL at which the list of repositories this secret is visible to can be retrieved<br/>
        /// Example: https://api.github.com/orgs/ORGANIZATION/codespaces/secrets/SECRET_NAME/repositories
        /// </param>
        public CodespacesOrgSecret(
            string name,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::G.CodespacesOrgSecretVisibility visibility,
            string? selectedRepositoriesUrl)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Visibility = visibility;
            this.SelectedRepositoriesUrl = selectedRepositoriesUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespacesOrgSecret" /> class.
        /// </summary>
        public CodespacesOrgSecret()
        {
        }
    }
}
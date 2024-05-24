//HintName: G.Models.OrganizationDependabotSecret.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Secrets for GitHub Dependabot for an organization.
    /// </summary>
    public sealed partial class OrganizationDependabotSecret
    {
        /// <summary>
        /// The name of the secret.
        /// <br/>Example: SECRET_TOKEN
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Visibility of a secret
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("visibility", Required = global::Newtonsoft.Json.Required.Always)]
        public OrganizationDependabotSecretVisibility Visibility { get; set; } = default!;

        /// <summary>
        /// <br/>Example: https://api.github.com/organizations/org/dependabot/secrets/my_secret/repositories
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("selected_repositories_url")]
        public string? SelectedRepositoriesUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
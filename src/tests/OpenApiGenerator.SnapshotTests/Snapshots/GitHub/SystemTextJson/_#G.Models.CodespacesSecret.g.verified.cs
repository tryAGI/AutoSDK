//HintName: G.Models.CodespacesSecret.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Secrets for a GitHub Codespace.
    /// </summary>
    public sealed partial class CodespacesSecret
    {
        /// <summary>
        /// The name of the secret<br/>
        /// Example: SECRET_NAME
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The date and time at which the secret was created, in ISO 8601 format':' YYYY-MM-DDTHH:MM:SSZ.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The date and time at which the secret was last updated, in ISO 8601 format':' YYYY-MM-DDTHH:MM:SSZ.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// The type of repositories in the organization that the secret is visible to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.CodespacesSecretVisibilityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CodespacesSecretVisibility Visibility { get; set; }

        /// <summary>
        /// The API URL at which the list of repositories this secret is visible to can be retrieved<br/>
        /// Example: https://api.github.com/user/secrets/SECRET_NAME/repositories
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selected_repositories_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SelectedRepositoriesUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
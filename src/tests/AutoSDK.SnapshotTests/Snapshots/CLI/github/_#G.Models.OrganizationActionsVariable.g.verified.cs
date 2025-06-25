//HintName: G.Models.OrganizationActionsVariable.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Organization variable for GitHub Actions.
    /// </summary>
    public sealed partial class OrganizationActionsVariable
    {
        /// <summary>
        /// The name of the variable.<br/>
        /// Example: USERNAME
        /// </summary>
        /// <example>USERNAME</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The value of the variable.<br/>
        /// Example: octocat
        /// </summary>
        /// <example>octocat</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// The date and time at which the variable was created, in ISO 8601 format':' YYYY-MM-DDTHH:MM:SSZ.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The date and time at which the variable was last updated, in ISO 8601 format':' YYYY-MM-DDTHH:MM:SSZ.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Visibility of a variable
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OrganizationActionsVariableVisibilityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OrganizationActionsVariableVisibility Visibility { get; set; }

        /// <summary>
        /// Example: https://api.github.com/organizations/org/variables/USERNAME/repositories
        /// </summary>
        /// <example>https://api.github.com/organizations/org/variables/USERNAME/repositories</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("selected_repositories_url")]
        public string? SelectedRepositoriesUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationActionsVariable" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the variable.<br/>
        /// Example: USERNAME
        /// </param>
        /// <param name="value">
        /// The value of the variable.<br/>
        /// Example: octocat
        /// </param>
        /// <param name="createdAt">
        /// The date and time at which the variable was created, in ISO 8601 format':' YYYY-MM-DDTHH:MM:SSZ.
        /// </param>
        /// <param name="updatedAt">
        /// The date and time at which the variable was last updated, in ISO 8601 format':' YYYY-MM-DDTHH:MM:SSZ.
        /// </param>
        /// <param name="visibility">
        /// Visibility of a variable
        /// </param>
        /// <param name="selectedRepositoriesUrl">
        /// Example: https://api.github.com/organizations/org/variables/USERNAME/repositories
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationActionsVariable(
            string name,
            string value,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::G.OrganizationActionsVariableVisibility visibility,
            string? selectedRepositoriesUrl)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Visibility = visibility;
            this.SelectedRepositoriesUrl = selectedRepositoriesUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationActionsVariable" /> class.
        /// </summary>
        public OrganizationActionsVariable()
        {
        }
    }
}
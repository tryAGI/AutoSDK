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
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The value of the variable.<br/>
        /// Example: octocat
        /// </summary>
        /// <example>octocat</example>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public string Value { get; set; } = default!;

        /// <summary>
        /// The date and time at which the variable was created, in ISO 8601 format':' YYYY-MM-DDTHH:MM:SSZ.<br/>
        /// Example: 2019-01-24T22:45:36.000Z
        /// </summary>
        /// <example>2019-01-24T22:45:36.000Z</example>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// The date and time at which the variable was last updated, in ISO 8601 format':' YYYY-MM-DDTHH:MM:SSZ.<br/>
        /// Example: 2019-01-24T22:45:36.000Z
        /// </summary>
        /// <example>2019-01-24T22:45:36.000Z</example>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Visibility of a variable
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("visibility", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OrganizationActionsVariableVisibility Visibility { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/organizations/org/variables/USERNAME/repositories
        /// </summary>
        /// <example>https://api.github.com/organizations/org/variables/USERNAME/repositories</example>
        [global::Newtonsoft.Json.JsonProperty("selected_repositories_url")]
        public string? SelectedRepositoriesUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
        /// The date and time at which the variable was created, in ISO 8601 format':' YYYY-MM-DDTHH:MM:SSZ.<br/>
        /// Example: 2019-01-24T22:45:36.000Z
        /// </param>
        /// <param name="updatedAt">
        /// The date and time at which the variable was last updated, in ISO 8601 format':' YYYY-MM-DDTHH:MM:SSZ.<br/>
        /// Example: 2019-01-24T22:45:36.000Z
        /// </param>
        /// <param name="visibility">
        /// Visibility of a variable
        /// </param>
        /// <param name="selectedRepositoriesUrl">
        /// Example: https://api.github.com/organizations/org/variables/USERNAME/repositories
        /// </param>
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
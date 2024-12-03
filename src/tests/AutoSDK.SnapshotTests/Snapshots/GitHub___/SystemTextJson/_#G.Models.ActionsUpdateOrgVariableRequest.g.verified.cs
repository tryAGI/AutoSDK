//HintName: G.Models.ActionsUpdateOrgVariableRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsUpdateOrgVariableRequest
    {
        /// <summary>
        /// The name of the variable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The value of the variable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// The type of repositories in the organization that can access the variable. `selected` means only the repositories specified by `selected_repository_ids` can access the variable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ActionsUpdateOrgVariableRequestVisibilityJsonConverter))]
        public global::G.ActionsUpdateOrgVariableRequestVisibility? Visibility { get; set; }

        /// <summary>
        /// An array of repository ids that can access the organization variable. You can only provide a list of repository ids when the `visibility` is set to `selected`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selected_repository_ids")]
        public global::System.Collections.Generic.IList<int>? SelectedRepositoryIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsUpdateOrgVariableRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the variable.
        /// </param>
        /// <param name="value">
        /// The value of the variable.
        /// </param>
        /// <param name="visibility">
        /// The type of repositories in the organization that can access the variable. `selected` means only the repositories specified by `selected_repository_ids` can access the variable.
        /// </param>
        /// <param name="selectedRepositoryIds">
        /// An array of repository ids that can access the organization variable. You can only provide a list of repository ids when the `visibility` is set to `selected`.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ActionsUpdateOrgVariableRequest(
            string? name,
            string? value,
            global::G.ActionsUpdateOrgVariableRequestVisibility? visibility,
            global::System.Collections.Generic.IList<int>? selectedRepositoryIds)
        {
            this.Name = name;
            this.Value = value;
            this.Visibility = visibility;
            this.SelectedRepositoryIds = selectedRepositoryIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsUpdateOrgVariableRequest" /> class.
        /// </summary>
        public ActionsUpdateOrgVariableRequest()
        {
        }
    }
}
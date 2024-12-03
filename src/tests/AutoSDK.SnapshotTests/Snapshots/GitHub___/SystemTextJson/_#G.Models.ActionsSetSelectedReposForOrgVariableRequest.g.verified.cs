//HintName: G.Models.ActionsSetSelectedReposForOrgVariableRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsSetSelectedReposForOrgVariableRequest
    {
        /// <summary>
        /// The IDs of the repositories that can access the organization variable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selected_repository_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> SelectedRepositoryIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsSetSelectedReposForOrgVariableRequest" /> class.
        /// </summary>
        /// <param name="selectedRepositoryIds">
        /// The IDs of the repositories that can access the organization variable.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ActionsSetSelectedReposForOrgVariableRequest(
            global::System.Collections.Generic.IList<int> selectedRepositoryIds)
        {
            this.SelectedRepositoryIds = selectedRepositoryIds ?? throw new global::System.ArgumentNullException(nameof(selectedRepositoryIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsSetSelectedReposForOrgVariableRequest" /> class.
        /// </summary>
        public ActionsSetSelectedReposForOrgVariableRequest()
        {
        }
    }
}
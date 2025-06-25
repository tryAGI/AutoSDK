//HintName: G.Models.ActionsSetSelectedRepositoriesEnabledGithubActionsOrganizationRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsSetSelectedRepositoriesEnabledGithubActionsOrganizationRequest
    {
        /// <summary>
        /// List of repository IDs to enable for GitHub Actions.
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
        /// Initializes a new instance of the <see cref="ActionsSetSelectedRepositoriesEnabledGithubActionsOrganizationRequest" /> class.
        /// </summary>
        /// <param name="selectedRepositoryIds">
        /// List of repository IDs to enable for GitHub Actions.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActionsSetSelectedRepositoriesEnabledGithubActionsOrganizationRequest(
            global::System.Collections.Generic.IList<int> selectedRepositoryIds)
        {
            this.SelectedRepositoryIds = selectedRepositoryIds ?? throw new global::System.ArgumentNullException(nameof(selectedRepositoryIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsSetSelectedRepositoriesEnabledGithubActionsOrganizationRequest" /> class.
        /// </summary>
        public ActionsSetSelectedRepositoriesEnabledGithubActionsOrganizationRequest()
        {
        }
    }
}
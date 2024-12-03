//HintName: G.Models.ActionsListSelectedRepositoriesEnabledGithubActionsOrganizationResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsListSelectedRepositoriesEnabledGithubActionsOrganizationResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repositories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Repository> Repositories { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsListSelectedRepositoriesEnabledGithubActionsOrganizationResponse" /> class.
        /// </summary>
        /// <param name="totalCount"></param>
        /// <param name="repositories"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ActionsListSelectedRepositoriesEnabledGithubActionsOrganizationResponse(
            double totalCount,
            global::System.Collections.Generic.IList<global::G.Repository> repositories)
        {
            this.TotalCount = totalCount;
            this.Repositories = repositories ?? throw new global::System.ArgumentNullException(nameof(repositories));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsListSelectedRepositoriesEnabledGithubActionsOrganizationResponse" /> class.
        /// </summary>
        public ActionsListSelectedRepositoriesEnabledGithubActionsOrganizationResponse()
        {
        }
    }
}
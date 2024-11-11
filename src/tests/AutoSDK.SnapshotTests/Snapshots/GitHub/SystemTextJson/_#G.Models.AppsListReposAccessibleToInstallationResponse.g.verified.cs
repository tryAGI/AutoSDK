//HintName: G.Models.AppsListReposAccessibleToInstallationResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppsListReposAccessibleToInstallationResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repositories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Repository> Repositories { get; set; }

        /// <summary>
        /// Example: selected
        /// </summary>
        /// <example>selected</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_selection")]
        public string? RepositorySelection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppsListReposAccessibleToInstallationResponse" /> class.
        /// </summary>
        /// <param name="totalCount"></param>
        /// <param name="repositories"></param>
        /// <param name="repositorySelection">
        /// Example: selected
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public AppsListReposAccessibleToInstallationResponse(
            int totalCount,
            global::System.Collections.Generic.IList<global::G.Repository> repositories,
            string? repositorySelection)
        {
            this.TotalCount = totalCount;
            this.Repositories = repositories ?? throw new global::System.ArgumentNullException(nameof(repositories));
            this.RepositorySelection = repositorySelection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppsListReposAccessibleToInstallationResponse" /> class.
        /// </summary>
        public AppsListReposAccessibleToInstallationResponse()
        {
        }
    }
}
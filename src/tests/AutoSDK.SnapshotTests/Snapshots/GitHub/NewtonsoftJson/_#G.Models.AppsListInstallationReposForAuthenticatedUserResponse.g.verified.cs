//HintName: G.Models.AppsListInstallationReposForAuthenticatedUserResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppsListInstallationReposForAuthenticatedUserResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository_selection")]
        public string? RepositorySelection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repositories", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Repository> Repositories { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppsListInstallationReposForAuthenticatedUserResponse" /> class.
        /// </summary>
        /// <param name="totalCount"></param>
        /// <param name="repositorySelection"></param>
        /// <param name="repositories"></param>
        public AppsListInstallationReposForAuthenticatedUserResponse(
            int totalCount,
            global::System.Collections.Generic.IList<global::G.Repository> repositories,
            string? repositorySelection)
        {
            this.TotalCount = totalCount;
            this.Repositories = repositories ?? throw new global::System.ArgumentNullException(nameof(repositories));
            this.RepositorySelection = repositorySelection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppsListInstallationReposForAuthenticatedUserResponse" /> class.
        /// </summary>
        public AppsListInstallationReposForAuthenticatedUserResponse()
        {
        }
    }
}
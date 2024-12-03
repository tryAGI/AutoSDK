//HintName: G.Models.CodeScanningVariantAnalysisSkippedRepositoriesNotFoundRepos.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeScanningVariantAnalysisSkippedRepositoriesNotFoundRepos
    {
        /// <summary>
        /// The total number of repositories that were skipped for this reason.<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::Newtonsoft.Json.JsonProperty("repository_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int RepositoryCount { get; set; } = default!;

        /// <summary>
        /// A list of full repository names that were skipped. This list may not include all repositories that were skipped.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository_full_names", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> RepositoryFullNames { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningVariantAnalysisSkippedRepositoriesNotFoundRepos" /> class.
        /// </summary>
        /// <param name="repositoryCount">
        /// The total number of repositories that were skipped for this reason.<br/>
        /// Example: 2
        /// </param>
        /// <param name="repositoryFullNames">
        /// A list of full repository names that were skipped. This list may not include all repositories that were skipped.
        /// </param>
        public CodeScanningVariantAnalysisSkippedRepositoriesNotFoundRepos(
            int repositoryCount,
            global::System.Collections.Generic.IList<string> repositoryFullNames)
        {
            this.RepositoryCount = repositoryCount;
            this.RepositoryFullNames = repositoryFullNames ?? throw new global::System.ArgumentNullException(nameof(repositoryFullNames));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningVariantAnalysisSkippedRepositoriesNotFoundRepos" /> class.
        /// </summary>
        public CodeScanningVariantAnalysisSkippedRepositoriesNotFoundRepos()
        {
        }
    }
}
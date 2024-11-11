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
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RepositoryCount { get; set; }

        /// <summary>
        /// A list of full repository names that were skipped. This list may not include all repositories that were skipped.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_full_names")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> RepositoryFullNames { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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
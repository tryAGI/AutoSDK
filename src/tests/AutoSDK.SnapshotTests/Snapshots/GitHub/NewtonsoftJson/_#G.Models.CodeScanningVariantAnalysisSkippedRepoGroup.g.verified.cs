//HintName: G.Models.CodeScanningVariantAnalysisSkippedRepoGroup.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeScanningVariantAnalysisSkippedRepoGroup
    {
        /// <summary>
        /// The total number of repositories that were skipped for this reason.<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::Newtonsoft.Json.JsonProperty("repository_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int RepositoryCount { get; set; } = default!;

        /// <summary>
        /// A list of repositories that were skipped. This list may not include all repositories that were skipped. This is only available when the repository was found and the user has access to it.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repositories", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CodeScanningVariantAnalysisRepository> Repositories { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningVariantAnalysisSkippedRepoGroup" /> class.
        /// </summary>
        /// <param name="repositoryCount">
        /// The total number of repositories that were skipped for this reason.<br/>
        /// Example: 2
        /// </param>
        /// <param name="repositories">
        /// A list of repositories that were skipped. This list may not include all repositories that were skipped. This is only available when the repository was found and the user has access to it.
        /// </param>
        public CodeScanningVariantAnalysisSkippedRepoGroup(
            int repositoryCount,
            global::System.Collections.Generic.IList<global::G.CodeScanningVariantAnalysisRepository> repositories)
        {
            this.RepositoryCount = repositoryCount;
            this.Repositories = repositories ?? throw new global::System.ArgumentNullException(nameof(repositories));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningVariantAnalysisSkippedRepoGroup" /> class.
        /// </summary>
        public CodeScanningVariantAnalysisSkippedRepoGroup()
        {
        }
    }
}
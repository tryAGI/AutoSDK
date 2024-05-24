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
        /// The total number of repositories that were skipped for this reason.
        /// <br/>Example: 2
        /// </summary>
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
    }
}
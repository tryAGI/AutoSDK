//HintName: G.Models.CodeScanningVariantAnalysisSkippedRepositories.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Information about repositories that were skipped from processing. This information is only available to the user that initiated the variant analysis.
    /// </summary>
    public sealed partial class CodeScanningVariantAnalysisSkippedRepositories
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_mismatch_repos")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required CodeScanningVariantAnalysisSkippedRepoGroup AccessMismatchRepos { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("not_found_repos")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required CodeScanningVariantAnalysisSkippedRepositoriesNotFoundRepos NotFoundRepos { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("no_codeql_db_repos")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required CodeScanningVariantAnalysisSkippedRepoGroup NoCodeqlDbRepos { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("over_limit_repos")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required CodeScanningVariantAnalysisSkippedRepoGroup OverLimitRepos { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
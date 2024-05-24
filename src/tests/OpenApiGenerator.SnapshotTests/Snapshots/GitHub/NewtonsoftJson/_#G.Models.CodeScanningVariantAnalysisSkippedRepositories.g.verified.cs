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
        [global::Newtonsoft.Json.JsonProperty("access_mismatch_repos", Required = global::Newtonsoft.Json.Required.Always)]
        public CodeScanningVariantAnalysisSkippedRepoGroup AccessMismatchRepos { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("not_found_repos", Required = global::Newtonsoft.Json.Required.Always)]
        public CodeScanningVariantAnalysisSkippedRepositoriesNotFoundRepos NotFoundRepos { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("no_codeql_db_repos", Required = global::Newtonsoft.Json.Required.Always)]
        public CodeScanningVariantAnalysisSkippedRepoGroup NoCodeqlDbRepos { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("over_limit_repos", Required = global::Newtonsoft.Json.Required.Always)]
        public CodeScanningVariantAnalysisSkippedRepoGroup OverLimitRepos { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
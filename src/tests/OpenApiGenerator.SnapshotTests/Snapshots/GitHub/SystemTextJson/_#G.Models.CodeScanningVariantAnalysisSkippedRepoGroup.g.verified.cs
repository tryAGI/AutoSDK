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
        /// The total number of repositories that were skipped for this reason.
        /// <br/>Example: 2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RepositoryCount { get; set; }

        /// <summary>
        /// A list of repositories that were skipped. This list may not include all repositories that were skipped. This is only available when the repository was found and the user has access to it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repositories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<CodeScanningVariantAnalysisRepository> Repositories { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
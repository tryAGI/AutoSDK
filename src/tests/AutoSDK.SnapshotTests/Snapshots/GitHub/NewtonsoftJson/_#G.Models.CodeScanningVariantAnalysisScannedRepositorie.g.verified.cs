//HintName: G.Models.CodeScanningVariantAnalysisScannedRepositorie.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeScanningVariantAnalysisScannedRepositorie
    {
        /// <summary>
        /// Repository Identifier
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CodeScanningVariantAnalysisRepository Repository { get; set; } = default!;

        /// <summary>
        /// The new status of the CodeQL variant analysis repository task.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("analysis_status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CodeScanningVariantAnalysisStatus AnalysisStatus { get; set; } = default!;

        /// <summary>
        /// The number of results in the case of a successful analysis. This is only available for successful analyses.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result_count")]
        public int ResultCount { get; set; }

        /// <summary>
        /// The size of the artifact. This is only available for successful analyses.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("artifact_size_in_bytes")]
        public int ArtifactSizeInBytes { get; set; }

        /// <summary>
        /// The reason of the failure of this repo task. This is only available if the repository task has failed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("failure_message")]
        public string? FailureMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
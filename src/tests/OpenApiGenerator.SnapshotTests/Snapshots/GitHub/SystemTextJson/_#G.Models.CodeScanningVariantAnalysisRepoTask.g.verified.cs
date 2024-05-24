//HintName: G.Models.CodeScanningVariantAnalysisRepoTask.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeScanningVariantAnalysisRepoTask
    {
        /// <summary>
        /// A GitHub repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required SimpleRepository Repository { get; set; }

        /// <summary>
        /// The new status of the CodeQL variant analysis repository task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analysis_status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AnalysisStatus { get; set; }

        /// <summary>
        /// The size of the artifact. This is only available for successful analyses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artifact_size_in_bytes")]
        public int ArtifactSizeInBytes { get; set; }

        /// <summary>
        /// The number of results in the case of a successful analysis. This is only available for successful analyses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_count")]
        public int ResultCount { get; set; }

        /// <summary>
        /// The reason of the failure of this repo task. This is only available if the repository task has failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failure_message")]
        public string? FailureMessage { get; set; }

        /// <summary>
        /// The SHA of the commit the CodeQL database was built against. This is only available for successful analyses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("database_commit_sha")]
        public string? DatabaseCommitSha { get; set; }

        /// <summary>
        /// The source location prefix to use. This is only available for successful analyses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_location_prefix")]
        public string? SourceLocationPrefix { get; set; }

        /// <summary>
        /// The URL of the artifact. This is only available for successful analyses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artifact_url")]
        public string? ArtifactUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
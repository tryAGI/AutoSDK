﻿//HintName: G.Models.CodeScanningVariantAnalysisRepoTask.g.cs

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
        [global::Newtonsoft.Json.JsonProperty("repository", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SimpleRepository Repository { get; set; } = default!;

        /// <summary>
        /// The new status of the CodeQL variant analysis repository task.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("analysis_status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CodeScanningVariantAnalysisStatus AnalysisStatus { get; set; } = default!;

        /// <summary>
        /// The size of the artifact. This is only available for successful analyses.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("artifact_size_in_bytes")]
        public int? ArtifactSizeInBytes { get; set; }

        /// <summary>
        /// The number of results in the case of a successful analysis. This is only available for successful analyses.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result_count")]
        public int? ResultCount { get; set; }

        /// <summary>
        /// The reason of the failure of this repo task. This is only available if the repository task has failed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("failure_message")]
        public string? FailureMessage { get; set; }

        /// <summary>
        /// The SHA of the commit the CodeQL database was built against. This is only available for successful analyses.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("database_commit_sha")]
        public string? DatabaseCommitSha { get; set; }

        /// <summary>
        /// The source location prefix to use. This is only available for successful analyses.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_location_prefix")]
        public string? SourceLocationPrefix { get; set; }

        /// <summary>
        /// The URL of the artifact. This is only available for successful analyses.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("artifact_url")]
        public string? ArtifactUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningVariantAnalysisRepoTask" /> class.
        /// </summary>
        /// <param name="repository">
        /// A GitHub repository.
        /// </param>
        /// <param name="analysisStatus">
        /// The new status of the CodeQL variant analysis repository task.
        /// </param>
        /// <param name="artifactSizeInBytes">
        /// The size of the artifact. This is only available for successful analyses.
        /// </param>
        /// <param name="resultCount">
        /// The number of results in the case of a successful analysis. This is only available for successful analyses.
        /// </param>
        /// <param name="failureMessage">
        /// The reason of the failure of this repo task. This is only available if the repository task has failed.
        /// </param>
        /// <param name="databaseCommitSha">
        /// The SHA of the commit the CodeQL database was built against. This is only available for successful analyses.
        /// </param>
        /// <param name="sourceLocationPrefix">
        /// The source location prefix to use. This is only available for successful analyses.
        /// </param>
        /// <param name="artifactUrl">
        /// The URL of the artifact. This is only available for successful analyses.
        /// </param>
        public CodeScanningVariantAnalysisRepoTask(
            global::G.SimpleRepository repository,
            global::G.CodeScanningVariantAnalysisStatus analysisStatus,
            int? artifactSizeInBytes,
            int? resultCount,
            string? failureMessage,
            string? databaseCommitSha,
            string? sourceLocationPrefix,
            string? artifactUrl)
        {
            this.Repository = repository ?? throw new global::System.ArgumentNullException(nameof(repository));
            this.AnalysisStatus = analysisStatus;
            this.ArtifactSizeInBytes = artifactSizeInBytes;
            this.ResultCount = resultCount;
            this.FailureMessage = failureMessage;
            this.DatabaseCommitSha = databaseCommitSha;
            this.SourceLocationPrefix = sourceLocationPrefix;
            this.ArtifactUrl = artifactUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningVariantAnalysisRepoTask" /> class.
        /// </summary>
        public CodeScanningVariantAnalysisRepoTask()
        {
        }
    }
}
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
        public required global::G.SimpleRepository Repository { get; set; }

        /// <summary>
        /// The new status of the CodeQL variant analysis repository task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analysis_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CodeScanningVariantAnalysisStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CodeScanningVariantAnalysisStatus AnalysisStatus { get; set; }

        /// <summary>
        /// The size of the artifact. This is only available for successful analyses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artifact_size_in_bytes")]
        public int? ArtifactSizeInBytes { get; set; }

        /// <summary>
        /// The number of results in the case of a successful analysis. This is only available for successful analyses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_count")]
        public int? ResultCount { get; set; }

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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::G.CodeScanningVariantAnalysisRepoTask? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.CodeScanningVariantAnalysisRepoTask),
                jsonSerializerContext) as global::G.CodeScanningVariantAnalysisRepoTask;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.CodeScanningVariantAnalysisRepoTask? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.CodeScanningVariantAnalysisRepoTask>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.CodeScanningVariantAnalysisRepoTask?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.CodeScanningVariantAnalysisRepoTask),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.CodeScanningVariantAnalysisRepoTask;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.CodeScanningVariantAnalysisRepoTask?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.CodeScanningVariantAnalysisRepoTask?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}
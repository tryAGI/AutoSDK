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
        public int? ResultCount { get; set; }

        /// <summary>
        /// The size of the artifact. This is only available for successful analyses.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("artifact_size_in_bytes")]
        public int? ArtifactSizeInBytes { get; set; }

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

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningVariantAnalysisScannedRepositorie" /> class.
        /// </summary>
        /// <param name="repository">
        /// Repository Identifier
        /// </param>
        /// <param name="analysisStatus">
        /// The new status of the CodeQL variant analysis repository task.
        /// </param>
        /// <param name="resultCount">
        /// The number of results in the case of a successful analysis. This is only available for successful analyses.
        /// </param>
        /// <param name="artifactSizeInBytes">
        /// The size of the artifact. This is only available for successful analyses.
        /// </param>
        /// <param name="failureMessage">
        /// The reason of the failure of this repo task. This is only available if the repository task has failed.
        /// </param>
        public CodeScanningVariantAnalysisScannedRepositorie(
            global::G.CodeScanningVariantAnalysisRepository repository,
            global::G.CodeScanningVariantAnalysisStatus analysisStatus,
            int? resultCount,
            int? artifactSizeInBytes,
            string? failureMessage)
        {
            this.Repository = repository ?? throw new global::System.ArgumentNullException(nameof(repository));
            this.AnalysisStatus = analysisStatus;
            this.ResultCount = resultCount;
            this.ArtifactSizeInBytes = artifactSizeInBytes;
            this.FailureMessage = failureMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningVariantAnalysisScannedRepositorie" /> class.
        /// </summary>
        public CodeScanningVariantAnalysisScannedRepositorie()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.CodeScanningVariantAnalysisScannedRepositorie? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.CodeScanningVariantAnalysisScannedRepositorie>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.CodeScanningVariantAnalysisScannedRepositorie?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.CodeScanningVariantAnalysisScannedRepositorie?>(serializer.Deserialize<global::G.CodeScanningVariantAnalysisScannedRepositorie>(jsonReader));
        }

    }
}
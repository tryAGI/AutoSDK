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
        public static global::G.CodeScanningVariantAnalysisSkippedRepoGroup? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.CodeScanningVariantAnalysisSkippedRepoGroup>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.CodeScanningVariantAnalysisSkippedRepoGroup?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.CodeScanningVariantAnalysisSkippedRepoGroup?>(serializer.Deserialize<global::G.CodeScanningVariantAnalysisSkippedRepoGroup>(jsonReader));
        }

    }
}
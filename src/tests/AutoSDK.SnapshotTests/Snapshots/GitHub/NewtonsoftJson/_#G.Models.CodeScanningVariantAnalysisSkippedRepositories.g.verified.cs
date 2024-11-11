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
        public global::G.CodeScanningVariantAnalysisSkippedRepoGroup AccessMismatchRepos { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("not_found_repos", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CodeScanningVariantAnalysisSkippedRepositoriesNotFoundRepos NotFoundRepos { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("no_codeql_db_repos", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CodeScanningVariantAnalysisSkippedRepoGroup NoCodeqlDbRepos { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("over_limit_repos", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CodeScanningVariantAnalysisSkippedRepoGroup OverLimitRepos { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningVariantAnalysisSkippedRepositories" /> class.
        /// </summary>
        /// <param name="accessMismatchRepos"></param>
        /// <param name="notFoundRepos"></param>
        /// <param name="noCodeqlDbRepos"></param>
        /// <param name="overLimitRepos"></param>
        public CodeScanningVariantAnalysisSkippedRepositories(
            global::G.CodeScanningVariantAnalysisSkippedRepoGroup accessMismatchRepos,
            global::G.CodeScanningVariantAnalysisSkippedRepositoriesNotFoundRepos notFoundRepos,
            global::G.CodeScanningVariantAnalysisSkippedRepoGroup noCodeqlDbRepos,
            global::G.CodeScanningVariantAnalysisSkippedRepoGroup overLimitRepos)
        {
            this.AccessMismatchRepos = accessMismatchRepos ?? throw new global::System.ArgumentNullException(nameof(accessMismatchRepos));
            this.NotFoundRepos = notFoundRepos ?? throw new global::System.ArgumentNullException(nameof(notFoundRepos));
            this.NoCodeqlDbRepos = noCodeqlDbRepos ?? throw new global::System.ArgumentNullException(nameof(noCodeqlDbRepos));
            this.OverLimitRepos = overLimitRepos ?? throw new global::System.ArgumentNullException(nameof(overLimitRepos));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningVariantAnalysisSkippedRepositories" /> class.
        /// </summary>
        public CodeScanningVariantAnalysisSkippedRepositories()
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
        public static global::G.CodeScanningVariantAnalysisSkippedRepositories? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.CodeScanningVariantAnalysisSkippedRepositories>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.CodeScanningVariantAnalysisSkippedRepositories?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.CodeScanningVariantAnalysisSkippedRepositories?>(serializer.Deserialize<global::G.CodeScanningVariantAnalysisSkippedRepositories>(jsonReader));
        }

    }
}
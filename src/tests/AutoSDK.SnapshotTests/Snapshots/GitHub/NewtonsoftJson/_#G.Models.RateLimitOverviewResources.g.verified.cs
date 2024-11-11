//HintName: G.Models.RateLimitOverviewResources.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RateLimitOverviewResources
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("core", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RateLimit Core { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("graphql")]
        public global::G.RateLimit? Graphql { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("search", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RateLimit Search { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code_search")]
        public global::G.RateLimit? CodeSearch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_import")]
        public global::G.RateLimit? SourceImport { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("integration_manifest")]
        public global::G.RateLimit? IntegrationManifest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code_scanning_upload")]
        public global::G.RateLimit? CodeScanningUpload { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("actions_runner_registration")]
        public global::G.RateLimit? ActionsRunnerRegistration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scim")]
        public global::G.RateLimit? Scim { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dependency_snapshots")]
        public global::G.RateLimit? DependencySnapshots { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimitOverviewResources" /> class.
        /// </summary>
        /// <param name="core"></param>
        /// <param name="graphql"></param>
        /// <param name="search"></param>
        /// <param name="codeSearch"></param>
        /// <param name="sourceImport"></param>
        /// <param name="integrationManifest"></param>
        /// <param name="codeScanningUpload"></param>
        /// <param name="actionsRunnerRegistration"></param>
        /// <param name="scim"></param>
        /// <param name="dependencySnapshots"></param>
        public RateLimitOverviewResources(
            global::G.RateLimit core,
            global::G.RateLimit search,
            global::G.RateLimit? graphql,
            global::G.RateLimit? codeSearch,
            global::G.RateLimit? sourceImport,
            global::G.RateLimit? integrationManifest,
            global::G.RateLimit? codeScanningUpload,
            global::G.RateLimit? actionsRunnerRegistration,
            global::G.RateLimit? scim,
            global::G.RateLimit? dependencySnapshots)
        {
            this.Core = core ?? throw new global::System.ArgumentNullException(nameof(core));
            this.Search = search ?? throw new global::System.ArgumentNullException(nameof(search));
            this.Graphql = graphql;
            this.CodeSearch = codeSearch;
            this.SourceImport = sourceImport;
            this.IntegrationManifest = integrationManifest;
            this.CodeScanningUpload = codeScanningUpload;
            this.ActionsRunnerRegistration = actionsRunnerRegistration;
            this.Scim = scim;
            this.DependencySnapshots = dependencySnapshots;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimitOverviewResources" /> class.
        /// </summary>
        public RateLimitOverviewResources()
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
        public static global::G.RateLimitOverviewResources? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.RateLimitOverviewResources>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.RateLimitOverviewResources?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.RateLimitOverviewResources?>(serializer.Deserialize<global::G.RateLimitOverviewResources>(jsonReader));
        }

    }
}
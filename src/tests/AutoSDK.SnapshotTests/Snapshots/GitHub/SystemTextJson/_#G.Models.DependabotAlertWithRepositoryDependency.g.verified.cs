//HintName: G.Models.DependabotAlertWithRepositoryDependency.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Details for the vulnerable dependency.<br/>
    /// Included only in responses
    /// </summary>
    public sealed partial class DependabotAlertWithRepositoryDependency
    {
        /// <summary>
        /// Details for the vulnerable package.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("package")]
        public global::G.DependabotAlertPackage? Package { get; set; }

        /// <summary>
        /// The full path to the dependency manifest file, relative to the root of the repository.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manifest_path")]
        public string? ManifestPath { get; set; }

        /// <summary>
        /// The execution scope of the vulnerable dependency.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DependabotAlertWithRepositoryDependencyScopeJsonConverter))]
        public global::G.DependabotAlertWithRepositoryDependencyScope? Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DependabotAlertWithRepositoryDependency" /> class.
        /// </summary>
        /// <param name="package">
        /// Details for the vulnerable package.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="manifestPath">
        /// The full path to the dependency manifest file, relative to the root of the repository.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="scope">
        /// The execution scope of the vulnerable dependency.<br/>
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public DependabotAlertWithRepositoryDependency(
            global::G.DependabotAlertPackage? package,
            string? manifestPath,
            global::G.DependabotAlertWithRepositoryDependencyScope? scope)
        {
            this.Package = package;
            this.ManifestPath = manifestPath;
            this.Scope = scope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DependabotAlertWithRepositoryDependency" /> class.
        /// </summary>
        public DependabotAlertWithRepositoryDependency()
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
        public static global::G.DependabotAlertWithRepositoryDependency? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.DependabotAlertWithRepositoryDependency),
                jsonSerializerContext) as global::G.DependabotAlertWithRepositoryDependency;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.DependabotAlertWithRepositoryDependency? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.DependabotAlertWithRepositoryDependency>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.DependabotAlertWithRepositoryDependency?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.DependabotAlertWithRepositoryDependency),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.DependabotAlertWithRepositoryDependency;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.DependabotAlertWithRepositoryDependency?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.DependabotAlertWithRepositoryDependency?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}
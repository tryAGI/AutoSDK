//HintName: G.Models.RepositoryAdvisoryUpdateVulnerabilitie.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RepositoryAdvisoryUpdateVulnerabilitie
    {
        /// <summary>
        /// The name of the package affected by the vulnerability.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("package")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RepositoryAdvisoryUpdateVulnerabilitiePackage Package { get; set; }

        /// <summary>
        /// The range of the package versions affected by the vulnerability.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vulnerable_version_range")]
        public string? VulnerableVersionRange { get; set; }

        /// <summary>
        /// The package version(s) that resolve the vulnerability.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("patched_versions")]
        public string? PatchedVersions { get; set; }

        /// <summary>
        /// The functions in the package that are affected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vulnerable_functions")]
        public global::System.Collections.Generic.IList<string>? VulnerableFunctions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryAdvisoryUpdateVulnerabilitie" /> class.
        /// </summary>
        /// <param name="package">
        /// The name of the package affected by the vulnerability.
        /// </param>
        /// <param name="vulnerableVersionRange">
        /// The range of the package versions affected by the vulnerability.
        /// </param>
        /// <param name="patchedVersions">
        /// The package version(s) that resolve the vulnerability.
        /// </param>
        /// <param name="vulnerableFunctions">
        /// The functions in the package that are affected.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RepositoryAdvisoryUpdateVulnerabilitie(
            global::G.RepositoryAdvisoryUpdateVulnerabilitiePackage package,
            string? vulnerableVersionRange,
            string? patchedVersions,
            global::System.Collections.Generic.IList<string>? vulnerableFunctions)
        {
            this.Package = package ?? throw new global::System.ArgumentNullException(nameof(package));
            this.VulnerableVersionRange = vulnerableVersionRange;
            this.PatchedVersions = patchedVersions;
            this.VulnerableFunctions = vulnerableFunctions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryAdvisoryUpdateVulnerabilitie" /> class.
        /// </summary>
        public RepositoryAdvisoryUpdateVulnerabilitie()
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
        public static global::G.RepositoryAdvisoryUpdateVulnerabilitie? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.RepositoryAdvisoryUpdateVulnerabilitie),
                jsonSerializerContext) as global::G.RepositoryAdvisoryUpdateVulnerabilitie;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.RepositoryAdvisoryUpdateVulnerabilitie? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryAdvisoryUpdateVulnerabilitie>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.RepositoryAdvisoryUpdateVulnerabilitie?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.RepositoryAdvisoryUpdateVulnerabilitie),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.RepositoryAdvisoryUpdateVulnerabilitie;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.RepositoryAdvisoryUpdateVulnerabilitie?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.RepositoryAdvisoryUpdateVulnerabilitie?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}
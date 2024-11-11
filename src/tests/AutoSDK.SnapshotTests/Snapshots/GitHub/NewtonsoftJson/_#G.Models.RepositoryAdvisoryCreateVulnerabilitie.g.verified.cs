//HintName: G.Models.RepositoryAdvisoryCreateVulnerabilitie.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RepositoryAdvisoryCreateVulnerabilitie
    {
        /// <summary>
        /// The name of the package affected by the vulnerability.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("package", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RepositoryAdvisoryCreateVulnerabilitiePackage Package { get; set; } = default!;

        /// <summary>
        /// The range of the package versions affected by the vulnerability.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vulnerable_version_range")]
        public string? VulnerableVersionRange { get; set; }

        /// <summary>
        /// The package version(s) that resolve the vulnerability.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("patched_versions")]
        public string? PatchedVersions { get; set; }

        /// <summary>
        /// The functions in the package that are affected.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vulnerable_functions")]
        public global::System.Collections.Generic.IList<string>? VulnerableFunctions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryAdvisoryCreateVulnerabilitie" /> class.
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
        public RepositoryAdvisoryCreateVulnerabilitie(
            global::G.RepositoryAdvisoryCreateVulnerabilitiePackage package,
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
        /// Initializes a new instance of the <see cref="RepositoryAdvisoryCreateVulnerabilitie" /> class.
        /// </summary>
        public RepositoryAdvisoryCreateVulnerabilitie()
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
        public static global::G.RepositoryAdvisoryCreateVulnerabilitie? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.RepositoryAdvisoryCreateVulnerabilitie>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.RepositoryAdvisoryCreateVulnerabilitie?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.RepositoryAdvisoryCreateVulnerabilitie?>(serializer.Deserialize<global::G.RepositoryAdvisoryCreateVulnerabilitie>(jsonReader));
        }

    }
}
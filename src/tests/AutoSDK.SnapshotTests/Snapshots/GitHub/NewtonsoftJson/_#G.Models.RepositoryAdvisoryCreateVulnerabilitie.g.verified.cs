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

    }
}
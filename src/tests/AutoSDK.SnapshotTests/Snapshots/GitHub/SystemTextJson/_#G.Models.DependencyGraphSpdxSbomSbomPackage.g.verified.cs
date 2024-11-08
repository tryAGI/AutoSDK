//HintName: G.Models.DependencyGraphSpdxSbomSbomPackage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DependencyGraphSpdxSbomSbomPackage
    {
        /// <summary>
        /// A unique SPDX identifier for the package.<br/>
        /// Example: SPDXRef-Package
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("SPDXID")]
        public string? SPDXID { get; set; }

        /// <summary>
        /// The name of the package.<br/>
        /// Example: rubygems:github/github
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The version of the package. If the package does not have an exact version specified,<br/>
        /// a version range is given.<br/>
        /// Example: 1.0.0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versionInfo")]
        public string? VersionInfo { get; set; }

        /// <summary>
        /// The location where the package can be downloaded,<br/>
        /// or NOASSERTION if this has not been determined.<br/>
        /// Example: NOASSERTION
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("downloadLocation")]
        public string? DownloadLocation { get; set; }

        /// <summary>
        /// Whether the package's file content has been subjected to<br/>
        /// analysis during the creation of the SPDX document.<br/>
        /// Example: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filesAnalyzed")]
        public bool? FilesAnalyzed { get; set; }

        /// <summary>
        /// The license of the package as determined while creating the SPDX document.<br/>
        /// Example: MIT
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("licenseConcluded")]
        public string? LicenseConcluded { get; set; }

        /// <summary>
        /// The license of the package as declared by its author, or NOASSERTION if this information<br/>
        /// was not available when the SPDX document was created.<br/>
        /// Example: NOASSERTION
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("licenseDeclared")]
        public string? LicenseDeclared { get; set; }

        /// <summary>
        /// The distribution source of this package, or NOASSERTION if this was not determined.<br/>
        /// Example: NOASSERTION
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supplier")]
        public string? Supplier { get; set; }

        /// <summary>
        /// The copyright holders of the package, and any dates present with those notices, if available.<br/>
        /// Example: Copyright (c) 1985 GitHub.com
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("copyrightText")]
        public string? CopyrightText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalRefs")]
        public global::System.Collections.Generic.IList<global::G.DependencyGraphSpdxSbomSbomPackageExternalRef>? ExternalRefs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


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
        public static global::G.DependencyGraphSpdxSbomSbomPackage? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.DependencyGraphSpdxSbomSbomPackage),
                jsonSerializerContext) as global::G.DependencyGraphSpdxSbomSbomPackage;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.DependencyGraphSpdxSbomSbomPackage? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.DependencyGraphSpdxSbomSbomPackage>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.DependencyGraphSpdxSbomSbomPackage?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.DependencyGraphSpdxSbomSbomPackage),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.DependencyGraphSpdxSbomSbomPackage;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.DependencyGraphSpdxSbomSbomPackage?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.DependencyGraphSpdxSbomSbomPackage?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}
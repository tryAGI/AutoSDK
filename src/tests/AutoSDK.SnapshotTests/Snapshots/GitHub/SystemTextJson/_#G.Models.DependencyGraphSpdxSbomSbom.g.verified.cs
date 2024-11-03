//HintName: G.Models.DependencyGraphSpdxSbomSbom.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DependencyGraphSpdxSbomSbom
    {
        /// <summary>
        /// The SPDX identifier for the SPDX document.<br/>
        /// Example: SPDXRef-DOCUMENT
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("SPDXID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SPDXID { get; set; }

        /// <summary>
        /// The version of the SPDX specification that this document conforms to.<br/>
        /// Example: SPDX-2.3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spdxVersion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SpdxVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creationInfo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DependencyGraphSpdxSbomSbomCreationInfo CreationInfo { get; set; }

        /// <summary>
        /// The name of the SPDX document.<br/>
        /// Example: github/github
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The license under which the SPDX document is licensed.<br/>
        /// Example: CC0-1.0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataLicense")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DataLicense { get; set; }

        /// <summary>
        /// The name of the repository that the SPDX document describes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documentDescribes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> DocumentDescribes { get; set; }

        /// <summary>
        /// The namespace for the SPDX document.<br/>
        /// Example: https://github.com/example/dependency_graph/sbom-123
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documentNamespace")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DocumentNamespace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.DependencyGraphSpdxSbomSbomPackage> Packages { get; set; }

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
        public static global::G.DependencyGraphSpdxSbomSbom? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.DependencyGraphSpdxSbomSbom),
                jsonSerializerContext) as global::G.DependencyGraphSpdxSbomSbom;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.DependencyGraphSpdxSbomSbom? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.DependencyGraphSpdxSbomSbom>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.DependencyGraphSpdxSbomSbom?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.DependencyGraphSpdxSbomSbom),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.DependencyGraphSpdxSbomSbom;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.DependencyGraphSpdxSbomSbom?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.DependencyGraphSpdxSbomSbom?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}
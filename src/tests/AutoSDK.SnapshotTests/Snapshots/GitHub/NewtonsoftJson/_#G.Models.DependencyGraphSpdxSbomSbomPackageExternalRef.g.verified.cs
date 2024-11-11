//HintName: G.Models.DependencyGraphSpdxSbomSbomPackageExternalRef.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DependencyGraphSpdxSbomSbomPackageExternalRef
    {
        /// <summary>
        /// The category of reference to an external resource this reference refers to.<br/>
        /// Example: PACKAGE-MANAGER
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("referenceCategory", Required = global::Newtonsoft.Json.Required.Always)]
        public string ReferenceCategory { get; set; } = default!;

        /// <summary>
        /// A locator for the particular external resource this reference refers to.<br/>
        /// Example: pkg:gem/rails@6.0.1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("referenceLocator", Required = global::Newtonsoft.Json.Required.Always)]
        public string ReferenceLocator { get; set; } = default!;

        /// <summary>
        /// The category of reference to an external resource this reference refers to.<br/>
        /// Example: purl
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("referenceType", Required = global::Newtonsoft.Json.Required.Always)]
        public string ReferenceType { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DependencyGraphSpdxSbomSbomPackageExternalRef" /> class.
        /// </summary>
        /// <param name="referenceCategory">
        /// The category of reference to an external resource this reference refers to.<br/>
        /// Example: PACKAGE-MANAGER
        /// </param>
        /// <param name="referenceLocator">
        /// A locator for the particular external resource this reference refers to.<br/>
        /// Example: pkg:gem/rails@6.0.1
        /// </param>
        /// <param name="referenceType">
        /// The category of reference to an external resource this reference refers to.<br/>
        /// Example: purl
        /// </param>
        public DependencyGraphSpdxSbomSbomPackageExternalRef(
            string referenceCategory,
            string referenceLocator,
            string referenceType)
        {
            this.ReferenceCategory = referenceCategory ?? throw new global::System.ArgumentNullException(nameof(referenceCategory));
            this.ReferenceLocator = referenceLocator ?? throw new global::System.ArgumentNullException(nameof(referenceLocator));
            this.ReferenceType = referenceType ?? throw new global::System.ArgumentNullException(nameof(referenceType));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DependencyGraphSpdxSbomSbomPackageExternalRef" /> class.
        /// </summary>
        public DependencyGraphSpdxSbomSbomPackageExternalRef()
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
        public static global::G.DependencyGraphSpdxSbomSbomPackageExternalRef? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.DependencyGraphSpdxSbomSbomPackageExternalRef>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.DependencyGraphSpdxSbomSbomPackageExternalRef?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.DependencyGraphSpdxSbomSbomPackageExternalRef?>(serializer.Deserialize<global::G.DependencyGraphSpdxSbomSbomPackageExternalRef>(jsonReader));
        }

    }
}
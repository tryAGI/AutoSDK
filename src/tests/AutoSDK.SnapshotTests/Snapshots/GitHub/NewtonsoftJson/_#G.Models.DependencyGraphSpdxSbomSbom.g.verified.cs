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
        [global::Newtonsoft.Json.JsonProperty("SPDXID", Required = global::Newtonsoft.Json.Required.Always)]
        public string SPDXID { get; set; } = default!;

        /// <summary>
        /// The version of the SPDX specification that this document conforms to.<br/>
        /// Example: SPDX-2.3
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("spdxVersion", Required = global::Newtonsoft.Json.Required.Always)]
        public string SpdxVersion { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creationInfo", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DependencyGraphSpdxSbomSbomCreationInfo CreationInfo { get; set; } = default!;

        /// <summary>
        /// The name of the SPDX document.<br/>
        /// Example: github/github
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The license under which the SPDX document is licensed.<br/>
        /// Example: CC0-1.0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataLicense", Required = global::Newtonsoft.Json.Required.Always)]
        public string DataLicense { get; set; } = default!;

        /// <summary>
        /// The name of the repository that the SPDX document describes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("documentDescribes", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> DocumentDescribes { get; set; } = default!;

        /// <summary>
        /// The namespace for the SPDX document.<br/>
        /// Example: https://github.com/example/dependency_graph/sbom-123
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("documentNamespace", Required = global::Newtonsoft.Json.Required.Always)]
        public string DocumentNamespace { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("packages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.DependencyGraphSpdxSbomSbomPackage> Packages { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DependencyGraphSpdxSbomSbom" /> class.
        /// </summary>
        /// <param name="sPDXID">
        /// The SPDX identifier for the SPDX document.<br/>
        /// Example: SPDXRef-DOCUMENT
        /// </param>
        /// <param name="spdxVersion">
        /// The version of the SPDX specification that this document conforms to.<br/>
        /// Example: SPDX-2.3
        /// </param>
        /// <param name="creationInfo"></param>
        /// <param name="name">
        /// The name of the SPDX document.<br/>
        /// Example: github/github
        /// </param>
        /// <param name="dataLicense">
        /// The license under which the SPDX document is licensed.<br/>
        /// Example: CC0-1.0
        /// </param>
        /// <param name="documentDescribes">
        /// The name of the repository that the SPDX document describes.
        /// </param>
        /// <param name="documentNamespace">
        /// The namespace for the SPDX document.<br/>
        /// Example: https://github.com/example/dependency_graph/sbom-123
        /// </param>
        /// <param name="packages"></param>
        public DependencyGraphSpdxSbomSbom(
            string sPDXID,
            string spdxVersion,
            global::G.DependencyGraphSpdxSbomSbomCreationInfo creationInfo,
            string name,
            string dataLicense,
            global::System.Collections.Generic.IList<string> documentDescribes,
            string documentNamespace,
            global::System.Collections.Generic.IList<global::G.DependencyGraphSpdxSbomSbomPackage> packages)
        {
            this.SPDXID = sPDXID ?? throw new global::System.ArgumentNullException(nameof(sPDXID));
            this.SpdxVersion = spdxVersion ?? throw new global::System.ArgumentNullException(nameof(spdxVersion));
            this.CreationInfo = creationInfo ?? throw new global::System.ArgumentNullException(nameof(creationInfo));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.DataLicense = dataLicense ?? throw new global::System.ArgumentNullException(nameof(dataLicense));
            this.DocumentDescribes = documentDescribes ?? throw new global::System.ArgumentNullException(nameof(documentDescribes));
            this.DocumentNamespace = documentNamespace ?? throw new global::System.ArgumentNullException(nameof(documentNamespace));
            this.Packages = packages ?? throw new global::System.ArgumentNullException(nameof(packages));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DependencyGraphSpdxSbomSbom" /> class.
        /// </summary>
        public DependencyGraphSpdxSbomSbom()
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
        public static global::G.DependencyGraphSpdxSbomSbom? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.DependencyGraphSpdxSbomSbom>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.DependencyGraphSpdxSbomSbom?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.DependencyGraphSpdxSbomSbom?>(serializer.Deserialize<global::G.DependencyGraphSpdxSbomSbom>(jsonReader));
        }

    }
}
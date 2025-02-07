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
        /// <example>SPDXRef-DOCUMENT</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("SPDXID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SPDXID { get; set; }

        /// <summary>
        /// The version of the SPDX specification that this document conforms to.<br/>
        /// Example: SPDX-2.3
        /// </summary>
        /// <example>SPDX-2.3</example>
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
        /// <example>github/github</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The license under which the SPDX document is licensed.<br/>
        /// Example: CC0-1.0
        /// </summary>
        /// <example>CC0-1.0</example>
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
        /// <example>https://github.com/example/dependency_graph/sbom-123</example>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
    }
}
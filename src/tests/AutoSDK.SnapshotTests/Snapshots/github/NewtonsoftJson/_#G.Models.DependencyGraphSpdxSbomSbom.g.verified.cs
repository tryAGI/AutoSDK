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
        [global::Newtonsoft.Json.JsonProperty("SPDXID", Required = global::Newtonsoft.Json.Required.Always)]
        public string SPDXID { get; set; } = default!;

        /// <summary>
        /// The version of the SPDX specification that this document conforms to.<br/>
        /// Example: SPDX-2.3
        /// </summary>
        /// <example>SPDX-2.3</example>
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
        /// <example>github/github</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The license under which the SPDX document is licensed.<br/>
        /// Example: CC0-1.0
        /// </summary>
        /// <example>CC0-1.0</example>
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
        /// <example>https://github.com/example/dependency_graph/sbom-123</example>
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
    }
}
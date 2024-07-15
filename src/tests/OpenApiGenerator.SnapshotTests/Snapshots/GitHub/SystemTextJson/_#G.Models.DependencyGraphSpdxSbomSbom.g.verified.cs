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
        public required global::System.Collections.Generic.IList<global::G.DependencyGraphSpdxSbomSbomPackages> Packages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
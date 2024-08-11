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
        public bool FilesAnalyzed { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalRefs")]
        public global::System.Collections.Generic.IList<global::G.DependencyGraphSpdxSbomSbomPackageExternalRef>? ExternalRefs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
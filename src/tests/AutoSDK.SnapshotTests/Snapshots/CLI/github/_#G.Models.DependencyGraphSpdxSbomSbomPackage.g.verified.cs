﻿//HintName: G.Models.DependencyGraphSpdxSbomSbomPackage.g.cs

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
        /// <example>SPDXRef-Package</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("SPDXID")]
        public string? SPDXID { get; set; }

        /// <summary>
        /// The name of the package.<br/>
        /// Example: rubygems:github/github
        /// </summary>
        /// <example>rubygems:github/github</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The version of the package. If the package does not have an exact version specified,<br/>
        /// a version range is given.<br/>
        /// Example: 1.0.0
        /// </summary>
        /// <example>1.0.0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("versionInfo")]
        public string? VersionInfo { get; set; }

        /// <summary>
        /// The location where the package can be downloaded,<br/>
        /// or NOASSERTION if this has not been determined.<br/>
        /// Example: NOASSERTION
        /// </summary>
        /// <example>NOASSERTION</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("downloadLocation")]
        public string? DownloadLocation { get; set; }

        /// <summary>
        /// Whether the package's file content has been subjected to<br/>
        /// analysis during the creation of the SPDX document.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("filesAnalyzed")]
        public bool? FilesAnalyzed { get; set; }

        /// <summary>
        /// The license of the package as determined while creating the SPDX document.<br/>
        /// Example: MIT
        /// </summary>
        /// <example>MIT</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("licenseConcluded")]
        public string? LicenseConcluded { get; set; }

        /// <summary>
        /// The license of the package as declared by its author, or NOASSERTION if this information<br/>
        /// was not available when the SPDX document was created.<br/>
        /// Example: NOASSERTION
        /// </summary>
        /// <example>NOASSERTION</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("licenseDeclared")]
        public string? LicenseDeclared { get; set; }

        /// <summary>
        /// The distribution source of this package, or NOASSERTION if this was not determined.<br/>
        /// Example: NOASSERTION
        /// </summary>
        /// <example>NOASSERTION</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("supplier")]
        public string? Supplier { get; set; }

        /// <summary>
        /// The copyright holders of the package, and any dates present with those notices, if available.<br/>
        /// Example: Copyright (c) 1985 GitHub.com
        /// </summary>
        /// <example>Copyright (c) 1985 GitHub.com</example>
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
        /// Initializes a new instance of the <see cref="DependencyGraphSpdxSbomSbomPackage" /> class.
        /// </summary>
        /// <param name="sPDXID">
        /// A unique SPDX identifier for the package.<br/>
        /// Example: SPDXRef-Package
        /// </param>
        /// <param name="name">
        /// The name of the package.<br/>
        /// Example: rubygems:github/github
        /// </param>
        /// <param name="versionInfo">
        /// The version of the package. If the package does not have an exact version specified,<br/>
        /// a version range is given.<br/>
        /// Example: 1.0.0
        /// </param>
        /// <param name="downloadLocation">
        /// The location where the package can be downloaded,<br/>
        /// or NOASSERTION if this has not been determined.<br/>
        /// Example: NOASSERTION
        /// </param>
        /// <param name="filesAnalyzed">
        /// Whether the package's file content has been subjected to<br/>
        /// analysis during the creation of the SPDX document.<br/>
        /// Example: false
        /// </param>
        /// <param name="licenseConcluded">
        /// The license of the package as determined while creating the SPDX document.<br/>
        /// Example: MIT
        /// </param>
        /// <param name="licenseDeclared">
        /// The license of the package as declared by its author, or NOASSERTION if this information<br/>
        /// was not available when the SPDX document was created.<br/>
        /// Example: NOASSERTION
        /// </param>
        /// <param name="supplier">
        /// The distribution source of this package, or NOASSERTION if this was not determined.<br/>
        /// Example: NOASSERTION
        /// </param>
        /// <param name="copyrightText">
        /// The copyright holders of the package, and any dates present with those notices, if available.<br/>
        /// Example: Copyright (c) 1985 GitHub.com
        /// </param>
        /// <param name="externalRefs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DependencyGraphSpdxSbomSbomPackage(
            string? sPDXID,
            string? name,
            string? versionInfo,
            string? downloadLocation,
            bool? filesAnalyzed,
            string? licenseConcluded,
            string? licenseDeclared,
            string? supplier,
            string? copyrightText,
            global::System.Collections.Generic.IList<global::G.DependencyGraphSpdxSbomSbomPackageExternalRef>? externalRefs)
        {
            this.SPDXID = sPDXID;
            this.Name = name;
            this.VersionInfo = versionInfo;
            this.DownloadLocation = downloadLocation;
            this.FilesAnalyzed = filesAnalyzed;
            this.LicenseConcluded = licenseConcluded;
            this.LicenseDeclared = licenseDeclared;
            this.Supplier = supplier;
            this.CopyrightText = copyrightText;
            this.ExternalRefs = externalRefs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DependencyGraphSpdxSbomSbomPackage" /> class.
        /// </summary>
        public DependencyGraphSpdxSbomSbomPackage()
        {
        }
    }
}
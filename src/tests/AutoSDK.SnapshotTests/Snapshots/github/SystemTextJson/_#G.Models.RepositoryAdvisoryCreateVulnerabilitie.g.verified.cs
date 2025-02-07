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
        [global::System.Text.Json.Serialization.JsonPropertyName("package")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RepositoryAdvisoryCreateVulnerabilitiePackage Package { get; set; }

        /// <summary>
        /// The range of the package versions affected by the vulnerability.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vulnerable_version_range")]
        public string? VulnerableVersionRange { get; set; }

        /// <summary>
        /// The package version(s) that resolve the vulnerability.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("patched_versions")]
        public string? PatchedVersions { get; set; }

        /// <summary>
        /// The functions in the package that are affected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vulnerable_functions")]
        public global::System.Collections.Generic.IList<string>? VulnerableFunctions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryAdvisoryCreateVulnerabilitie" /> class.
        /// </summary>
        /// <param name="package">
        /// The name of the package affected by the vulnerability.
        /// </param>
        /// <param name="vulnerableVersionRange">
        /// The range of the package versions affected by the vulnerability.
        /// </param>
        /// <param name="patchedVersions">
        /// The package version(s) that resolve the vulnerability.
        /// </param>
        /// <param name="vulnerableFunctions">
        /// The functions in the package that are affected.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RepositoryAdvisoryCreateVulnerabilitie(
            global::G.RepositoryAdvisoryCreateVulnerabilitiePackage package,
            string? vulnerableVersionRange,
            string? patchedVersions,
            global::System.Collections.Generic.IList<string>? vulnerableFunctions)
        {
            this.Package = package ?? throw new global::System.ArgumentNullException(nameof(package));
            this.VulnerableVersionRange = vulnerableVersionRange;
            this.PatchedVersions = patchedVersions;
            this.VulnerableFunctions = vulnerableFunctions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryAdvisoryCreateVulnerabilitie" /> class.
        /// </summary>
        public RepositoryAdvisoryCreateVulnerabilitie()
        {
        }
    }
}
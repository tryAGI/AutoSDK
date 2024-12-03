//HintName: G.Models.RepositoryAdvisoryUpdateVulnerabilitie.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RepositoryAdvisoryUpdateVulnerabilitie
    {
        /// <summary>
        /// The name of the package affected by the vulnerability.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("package", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RepositoryAdvisoryUpdateVulnerabilitiePackage Package { get; set; } = default!;

        /// <summary>
        /// The range of the package versions affected by the vulnerability.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vulnerable_version_range")]
        public string? VulnerableVersionRange { get; set; }

        /// <summary>
        /// The package version(s) that resolve the vulnerability.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("patched_versions")]
        public string? PatchedVersions { get; set; }

        /// <summary>
        /// The functions in the package that are affected.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vulnerable_functions")]
        public global::System.Collections.Generic.IList<string>? VulnerableFunctions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryAdvisoryUpdateVulnerabilitie" /> class.
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
        public RepositoryAdvisoryUpdateVulnerabilitie(
            global::G.RepositoryAdvisoryUpdateVulnerabilitiePackage package,
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
        /// Initializes a new instance of the <see cref="RepositoryAdvisoryUpdateVulnerabilitie" /> class.
        /// </summary>
        public RepositoryAdvisoryUpdateVulnerabilitie()
        {
        }
    }
}
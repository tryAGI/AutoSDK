//HintName: G.Models.RepositoryAdvisoryUpdateVulnerabilitiePackage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The name of the package affected by the vulnerability.
    /// </summary>
    public sealed partial class RepositoryAdvisoryUpdateVulnerabilitiePackage
    {
        /// <summary>
        /// The package's language or package management ecosystem.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ecosystem", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SecurityAdvisoryEcosystems Ecosystem { get; set; } = default!;

        /// <summary>
        /// The unique package name within its ecosystem.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryAdvisoryUpdateVulnerabilitiePackage" /> class.
        /// </summary>
        /// <param name="ecosystem">
        /// The package's language or package management ecosystem.
        /// </param>
        /// <param name="name">
        /// The unique package name within its ecosystem.
        /// </param>
        public RepositoryAdvisoryUpdateVulnerabilitiePackage(
            global::G.SecurityAdvisoryEcosystems ecosystem,
            string? name)
        {
            this.Ecosystem = ecosystem;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryAdvisoryUpdateVulnerabilitiePackage" /> class.
        /// </summary>
        public RepositoryAdvisoryUpdateVulnerabilitiePackage()
        {
        }
    }
}
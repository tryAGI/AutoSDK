//HintName: G.Models.DependabotAlertSecurityAdvisory.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Details for the GitHub Security Advisory.
    /// </summary>
    public sealed partial class DependabotAlertSecurityAdvisory
    {
        /// <summary>
        /// The unique GitHub Security Advisory ID assigned to the advisory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ghsa_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string GhsaId { get; set; } = default!;

        /// <summary>
        /// The unique CVE ID assigned to the advisory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cve_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string? CveId { get; set; } = default!;

        /// <summary>
        /// A short, plain text summary of the advisory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary", Required = global::Newtonsoft.Json.Required.Always)]
        public string Summary { get; set; } = default!;

        /// <summary>
        /// A long-form Markdown-supported description of the advisory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// Vulnerable version range information for the advisory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vulnerabilities", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<DependabotAlertSecurityVulnerability> Vulnerabilities { get; set; } = default!;

        /// <summary>
        /// The severity of the advisory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("severity", Required = global::Newtonsoft.Json.Required.Always)]
        public DependabotAlertSecurityAdvisorySeverity Severity { get; set; } = default!;

        /// <summary>
        /// Details for the advisory pertaining to the Common Vulnerability Scoring System.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cvss", Required = global::Newtonsoft.Json.Required.Always)]
        public DependabotAlertSecurityAdvisoryCvss Cvss { get; set; } = default!;

        /// <summary>
        /// Details for the advisory pertaining to Common Weakness Enumeration.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cwes", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<DependabotAlertSecurityAdvisoryCwes> Cwes { get; set; } = default!;

        /// <summary>
        /// Values that identify this advisory among security information sources.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("identifiers", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<DependabotAlertSecurityAdvisoryIdentifiers> Identifiers { get; set; } = default!;

        /// <summary>
        /// Links to additional advisory information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("references", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<DependabotAlertSecurityAdvisoryReferences> References { get; set; } = default!;

        /// <summary>
        /// The time that the advisory was published in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("published_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime PublishedAt { get; set; } = default!;

        /// <summary>
        /// The time that the advisory was last modified in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// The time that the advisory was withdrawn in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("withdrawn_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? WithdrawnAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
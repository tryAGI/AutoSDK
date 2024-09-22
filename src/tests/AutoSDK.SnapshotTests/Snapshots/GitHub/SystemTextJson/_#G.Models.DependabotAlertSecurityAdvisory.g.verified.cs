//HintName: G.Models.DependabotAlertSecurityAdvisory.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Details for the GitHub Security Advisory.<br/>
    /// Included only in responses
    /// </summary>
    public sealed partial class DependabotAlertSecurityAdvisory
    {
        /// <summary>
        /// The unique GitHub Security Advisory ID assigned to the advisory.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ghsa_id")]
        public string GhsaId { get; set; } = default!;

        /// <summary>
        /// The unique CVE ID assigned to the advisory.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cve_id")]
        public string? CveId { get; set; }

        /// <summary>
        /// A short, plain text summary of the advisory.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string Summary { get; set; } = default!;

        /// <summary>
        /// A long-form Markdown-supported description of the advisory.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string Description { get; set; } = default!;

        /// <summary>
        /// Vulnerable version range information for the advisory.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vulnerabilities")]
        public global::System.Collections.Generic.IList<global::G.DependabotAlertSecurityVulnerability> Vulnerabilities { get; set; } = default!;

        /// <summary>
        /// The severity of the advisory.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DependabotAlertSecurityAdvisorySeverityJsonConverter))]
        public global::G.DependabotAlertSecurityAdvisorySeverity Severity { get; set; } = default!;

        /// <summary>
        /// Details for the advisory pertaining to the Common Vulnerability Scoring System.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cvss")]
        public global::G.DependabotAlertSecurityAdvisoryCvss Cvss { get; set; } = default!;

        /// <summary>
        /// Details for the advisory pertaining to Common Weakness Enumeration.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cwes")]
        public global::System.Collections.Generic.IList<global::G.DependabotAlertSecurityAdvisoryCwe> Cwes { get; set; } = default!;

        /// <summary>
        /// Values that identify this advisory among security information sources.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifiers")]
        public global::System.Collections.Generic.IList<global::G.DependabotAlertSecurityAdvisoryIdentifier> Identifiers { get; set; } = default!;

        /// <summary>
        /// Links to additional advisory information.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("references")]
        public global::System.Collections.Generic.IList<global::G.DependabotAlertSecurityAdvisoryReference> References { get; set; } = default!;

        /// <summary>
        /// The time that the advisory was published in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("published_at")]
        public global::System.DateTime PublishedAt { get; set; } = default!;

        /// <summary>
        /// The time that the advisory was last modified in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// The time that the advisory was withdrawn in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("withdrawn_at")]
        public global::System.DateTime? WithdrawnAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
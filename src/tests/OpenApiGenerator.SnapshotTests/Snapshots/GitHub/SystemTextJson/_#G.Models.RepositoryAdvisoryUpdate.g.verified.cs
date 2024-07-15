//HintName: G.Models.RepositoryAdvisoryUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RepositoryAdvisoryUpdate
    {
        /// <summary>
        /// A short summary of the advisory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// A detailed description of what the advisory impacts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The Common Vulnerabilities and Exposures (CVE) ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cve_id")]
        public string? CveId { get; set; }

        /// <summary>
        /// A product affected by the vulnerability detailed in a repository security advisory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vulnerabilities")]
        public global::System.Collections.Generic.IList<global::G.RepositoryAdvisoryUpdateVulnerabilities?>? Vulnerabilities { get; set; }

        /// <summary>
        /// A list of Common Weakness Enumeration (CWE) IDs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cwe_ids")]
        public global::System.Collections.Generic.IList<string?>? CweIds { get; set; }

        /// <summary>
        /// A list of users receiving credit for their participation in the security advisory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits")]
        public global::System.Collections.Generic.IList<global::G.RepositoryAdvisoryUpdateCredits?>? Credits { get; set; }

        /// <summary>
        /// The severity of the advisory. You must choose between setting this field or `cvss_vector_string`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.RepositoryAdvisoryUpdateSeverityJsonConverter))]
        public global::G.RepositoryAdvisoryUpdateSeverity? Severity { get; set; }

        /// <summary>
        /// The CVSS vector that calculates the severity of the advisory. You must choose between setting this field or `severity`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cvss_vector_string")]
        public string? CvssVectorString { get; set; }

        /// <summary>
        /// The state of the advisory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.RepositoryAdvisoryUpdateStateJsonConverter))]
        public global::G.RepositoryAdvisoryUpdateState? State { get; set; }

        /// <summary>
        /// A list of usernames who have been granted write access to the advisory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collaborating_users")]
        public global::System.Collections.Generic.IList<string?>? CollaboratingUsers { get; set; }

        /// <summary>
        /// A list of team slugs which have been granted write access to the advisory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collaborating_teams")]
        public global::System.Collections.Generic.IList<string?>? CollaboratingTeams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
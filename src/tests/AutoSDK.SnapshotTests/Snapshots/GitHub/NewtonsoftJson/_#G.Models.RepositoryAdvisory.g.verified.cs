//HintName: G.Models.RepositoryAdvisory.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A repository security advisory.
    /// </summary>
    public sealed partial class RepositoryAdvisory
    {
        /// <summary>
        /// The GitHub Security Advisory ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ghsa_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string GhsaId { get; set; } = default!;

        /// <summary>
        /// The Common Vulnerabilities and Exposures (CVE) ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cve_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string? CveId { get; set; } = default!;

        /// <summary>
        /// The API URL for the advisory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// The URL for the advisory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// A short summary of the advisory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary", Required = global::Newtonsoft.Json.Required.Always)]
        public string Summary { get; set; } = default!;

        /// <summary>
        /// A detailed description of what the advisory entails.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Description { get; set; } = default!;

        /// <summary>
        /// The severity of the advisory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("severity", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RepositoryAdvisorySeverity? Severity { get; set; } = default!;

        /// <summary>
        /// A GitHub repository.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("private_fork", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SimpleRepository PrivateFork { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("publisher", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SimpleUser Publisher { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("identifiers", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.RepositoryAdvisoryIdentifier> Identifiers { get; set; } = default!;

        /// <summary>
        /// The state of the advisory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RepositoryAdvisoryState State { get; set; } = default!;

        /// <summary>
        /// The date and time of when the advisory was created, in ISO 8601 format.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? CreatedAt { get; set; } = default!;

        /// <summary>
        /// The date and time of when the advisory was last updated, in ISO 8601 format.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? UpdatedAt { get; set; } = default!;

        /// <summary>
        /// The date and time of when the advisory was published, in ISO 8601 format.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("published_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? PublishedAt { get; set; } = default!;

        /// <summary>
        /// The date and time of when the advisory was closed, in ISO 8601 format.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("closed_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? ClosedAt { get; set; } = default!;

        /// <summary>
        /// The date and time of when the advisory was withdrawn, in ISO 8601 format.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("withdrawn_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? WithdrawnAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("submission", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RepositoryAdvisorySubmission? Submission { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vulnerabilities", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.RepositoryAdvisoryVulnerability>? Vulnerabilities { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cvss", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RepositoryAdvisoryCvss? Cvss { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cwes", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.RepositoryAdvisoryCwe>? Cwes { get; set; } = default!;

        /// <summary>
        /// A list of only the CWE IDs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cwe_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string>? CweIds { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("credits", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.RepositoryAdvisoryCredit2>? Credits { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("credits_detailed", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.RepositoryAdvisoryCredit>? CreditsDetailed { get; set; } = default!;

        /// <summary>
        /// A list of users that collaborate on the advisory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("collaborating_users", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.SimpleUser>? CollaboratingUsers { get; set; } = default!;

        /// <summary>
        /// A list of teams that collaborate on the advisory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("collaborating_teams", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Team>? CollaboratingTeams { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SimpleUser Author { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
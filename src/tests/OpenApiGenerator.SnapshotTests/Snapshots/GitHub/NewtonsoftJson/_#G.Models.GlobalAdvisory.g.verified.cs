//HintName: G.Models.GlobalAdvisory.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A GitHub Security Advisory.
    /// </summary>
    public sealed partial class GlobalAdvisory
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
        /// The API URL for the repository advisory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository_advisory_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string? RepositoryAdvisoryUrl { get; set; } = default!;

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
        /// The type of advisory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GlobalAdvisoryType Type { get; set; } = default!;

        /// <summary>
        /// The severity of the advisory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("severity", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GlobalAdvisorySeverity Severity { get; set; } = default!;

        /// <summary>
        /// The URL of the advisory's source code.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_code_location", Required = global::Newtonsoft.Json.Required.Always)]
        public string? SourceCodeLocation { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("identifiers", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GlobalAdvisoryIdentifiers>? Identifiers { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("references", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string>? References { get; set; } = default!;

        /// <summary>
        /// The date and time of when the advisory was published, in ISO 8601 format.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("published_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime PublishedAt { get; set; } = default!;

        /// <summary>
        /// The date and time of when the advisory was last updated, in ISO 8601 format.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// The date and time of when the advisory was reviewed by GitHub, in ISO 8601 format.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("github_reviewed_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? GithubReviewedAt { get; set; } = default!;

        /// <summary>
        /// The date and time when the advisory was published in the National Vulnerability Database, in ISO 8601 format.<br/>
        /// This field is only populated when the advisory is imported from the National Vulnerability Database.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("nvd_published_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? NvdPublishedAt { get; set; } = default!;

        /// <summary>
        /// The date and time of when the advisory was withdrawn, in ISO 8601 format.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("withdrawn_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? WithdrawnAt { get; set; } = default!;

        /// <summary>
        /// The products and respective version ranges affected by the advisory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vulnerabilities", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Vulnerability>? Vulnerabilities { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cvss", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GlobalAdvisoryCvss? Cvss { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cwes", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GlobalAdvisoryCwes>? Cwes { get; set; } = default!;

        /// <summary>
        /// The users who contributed to the advisory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("credits", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GlobalAdvisoryCredits>? Credits { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
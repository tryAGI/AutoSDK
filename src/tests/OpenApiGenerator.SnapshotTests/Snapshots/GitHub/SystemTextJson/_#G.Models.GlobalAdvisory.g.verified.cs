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
        [global::System.Text.Json.Serialization.JsonPropertyName("ghsa_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GhsaId { get; set; }

        /// <summary>
        /// The Common Vulnerabilities and Exposures (CVE) ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cve_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? CveId { get; set; }

        /// <summary>
        /// The API URL for the advisory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// The URL for the advisory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// The API URL for the repository advisory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_advisory_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? RepositoryAdvisoryUrl { get; set; }

        /// <summary>
        /// A short summary of the advisory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Summary { get; set; }

        /// <summary>
        /// A detailed description of what the advisory entails.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Description { get; set; }

        /// <summary>
        /// The type of advisory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.GlobalAdvisoryTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GlobalAdvisoryType Type { get; set; }

        /// <summary>
        /// The severity of the advisory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.GlobalAdvisorySeverityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GlobalAdvisorySeverity Severity { get; set; }

        /// <summary>
        /// The URL of the advisory's source code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_code_location")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? SourceCodeLocation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifiers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GlobalAdvisoryIdentifier>? Identifiers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("references")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string>? References { get; set; }

        /// <summary>
        /// The date and time of when the advisory was published, in ISO 8601 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("published_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime PublishedAt { get; set; }

        /// <summary>
        /// The date and time of when the advisory was last updated, in ISO 8601 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// The date and time of when the advisory was reviewed by GitHub, in ISO 8601 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("github_reviewed_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? GithubReviewedAt { get; set; }

        /// <summary>
        /// The date and time when the advisory was published in the National Vulnerability Database, in ISO 8601 format.<br/>
        /// This field is only populated when the advisory is imported from the National Vulnerability Database.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nvd_published_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? NvdPublishedAt { get; set; }

        /// <summary>
        /// The date and time of when the advisory was withdrawn, in ISO 8601 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("withdrawn_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? WithdrawnAt { get; set; }

        /// <summary>
        /// The products and respective version ranges affected by the advisory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vulnerabilities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Vulnerability>? Vulnerabilities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cvss")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GlobalAdvisoryCvss? Cvss { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cwes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GlobalAdvisoryCwe>? Cwes { get; set; }

        /// <summary>
        /// The users who contributed to the advisory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GlobalAdvisoryCredit>? Credits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
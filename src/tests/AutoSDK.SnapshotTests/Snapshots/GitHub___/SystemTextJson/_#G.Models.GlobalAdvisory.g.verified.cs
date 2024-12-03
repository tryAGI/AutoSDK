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
        /// The GitHub Security Advisory ID.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("ghsa_id")]
        public string GhsaId { get; set; } = default!;

        /// <summary>
        /// The Common Vulnerabilities and Exposures (CVE) ID.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cve_id")]
        public string? CveId { get; set; }

        /// <summary>
        /// The API URL for the advisory.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string Url { get; set; } = default!;

        /// <summary>
        /// The URL for the advisory.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// The API URL for the repository advisory.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_advisory_url")]
        public string? RepositoryAdvisoryUrl { get; set; }

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
        /// The type of advisory.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GlobalAdvisoryTypeJsonConverter))]
        public global::G.GlobalAdvisoryType Type { get; set; } = default!;

        /// <summary>
        /// The severity of the advisory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GlobalAdvisorySeverityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GlobalAdvisorySeverity Severity { get; set; }

        /// <summary>
        /// The URL of the advisory's source code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_code_location")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? SourceCodeLocation { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifiers")]
        public global::System.Collections.Generic.IList<global::G.GlobalAdvisoryIdentifier>? Identifiers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("references")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string>? References { get; set; }

        /// <summary>
        /// The date and time of when the advisory was published, in ISO 8601 format.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("published_at")]
        public global::System.DateTime PublishedAt { get; set; } = default!;

        /// <summary>
        /// The date and time of when the advisory was last updated, in ISO 8601 format.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// The date and time of when the advisory was reviewed by GitHub, in ISO 8601 format.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("github_reviewed_at")]
        public global::System.DateTime? GithubReviewedAt { get; set; }

        /// <summary>
        /// The date and time when the advisory was published in the National Vulnerability Database, in ISO 8601 format.<br/>
        /// This field is only populated when the advisory is imported from the National Vulnerability Database.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nvd_published_at")]
        public global::System.DateTime? NvdPublishedAt { get; set; }

        /// <summary>
        /// The date and time of when the advisory was withdrawn, in ISO 8601 format.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("withdrawn_at")]
        public global::System.DateTime? WithdrawnAt { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("cvss_severities")]
        public global::G.CvssSeverities? CvssSeverities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cwes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GlobalAdvisoryCwe>? Cwes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("epss")]
        public global::G.GlobalAdvisoryEpss? Epss { get; set; }

        /// <summary>
        /// The users who contributed to the advisory.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits")]
        public global::System.Collections.Generic.IList<global::G.GlobalAdvisoryCredit>? Credits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalAdvisory" /> class.
        /// </summary>
        /// <param name="ghsaId">
        /// The GitHub Security Advisory ID.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="cveId">
        /// The Common Vulnerabilities and Exposures (CVE) ID.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="url">
        /// The API URL for the advisory.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="htmlUrl">
        /// The URL for the advisory.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="repositoryAdvisoryUrl">
        /// The API URL for the repository advisory.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="summary">
        /// A short summary of the advisory.
        /// </param>
        /// <param name="description">
        /// A detailed description of what the advisory entails.
        /// </param>
        /// <param name="type">
        /// The type of advisory.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="severity">
        /// The severity of the advisory.
        /// </param>
        /// <param name="sourceCodeLocation">
        /// The URL of the advisory's source code.
        /// </param>
        /// <param name="identifiers">
        /// Included only in responses
        /// </param>
        /// <param name="references"></param>
        /// <param name="publishedAt">
        /// The date and time of when the advisory was published, in ISO 8601 format.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updatedAt">
        /// The date and time of when the advisory was last updated, in ISO 8601 format.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="githubReviewedAt">
        /// The date and time of when the advisory was reviewed by GitHub, in ISO 8601 format.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="nvdPublishedAt">
        /// The date and time when the advisory was published in the National Vulnerability Database, in ISO 8601 format.<br/>
        /// This field is only populated when the advisory is imported from the National Vulnerability Database.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="withdrawnAt">
        /// The date and time of when the advisory was withdrawn, in ISO 8601 format.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="vulnerabilities">
        /// The products and respective version ranges affected by the advisory.
        /// </param>
        /// <param name="cvss"></param>
        /// <param name="cvssSeverities"></param>
        /// <param name="cwes"></param>
        /// <param name="epss"></param>
        /// <param name="credits">
        /// The users who contributed to the advisory.<br/>
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GlobalAdvisory(
            string summary,
            string? description,
            global::G.GlobalAdvisorySeverity severity,
            string? sourceCodeLocation,
            global::System.Collections.Generic.IList<string>? references,
            global::System.Collections.Generic.IList<global::G.Vulnerability>? vulnerabilities,
            global::G.GlobalAdvisoryCvss? cvss,
            global::System.Collections.Generic.IList<global::G.GlobalAdvisoryCwe>? cwes,
            string? cveId,
            string? repositoryAdvisoryUrl,
            global::System.Collections.Generic.IList<global::G.GlobalAdvisoryIdentifier>? identifiers,
            global::System.DateTime? githubReviewedAt,
            global::System.DateTime? nvdPublishedAt,
            global::System.DateTime? withdrawnAt,
            global::G.CvssSeverities? cvssSeverities,
            global::G.GlobalAdvisoryEpss? epss,
            global::System.Collections.Generic.IList<global::G.GlobalAdvisoryCredit>? credits,
            string ghsaId = default!,
            string url = default!,
            string htmlUrl = default!,
            global::G.GlobalAdvisoryType type = default!,
            global::System.DateTime publishedAt = default!,
            global::System.DateTime updatedAt = default!)
        {
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Severity = severity;
            this.SourceCodeLocation = sourceCodeLocation ?? throw new global::System.ArgumentNullException(nameof(sourceCodeLocation));
            this.References = references ?? throw new global::System.ArgumentNullException(nameof(references));
            this.Vulnerabilities = vulnerabilities ?? throw new global::System.ArgumentNullException(nameof(vulnerabilities));
            this.Cvss = cvss ?? throw new global::System.ArgumentNullException(nameof(cvss));
            this.Cwes = cwes ?? throw new global::System.ArgumentNullException(nameof(cwes));
            this.GhsaId = ghsaId;
            this.CveId = cveId;
            this.Url = url;
            this.HtmlUrl = htmlUrl;
            this.RepositoryAdvisoryUrl = repositoryAdvisoryUrl;
            this.Type = type;
            this.Identifiers = identifiers;
            this.PublishedAt = publishedAt;
            this.UpdatedAt = updatedAt;
            this.GithubReviewedAt = githubReviewedAt;
            this.NvdPublishedAt = nvdPublishedAt;
            this.WithdrawnAt = withdrawnAt;
            this.CvssSeverities = cvssSeverities;
            this.Epss = epss;
            this.Credits = credits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalAdvisory" /> class.
        /// </summary>
        public GlobalAdvisory()
        {
        }
    }
}
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
        /// The GitHub Security Advisory ID.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("ghsa_id")]
        public string GhsaId { get; set; } = default!;

        /// <summary>
        /// The Common Vulnerabilities and Exposures (CVE) ID.
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
        /// A short summary of the advisory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Summary { get; set; }

        /// <summary>
        /// A detailed description of what the advisory entails.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The severity of the advisory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RepositoryAdvisorySeverityJsonConverter))]
        public global::G.RepositoryAdvisorySeverity? Severity { get; set; }

        /// <summary>
        /// The author of the advisory.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        public global::G.SimpleUser? Author { get; set; }

        /// <summary>
        /// The publisher of the advisory.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publisher")]
        public global::G.SimpleUser? Publisher { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifiers")]
        public global::System.Collections.Generic.IList<global::G.RepositoryAdvisoryIdentifier> Identifiers { get; set; } = default!;

        /// <summary>
        /// The state of the advisory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RepositoryAdvisoryStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RepositoryAdvisoryState State { get; set; }

        /// <summary>
        /// The date and time of when the advisory was created, in ISO 8601 format.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The date and time of when the advisory was last updated, in ISO 8601 format.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The date and time of when the advisory was published, in ISO 8601 format.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("published_at")]
        public global::System.DateTime? PublishedAt { get; set; }

        /// <summary>
        /// The date and time of when the advisory was closed, in ISO 8601 format.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("closed_at")]
        public global::System.DateTime? ClosedAt { get; set; }

        /// <summary>
        /// The date and time of when the advisory was withdrawn, in ISO 8601 format.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("withdrawn_at")]
        public global::System.DateTime? WithdrawnAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("submission")]
        public global::G.RepositoryAdvisorySubmission? Submission { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vulnerabilities")]
        public global::System.Collections.Generic.IList<global::G.RepositoryAdvisoryVulnerability>? Vulnerabilities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cvss")]
        public global::G.RepositoryAdvisoryCvss? Cvss { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cvss_severities")]
        public global::G.CvssSeverities? CvssSeverities { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cwes")]
        public global::System.Collections.Generic.IList<global::G.RepositoryAdvisoryCwe>? Cwes { get; set; }

        /// <summary>
        /// A list of only the CWE IDs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cwe_ids")]
        public global::System.Collections.Generic.IList<string>? CweIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits")]
        public global::System.Collections.Generic.IList<global::G.RepositoryAdvisoryCredit2>? Credits { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits_detailed")]
        public global::System.Collections.Generic.IList<global::G.RepositoryAdvisoryCredit>? CreditsDetailed { get; set; }

        /// <summary>
        /// A list of users that collaborate on the advisory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collaborating_users")]
        public global::System.Collections.Generic.IList<global::G.SimpleUser>? CollaboratingUsers { get; set; }

        /// <summary>
        /// A list of teams that collaborate on the advisory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collaborating_teams")]
        public global::System.Collections.Generic.IList<global::G.Team>? CollaboratingTeams { get; set; }

        /// <summary>
        /// A temporary private fork of the advisory's repository for collaborating on a fix.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private_fork")]
        public global::G.SimpleRepository? PrivateFork { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryAdvisory" /> class.
        /// </summary>
        /// <param name="ghsaId">
        /// The GitHub Security Advisory ID.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="cveId">
        /// The Common Vulnerabilities and Exposures (CVE) ID.
        /// </param>
        /// <param name="url">
        /// The API URL for the advisory.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="htmlUrl">
        /// The URL for the advisory.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="summary">
        /// A short summary of the advisory.
        /// </param>
        /// <param name="description">
        /// A detailed description of what the advisory entails.
        /// </param>
        /// <param name="severity">
        /// The severity of the advisory.
        /// </param>
        /// <param name="author">
        /// The author of the advisory.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="publisher">
        /// The publisher of the advisory.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="identifiers">
        /// Included only in responses
        /// </param>
        /// <param name="state">
        /// The state of the advisory.
        /// </param>
        /// <param name="createdAt">
        /// The date and time of when the advisory was created, in ISO 8601 format.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updatedAt">
        /// The date and time of when the advisory was last updated, in ISO 8601 format.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="publishedAt">
        /// The date and time of when the advisory was published, in ISO 8601 format.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="closedAt">
        /// The date and time of when the advisory was closed, in ISO 8601 format.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="withdrawnAt">
        /// The date and time of when the advisory was withdrawn, in ISO 8601 format.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="submission">
        /// Included only in responses
        /// </param>
        /// <param name="vulnerabilities"></param>
        /// <param name="cvss"></param>
        /// <param name="cvssSeverities"></param>
        /// <param name="cwes">
        /// Included only in responses
        /// </param>
        /// <param name="cweIds">
        /// A list of only the CWE IDs.
        /// </param>
        /// <param name="credits"></param>
        /// <param name="creditsDetailed">
        /// Included only in responses
        /// </param>
        /// <param name="collaboratingUsers">
        /// A list of users that collaborate on the advisory.
        /// </param>
        /// <param name="collaboratingTeams">
        /// A list of teams that collaborate on the advisory.
        /// </param>
        /// <param name="privateFork">
        /// A temporary private fork of the advisory's repository for collaborating on a fix.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RepositoryAdvisory(
            string summary,
            global::G.RepositoryAdvisoryState state,
            string? cveId,
            string? description,
            global::G.RepositoryAdvisorySeverity? severity,
            global::G.SimpleUser? author,
            global::G.SimpleUser? publisher,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            global::System.DateTime? publishedAt,
            global::System.DateTime? closedAt,
            global::System.DateTime? withdrawnAt,
            global::G.RepositoryAdvisorySubmission? submission,
            global::System.Collections.Generic.IList<global::G.RepositoryAdvisoryVulnerability>? vulnerabilities,
            global::G.RepositoryAdvisoryCvss? cvss,
            global::G.CvssSeverities? cvssSeverities,
            global::System.Collections.Generic.IList<global::G.RepositoryAdvisoryCwe>? cwes,
            global::System.Collections.Generic.IList<string>? cweIds,
            global::System.Collections.Generic.IList<global::G.RepositoryAdvisoryCredit2>? credits,
            global::System.Collections.Generic.IList<global::G.RepositoryAdvisoryCredit>? creditsDetailed,
            global::System.Collections.Generic.IList<global::G.SimpleUser>? collaboratingUsers,
            global::System.Collections.Generic.IList<global::G.Team>? collaboratingTeams,
            global::G.SimpleRepository? privateFork,
            string ghsaId = default!,
            string url = default!,
            string htmlUrl = default!,
            global::System.Collections.Generic.IList<global::G.RepositoryAdvisoryIdentifier> identifiers = default!)
        {
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
            this.State = state;
            this.GhsaId = ghsaId;
            this.CveId = cveId;
            this.Url = url;
            this.HtmlUrl = htmlUrl;
            this.Description = description;
            this.Severity = severity;
            this.Author = author;
            this.Publisher = publisher;
            this.Identifiers = identifiers;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.PublishedAt = publishedAt;
            this.ClosedAt = closedAt;
            this.WithdrawnAt = withdrawnAt;
            this.Submission = submission;
            this.Vulnerabilities = vulnerabilities;
            this.Cvss = cvss;
            this.CvssSeverities = cvssSeverities;
            this.Cwes = cwes;
            this.CweIds = cweIds;
            this.Credits = credits;
            this.CreditsDetailed = creditsDetailed;
            this.CollaboratingUsers = collaboratingUsers;
            this.CollaboratingTeams = collaboratingTeams;
            this.PrivateFork = privateFork;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryAdvisory" /> class.
        /// </summary>
        public RepositoryAdvisory()
        {
        }
    }
}
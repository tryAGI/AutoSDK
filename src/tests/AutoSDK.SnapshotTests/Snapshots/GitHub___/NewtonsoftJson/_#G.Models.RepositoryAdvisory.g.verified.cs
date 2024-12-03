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
        [global::Newtonsoft.Json.JsonProperty("ghsa_id")]
        public string GhsaId { get; set; } = default!;

        /// <summary>
        /// The Common Vulnerabilities and Exposures (CVE) ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cve_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string? CveId { get; set; } = default!;

        /// <summary>
        /// The API URL for the advisory.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string Url { get; set; } = default!;

        /// <summary>
        /// The URL for the advisory.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("html_url")]
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
        /// The author of the advisory.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author")]
        public global::G.SimpleUser? Author { get; set; }

        /// <summary>
        /// The publisher of the advisory.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("publisher")]
        public global::G.SimpleUser? Publisher { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("identifiers")]
        public global::System.Collections.Generic.IList<global::G.RepositoryAdvisoryIdentifier> Identifiers { get; set; } = default!;

        /// <summary>
        /// The state of the advisory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RepositoryAdvisoryState State { get; set; } = default!;

        /// <summary>
        /// The date and time of when the advisory was created, in ISO 8601 format.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The date and time of when the advisory was last updated, in ISO 8601 format.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The date and time of when the advisory was published, in ISO 8601 format.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("published_at")]
        public global::System.DateTime? PublishedAt { get; set; }

        /// <summary>
        /// The date and time of when the advisory was closed, in ISO 8601 format.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("closed_at")]
        public global::System.DateTime? ClosedAt { get; set; }

        /// <summary>
        /// The date and time of when the advisory was withdrawn, in ISO 8601 format.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("withdrawn_at")]
        public global::System.DateTime? WithdrawnAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("submission")]
        public global::G.RepositoryAdvisorySubmission? Submission { get; set; }

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
        [global::Newtonsoft.Json.JsonProperty("cvss_severities")]
        public global::G.CvssSeverities? CvssSeverities { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cwes")]
        public global::System.Collections.Generic.IList<global::G.RepositoryAdvisoryCwe>? Cwes { get; set; }

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
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("credits_detailed")]
        public global::System.Collections.Generic.IList<global::G.RepositoryAdvisoryCredit>? CreditsDetailed { get; set; }

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
        /// A temporary private fork of the advisory's repository for collaborating on a fix.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("private_fork")]
        public global::G.SimpleRepository? PrivateFork { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
        public RepositoryAdvisory(
            string? cveId,
            string summary,
            string? description,
            global::G.RepositoryAdvisorySeverity? severity,
            global::G.RepositoryAdvisoryState state,
            global::System.Collections.Generic.IList<global::G.RepositoryAdvisoryVulnerability>? vulnerabilities,
            global::G.RepositoryAdvisoryCvss? cvss,
            global::System.Collections.Generic.IList<string>? cweIds,
            global::System.Collections.Generic.IList<global::G.RepositoryAdvisoryCredit2>? credits,
            global::System.Collections.Generic.IList<global::G.SimpleUser>? collaboratingUsers,
            global::System.Collections.Generic.IList<global::G.Team>? collaboratingTeams,
            global::G.SimpleUser? author,
            global::G.SimpleUser? publisher,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            global::System.DateTime? publishedAt,
            global::System.DateTime? closedAt,
            global::System.DateTime? withdrawnAt,
            global::G.RepositoryAdvisorySubmission? submission,
            global::G.CvssSeverities? cvssSeverities,
            global::System.Collections.Generic.IList<global::G.RepositoryAdvisoryCwe>? cwes,
            global::System.Collections.Generic.IList<global::G.RepositoryAdvisoryCredit>? creditsDetailed,
            global::G.SimpleRepository? privateFork,
            string ghsaId = default!,
            string url = default!,
            string htmlUrl = default!,
            global::System.Collections.Generic.IList<global::G.RepositoryAdvisoryIdentifier> identifiers = default!)
        {
            this.CveId = cveId ?? throw new global::System.ArgumentNullException(nameof(cveId));
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Severity = severity;
            this.State = state;
            this.Vulnerabilities = vulnerabilities ?? throw new global::System.ArgumentNullException(nameof(vulnerabilities));
            this.Cvss = cvss ?? throw new global::System.ArgumentNullException(nameof(cvss));
            this.CweIds = cweIds ?? throw new global::System.ArgumentNullException(nameof(cweIds));
            this.Credits = credits ?? throw new global::System.ArgumentNullException(nameof(credits));
            this.CollaboratingUsers = collaboratingUsers ?? throw new global::System.ArgumentNullException(nameof(collaboratingUsers));
            this.CollaboratingTeams = collaboratingTeams ?? throw new global::System.ArgumentNullException(nameof(collaboratingTeams));
            this.GhsaId = ghsaId;
            this.Url = url;
            this.HtmlUrl = htmlUrl;
            this.Author = author;
            this.Publisher = publisher;
            this.Identifiers = identifiers;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.PublishedAt = publishedAt;
            this.ClosedAt = closedAt;
            this.WithdrawnAt = withdrawnAt;
            this.Submission = submission;
            this.CvssSeverities = cvssSeverities;
            this.Cwes = cwes;
            this.CreditsDetailed = creditsDetailed;
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
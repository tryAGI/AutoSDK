﻿//HintName: G.Models.RepositoryAdvisory.g.cs

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
        /// The severity of the advisory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Severity { get; set; }

        /// <summary>
        /// The author of the advisory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object? Author { get; set; }

        /// <summary>
        /// The publisher of the advisory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publisher")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object? Publisher { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifiers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<RepositoryAdvisoryIdentifiers> Identifiers { get; set; }

        /// <summary>
        /// The state of the advisory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string State { get; set; }

        /// <summary>
        /// The date and time of when the advisory was created, in ISO 8601 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The date and time of when the advisory was last updated, in ISO 8601 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The date and time of when the advisory was published, in ISO 8601 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("published_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? PublishedAt { get; set; }

        /// <summary>
        /// The date and time of when the advisory was closed, in ISO 8601 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("closed_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? ClosedAt { get; set; }

        /// <summary>
        /// The date and time of when the advisory was withdrawn, in ISO 8601 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("withdrawn_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? WithdrawnAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("submission")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required RepositoryAdvisorySubmission? Submission { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vulnerabilities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<RepositoryAdvisoryVulnerability>? Vulnerabilities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cvss")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required RepositoryAdvisoryCvss? Cvss { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cwes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<RepositoryAdvisoryCwes>? Cwes { get; set; }

        /// <summary>
        /// A list of only the CWE IDs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cwe_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string>? CweIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<RepositoryAdvisoryCredits>? Credits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits_detailed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<RepositoryAdvisoryCredit>? CreditsDetailed { get; set; }

        /// <summary>
        /// A list of users that collaborate on the advisory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collaborating_users")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<SimpleUser>? CollaboratingUsers { get; set; }

        /// <summary>
        /// A list of teams that collaborate on the advisory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collaborating_teams")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<Team>? CollaboratingTeams { get; set; }

        /// <summary>
        /// A temporary private fork of the advisory's repository for collaborating on a fix.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private_fork")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object? PrivateFork { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
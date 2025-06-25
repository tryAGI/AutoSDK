//HintName: G.Models.WebhooksSecurityAdvisory.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The details of the security advisory, including summary, description, and severity.
    /// </summary>
    public sealed partial class WebhooksSecurityAdvisory
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cvss")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhooksSecurityAdvisoryCvss Cvss { get; set; }

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
        public required global::System.Collections.Generic.IList<global::G.WebhooksSecurityAdvisoryCwe> Cwes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ghsa_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GhsaId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifiers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.WebhooksSecurityAdvisoryIdentifier> Identifiers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("published_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PublishedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("references")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.WebhooksSecurityAdvisoryReference> References { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Severity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Summary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vulnerabilities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.WebhooksSecurityAdvisoryVulnerabilitie> Vulnerabilities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("withdrawn_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? WithdrawnAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksSecurityAdvisory" /> class.
        /// </summary>
        /// <param name="cvss"></param>
        /// <param name="cvssSeverities"></param>
        /// <param name="cwes"></param>
        /// <param name="description"></param>
        /// <param name="ghsaId"></param>
        /// <param name="identifiers"></param>
        /// <param name="publishedAt"></param>
        /// <param name="references"></param>
        /// <param name="severity"></param>
        /// <param name="summary"></param>
        /// <param name="updatedAt"></param>
        /// <param name="vulnerabilities"></param>
        /// <param name="withdrawnAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhooksSecurityAdvisory(
            global::G.WebhooksSecurityAdvisoryCvss cvss,
            global::System.Collections.Generic.IList<global::G.WebhooksSecurityAdvisoryCwe> cwes,
            string description,
            string ghsaId,
            global::System.Collections.Generic.IList<global::G.WebhooksSecurityAdvisoryIdentifier> identifiers,
            string publishedAt,
            global::System.Collections.Generic.IList<global::G.WebhooksSecurityAdvisoryReference> references,
            string severity,
            string summary,
            string updatedAt,
            global::System.Collections.Generic.IList<global::G.WebhooksSecurityAdvisoryVulnerabilitie> vulnerabilities,
            string? withdrawnAt,
            global::G.CvssSeverities? cvssSeverities)
        {
            this.Cvss = cvss ?? throw new global::System.ArgumentNullException(nameof(cvss));
            this.Cwes = cwes ?? throw new global::System.ArgumentNullException(nameof(cwes));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.GhsaId = ghsaId ?? throw new global::System.ArgumentNullException(nameof(ghsaId));
            this.Identifiers = identifiers ?? throw new global::System.ArgumentNullException(nameof(identifiers));
            this.PublishedAt = publishedAt ?? throw new global::System.ArgumentNullException(nameof(publishedAt));
            this.References = references ?? throw new global::System.ArgumentNullException(nameof(references));
            this.Severity = severity ?? throw new global::System.ArgumentNullException(nameof(severity));
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.Vulnerabilities = vulnerabilities ?? throw new global::System.ArgumentNullException(nameof(vulnerabilities));
            this.WithdrawnAt = withdrawnAt ?? throw new global::System.ArgumentNullException(nameof(withdrawnAt));
            this.CvssSeverities = cvssSeverities;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksSecurityAdvisory" /> class.
        /// </summary>
        public WebhooksSecurityAdvisory()
        {
        }
    }
}
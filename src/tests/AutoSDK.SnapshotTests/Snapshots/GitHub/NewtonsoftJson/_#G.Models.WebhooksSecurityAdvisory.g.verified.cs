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
        [global::Newtonsoft.Json.JsonProperty("cvss", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhooksSecurityAdvisoryCvss Cvss { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cvss_severities")]
        public global::G.CvssSeverities? CvssSeverities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cwes", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.WebhooksSecurityAdvisoryCwe> Cwes { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ghsa_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string GhsaId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("identifiers", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.WebhooksSecurityAdvisoryIdentifier> Identifiers { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("published_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string PublishedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("references", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.WebhooksSecurityAdvisoryReference> References { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("severity", Required = global::Newtonsoft.Json.Required.Always)]
        public string Severity { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary", Required = global::Newtonsoft.Json.Required.Always)]
        public string Summary { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vulnerabilities", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.WebhooksSecurityAdvisoryVulnerabilitie> Vulnerabilities { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("withdrawn_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string? WithdrawnAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
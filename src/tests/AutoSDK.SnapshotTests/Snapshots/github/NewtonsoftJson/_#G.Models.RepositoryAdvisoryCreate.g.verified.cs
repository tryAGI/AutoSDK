﻿//HintName: G.Models.RepositoryAdvisoryCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RepositoryAdvisoryCreate
    {
        /// <summary>
        /// A short summary of the advisory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary", Required = global::Newtonsoft.Json.Required.Always)]
        public string Summary { get; set; } = default!;

        /// <summary>
        /// A detailed description of what the advisory impacts.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// The Common Vulnerabilities and Exposures (CVE) ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cve_id")]
        public string? CveId { get; set; }

        /// <summary>
        /// A product affected by the vulnerability detailed in a repository security advisory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vulnerabilities", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.RepositoryAdvisoryCreateVulnerabilitie> Vulnerabilities { get; set; } = default!;

        /// <summary>
        /// A list of Common Weakness Enumeration (CWE) IDs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cwe_ids")]
        public global::System.Collections.Generic.IList<string>? CweIds { get; set; }

        /// <summary>
        /// A list of users receiving credit for their participation in the security advisory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("credits")]
        public global::System.Collections.Generic.IList<global::G.RepositoryAdvisoryCreateCredit>? Credits { get; set; }

        /// <summary>
        /// The severity of the advisory. You must choose between setting this field or `cvss_vector_string`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("severity")]
        public global::G.RepositoryAdvisoryCreateSeverity? Severity { get; set; }

        /// <summary>
        /// The CVSS vector that calculates the severity of the advisory. You must choose between setting this field or `severity`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cvss_vector_string")]
        public string? CvssVectorString { get; set; }

        /// <summary>
        /// Whether to create a temporary private fork of the repository to collaborate on a fix.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_private_fork")]
        public bool? StartPrivateFork { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryAdvisoryCreate" /> class.
        /// </summary>
        /// <param name="summary">
        /// A short summary of the advisory.
        /// </param>
        /// <param name="description">
        /// A detailed description of what the advisory impacts.
        /// </param>
        /// <param name="cveId">
        /// The Common Vulnerabilities and Exposures (CVE) ID.
        /// </param>
        /// <param name="vulnerabilities">
        /// A product affected by the vulnerability detailed in a repository security advisory.
        /// </param>
        /// <param name="cweIds">
        /// A list of Common Weakness Enumeration (CWE) IDs.
        /// </param>
        /// <param name="credits">
        /// A list of users receiving credit for their participation in the security advisory.
        /// </param>
        /// <param name="severity">
        /// The severity of the advisory. You must choose between setting this field or `cvss_vector_string`.
        /// </param>
        /// <param name="cvssVectorString">
        /// The CVSS vector that calculates the severity of the advisory. You must choose between setting this field or `severity`.
        /// </param>
        /// <param name="startPrivateFork">
        /// Whether to create a temporary private fork of the repository to collaborate on a fix.<br/>
        /// Default Value: false
        /// </param>
        public RepositoryAdvisoryCreate(
            string summary,
            string description,
            global::System.Collections.Generic.IList<global::G.RepositoryAdvisoryCreateVulnerabilitie> vulnerabilities,
            string? cveId,
            global::System.Collections.Generic.IList<string>? cweIds,
            global::System.Collections.Generic.IList<global::G.RepositoryAdvisoryCreateCredit>? credits,
            global::G.RepositoryAdvisoryCreateSeverity? severity,
            string? cvssVectorString,
            bool? startPrivateFork)
        {
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Vulnerabilities = vulnerabilities ?? throw new global::System.ArgumentNullException(nameof(vulnerabilities));
            this.CveId = cveId;
            this.CweIds = cweIds;
            this.Credits = credits;
            this.Severity = severity;
            this.CvssVectorString = cvssVectorString;
            this.StartPrivateFork = startPrivateFork;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryAdvisoryCreate" /> class.
        /// </summary>
        public RepositoryAdvisoryCreate()
        {
        }
    }
}
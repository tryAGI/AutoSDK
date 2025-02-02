﻿//HintName: G.Models.WebhookSecurityAdvisoryWithdrawnSecurityAdvisoryVulnerabilitie.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookSecurityAdvisoryWithdrawnSecurityAdvisoryVulnerabilitie
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("first_patched_version", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookSecurityAdvisoryWithdrawnSecurityAdvisoryVulnerabilitieFirstPatchedVersion? FirstPatchedVersion { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("package", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookSecurityAdvisoryWithdrawnSecurityAdvisoryVulnerabilitiePackage Package { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("severity", Required = global::Newtonsoft.Json.Required.Always)]
        public string Severity { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vulnerable_version_range", Required = global::Newtonsoft.Json.Required.Always)]
        public string VulnerableVersionRange { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSecurityAdvisoryWithdrawnSecurityAdvisoryVulnerabilitie" /> class.
        /// </summary>
        /// <param name="firstPatchedVersion"></param>
        /// <param name="package"></param>
        /// <param name="severity"></param>
        /// <param name="vulnerableVersionRange"></param>
        public WebhookSecurityAdvisoryWithdrawnSecurityAdvisoryVulnerabilitie(
            global::G.WebhookSecurityAdvisoryWithdrawnSecurityAdvisoryVulnerabilitieFirstPatchedVersion? firstPatchedVersion,
            global::G.WebhookSecurityAdvisoryWithdrawnSecurityAdvisoryVulnerabilitiePackage package,
            string severity,
            string vulnerableVersionRange)
        {
            this.FirstPatchedVersion = firstPatchedVersion ?? throw new global::System.ArgumentNullException(nameof(firstPatchedVersion));
            this.Package = package ?? throw new global::System.ArgumentNullException(nameof(package));
            this.Severity = severity ?? throw new global::System.ArgumentNullException(nameof(severity));
            this.VulnerableVersionRange = vulnerableVersionRange ?? throw new global::System.ArgumentNullException(nameof(vulnerableVersionRange));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSecurityAdvisoryWithdrawnSecurityAdvisoryVulnerabilitie" /> class.
        /// </summary>
        public WebhookSecurityAdvisoryWithdrawnSecurityAdvisoryVulnerabilitie()
        {
        }
    }
}
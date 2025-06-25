//HintName: G.Models.WebhookSecurityAdvisoryWithdrawnSecurityAdvisoryVulnerabilitie.g.cs

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
        [global::System.Text.Json.Serialization.JsonPropertyName("first_patched_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookSecurityAdvisoryWithdrawnSecurityAdvisoryVulnerabilitieFirstPatchedVersion? FirstPatchedVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("package")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookSecurityAdvisoryWithdrawnSecurityAdvisoryVulnerabilitiePackage Package { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Severity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vulnerable_version_range")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VulnerableVersionRange { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSecurityAdvisoryWithdrawnSecurityAdvisoryVulnerabilitie" /> class.
        /// </summary>
        /// <param name="firstPatchedVersion"></param>
        /// <param name="package"></param>
        /// <param name="severity"></param>
        /// <param name="vulnerableVersionRange"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
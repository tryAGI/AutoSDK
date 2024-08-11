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
    }
}
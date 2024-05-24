//HintName: G.Models.WebhooksSecurityAdvisoryVulnerabilities.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhooksSecurityAdvisoryVulnerabilities
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_patched_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required WebhooksSecurityAdvisoryVulnerabilitiesFirstPatchedVersion? FirstPatchedVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("package")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required WebhooksSecurityAdvisoryVulnerabilitiesPackage Package { get; set; }

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
    }
}
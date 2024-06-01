//HintName: G.Models.ReposUpdateRequestSecurityAndAnalysis.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specify which security and analysis features to enable or disable for the repository.
    /// To use this parameter, you must have admin permissions for the repository or be an owner or security manager for the organization that owns the repository. For more information, see "[Managing security managers in your organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization)."
    /// For example, to enable GitHub Advanced Security, use this data in the body of the `PATCH` request:
    /// `{ "security_and_analysis": {"advanced_security": { "status": "enabled" } } }`.
    /// You can check which security and analysis features are currently enabled by using a `GET /repos/{owner}/{repo}` request.
    /// </summary>
    public sealed partial class ReposUpdateRequestSecurityAndAnalysis
    {
        /// <summary>
        /// Use the `status` property to enable or disable GitHub Advanced Security for this repository. For more information, see "[About GitHub Advanced Security](/github/getting-started-with-github/learning-about-github/about-github-advanced-security)."
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("advanced_security")]
        public ReposUpdateRequestSecurityAndAnalysisAdvancedSecurity? AdvancedSecurity { get; set; }

        /// <summary>
        /// Use the `status` property to enable or disable secret scanning for this repository. For more information, see "[About secret scanning](/code-security/secret-security/about-secret-scanning)."
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning")]
        public ReposUpdateRequestSecurityAndAnalysisSecretScanning? SecretScanning { get; set; }

        /// <summary>
        /// Use the `status` property to enable or disable secret scanning push protection for this repository. For more information, see "[Protecting pushes with secret scanning](/code-security/secret-scanning/protecting-pushes-with-secret-scanning)."
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_push_protection")]
        public ReposUpdateRequestSecurityAndAnalysisSecretScanningPushProtection? SecretScanningPushProtection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
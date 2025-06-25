//HintName: G.Models.SecurityAndAnalysis.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SecurityAndAnalysis
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("advanced_security")]
        public global::G.SecurityAndAnalysisAdvancedSecurity? AdvancedSecurity { get; set; }

        /// <summary>
        /// Enable or disable Dependabot security updates for the repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependabot_security_updates")]
        public global::G.SecurityAndAnalysisDependabotSecurityUpdates? DependabotSecurityUpdates { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning")]
        public global::G.SecurityAndAnalysisSecretScanning? SecretScanning { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_push_protection")]
        public global::G.SecurityAndAnalysisSecretScanningPushProtection? SecretScanningPushProtection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_non_provider_patterns")]
        public global::G.SecurityAndAnalysisSecretScanningNonProviderPatterns? SecretScanningNonProviderPatterns { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_ai_detection")]
        public global::G.SecurityAndAnalysisSecretScanningAiDetection? SecretScanningAiDetection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityAndAnalysis" /> class.
        /// </summary>
        /// <param name="advancedSecurity"></param>
        /// <param name="dependabotSecurityUpdates">
        /// Enable or disable Dependabot security updates for the repository.
        /// </param>
        /// <param name="secretScanning"></param>
        /// <param name="secretScanningPushProtection"></param>
        /// <param name="secretScanningNonProviderPatterns"></param>
        /// <param name="secretScanningAiDetection"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SecurityAndAnalysis(
            global::G.SecurityAndAnalysisAdvancedSecurity? advancedSecurity,
            global::G.SecurityAndAnalysisDependabotSecurityUpdates? dependabotSecurityUpdates,
            global::G.SecurityAndAnalysisSecretScanning? secretScanning,
            global::G.SecurityAndAnalysisSecretScanningPushProtection? secretScanningPushProtection,
            global::G.SecurityAndAnalysisSecretScanningNonProviderPatterns? secretScanningNonProviderPatterns,
            global::G.SecurityAndAnalysisSecretScanningAiDetection? secretScanningAiDetection)
        {
            this.AdvancedSecurity = advancedSecurity;
            this.DependabotSecurityUpdates = dependabotSecurityUpdates;
            this.SecretScanning = secretScanning;
            this.SecretScanningPushProtection = secretScanningPushProtection;
            this.SecretScanningNonProviderPatterns = secretScanningNonProviderPatterns;
            this.SecretScanningAiDetection = secretScanningAiDetection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityAndAnalysis" /> class.
        /// </summary>
        public SecurityAndAnalysis()
        {
        }
    }
}
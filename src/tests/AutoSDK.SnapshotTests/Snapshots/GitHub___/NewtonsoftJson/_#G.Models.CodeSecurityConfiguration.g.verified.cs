//HintName: G.Models.CodeSecurityConfiguration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A code security configuration
    /// </summary>
    public sealed partial class CodeSecurityConfiguration
    {
        /// <summary>
        /// The ID of the code security configuration
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// The name of the code security configuration. Must be unique within the organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The type of the code security configuration.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target_type")]
        public global::G.CodeSecurityConfigurationTargetType? TargetType { get; set; }

        /// <summary>
        /// A description of the code security configuration
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The enablement status of GitHub Advanced Security
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("advanced_security")]
        public global::G.CodeSecurityConfigurationAdvancedSecurity? AdvancedSecurity { get; set; }

        /// <summary>
        /// The enablement status of Dependency Graph
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dependency_graph")]
        public global::G.CodeSecurityConfigurationDependencyGraph? DependencyGraph { get; set; }

        /// <summary>
        /// The enablement status of Automatic dependency submission
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dependency_graph_autosubmit_action")]
        public global::G.CodeSecurityConfigurationDependencyGraphAutosubmitAction? DependencyGraphAutosubmitAction { get; set; }

        /// <summary>
        /// Feature options for Automatic dependency submission
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dependency_graph_autosubmit_action_options")]
        public global::G.CodeSecurityConfigurationDependencyGraphAutosubmitActionOptions? DependencyGraphAutosubmitActionOptions { get; set; }

        /// <summary>
        /// The enablement status of Dependabot alerts
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dependabot_alerts")]
        public global::G.CodeSecurityConfigurationDependabotAlerts? DependabotAlerts { get; set; }

        /// <summary>
        /// The enablement status of Dependabot security updates
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dependabot_security_updates")]
        public global::G.CodeSecurityConfigurationDependabotSecurityUpdates? DependabotSecurityUpdates { get; set; }

        /// <summary>
        /// The enablement status of code scanning default setup
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code_scanning_default_setup")]
        public global::G.CodeSecurityConfigurationCodeScanningDefaultSetup? CodeScanningDefaultSetup { get; set; }

        /// <summary>
        /// The enablement status of secret scanning
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secret_scanning")]
        public global::G.CodeSecurityConfigurationSecretScanning? SecretScanning { get; set; }

        /// <summary>
        /// The enablement status of secret scanning push protection
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secret_scanning_push_protection")]
        public global::G.CodeSecurityConfigurationSecretScanningPushProtection? SecretScanningPushProtection { get; set; }

        /// <summary>
        /// The enablement status of secret scanning validity checks
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secret_scanning_validity_checks")]
        public global::G.CodeSecurityConfigurationSecretScanningValidityChecks? SecretScanningValidityChecks { get; set; }

        /// <summary>
        /// The enablement status of secret scanning non-provider patterns
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secret_scanning_non_provider_patterns")]
        public global::G.CodeSecurityConfigurationSecretScanningNonProviderPatterns? SecretScanningNonProviderPatterns { get; set; }

        /// <summary>
        /// The enablement status of private vulnerability reporting
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("private_vulnerability_reporting")]
        public global::G.CodeSecurityConfigurationPrivateVulnerabilityReporting? PrivateVulnerabilityReporting { get; set; }

        /// <summary>
        /// The enforcement status for a security configuration
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enforcement")]
        public global::G.CodeSecurityConfigurationEnforcement? Enforcement { get; set; }

        /// <summary>
        /// The URL of the configuration
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The URL of the configuration
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeSecurityConfiguration" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the code security configuration
        /// </param>
        /// <param name="name">
        /// The name of the code security configuration. Must be unique within the organization.
        /// </param>
        /// <param name="targetType">
        /// The type of the code security configuration.
        /// </param>
        /// <param name="description">
        /// A description of the code security configuration
        /// </param>
        /// <param name="advancedSecurity">
        /// The enablement status of GitHub Advanced Security
        /// </param>
        /// <param name="dependencyGraph">
        /// The enablement status of Dependency Graph
        /// </param>
        /// <param name="dependencyGraphAutosubmitAction">
        /// The enablement status of Automatic dependency submission
        /// </param>
        /// <param name="dependencyGraphAutosubmitActionOptions">
        /// Feature options for Automatic dependency submission
        /// </param>
        /// <param name="dependabotAlerts">
        /// The enablement status of Dependabot alerts
        /// </param>
        /// <param name="dependabotSecurityUpdates">
        /// The enablement status of Dependabot security updates
        /// </param>
        /// <param name="codeScanningDefaultSetup">
        /// The enablement status of code scanning default setup
        /// </param>
        /// <param name="secretScanning">
        /// The enablement status of secret scanning
        /// </param>
        /// <param name="secretScanningPushProtection">
        /// The enablement status of secret scanning push protection
        /// </param>
        /// <param name="secretScanningValidityChecks">
        /// The enablement status of secret scanning validity checks
        /// </param>
        /// <param name="secretScanningNonProviderPatterns">
        /// The enablement status of secret scanning non-provider patterns
        /// </param>
        /// <param name="privateVulnerabilityReporting">
        /// The enablement status of private vulnerability reporting
        /// </param>
        /// <param name="enforcement">
        /// The enforcement status for a security configuration
        /// </param>
        /// <param name="url">
        /// The URL of the configuration
        /// </param>
        /// <param name="htmlUrl">
        /// The URL of the configuration
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        public CodeSecurityConfiguration(
            int? id,
            string? name,
            global::G.CodeSecurityConfigurationTargetType? targetType,
            string? description,
            global::G.CodeSecurityConfigurationAdvancedSecurity? advancedSecurity,
            global::G.CodeSecurityConfigurationDependencyGraph? dependencyGraph,
            global::G.CodeSecurityConfigurationDependencyGraphAutosubmitAction? dependencyGraphAutosubmitAction,
            global::G.CodeSecurityConfigurationDependencyGraphAutosubmitActionOptions? dependencyGraphAutosubmitActionOptions,
            global::G.CodeSecurityConfigurationDependabotAlerts? dependabotAlerts,
            global::G.CodeSecurityConfigurationDependabotSecurityUpdates? dependabotSecurityUpdates,
            global::G.CodeSecurityConfigurationCodeScanningDefaultSetup? codeScanningDefaultSetup,
            global::G.CodeSecurityConfigurationSecretScanning? secretScanning,
            global::G.CodeSecurityConfigurationSecretScanningPushProtection? secretScanningPushProtection,
            global::G.CodeSecurityConfigurationSecretScanningValidityChecks? secretScanningValidityChecks,
            global::G.CodeSecurityConfigurationSecretScanningNonProviderPatterns? secretScanningNonProviderPatterns,
            global::G.CodeSecurityConfigurationPrivateVulnerabilityReporting? privateVulnerabilityReporting,
            global::G.CodeSecurityConfigurationEnforcement? enforcement,
            string? url,
            string? htmlUrl,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Id = id;
            this.Name = name;
            this.TargetType = targetType;
            this.Description = description;
            this.AdvancedSecurity = advancedSecurity;
            this.DependencyGraph = dependencyGraph;
            this.DependencyGraphAutosubmitAction = dependencyGraphAutosubmitAction;
            this.DependencyGraphAutosubmitActionOptions = dependencyGraphAutosubmitActionOptions;
            this.DependabotAlerts = dependabotAlerts;
            this.DependabotSecurityUpdates = dependabotSecurityUpdates;
            this.CodeScanningDefaultSetup = codeScanningDefaultSetup;
            this.SecretScanning = secretScanning;
            this.SecretScanningPushProtection = secretScanningPushProtection;
            this.SecretScanningValidityChecks = secretScanningValidityChecks;
            this.SecretScanningNonProviderPatterns = secretScanningNonProviderPatterns;
            this.PrivateVulnerabilityReporting = privateVulnerabilityReporting;
            this.Enforcement = enforcement;
            this.Url = url;
            this.HtmlUrl = htmlUrl;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeSecurityConfiguration" /> class.
        /// </summary>
        public CodeSecurityConfiguration()
        {
        }
    }
}
//HintName: G.Models.CodeSecurityUpdateConfigurationRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeSecurityUpdateConfigurationRequest
    {
        /// <summary>
        /// The name of the code security configuration. Must be unique within the organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A description of the code security configuration
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The enablement status of GitHub Advanced Security
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("advanced_security")]
        public global::G.CodeSecurityUpdateConfigurationRequestAdvancedSecurity? AdvancedSecurity { get; set; }

        /// <summary>
        /// The enablement status of Dependency Graph
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dependency_graph")]
        public global::G.CodeSecurityUpdateConfigurationRequestDependencyGraph? DependencyGraph { get; set; }

        /// <summary>
        /// The enablement status of Automatic dependency submission
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dependency_graph_autosubmit_action")]
        public global::G.CodeSecurityUpdateConfigurationRequestDependencyGraphAutosubmitAction? DependencyGraphAutosubmitAction { get; set; }

        /// <summary>
        /// Feature options for Automatic dependency submission
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dependency_graph_autosubmit_action_options")]
        public global::G.CodeSecurityUpdateConfigurationRequestDependencyGraphAutosubmitActionOptions? DependencyGraphAutosubmitActionOptions { get; set; }

        /// <summary>
        /// The enablement status of Dependabot alerts
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dependabot_alerts")]
        public global::G.CodeSecurityUpdateConfigurationRequestDependabotAlerts? DependabotAlerts { get; set; }

        /// <summary>
        /// The enablement status of Dependabot security updates
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dependabot_security_updates")]
        public global::G.CodeSecurityUpdateConfigurationRequestDependabotSecurityUpdates? DependabotSecurityUpdates { get; set; }

        /// <summary>
        /// The enablement status of code scanning default setup
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code_scanning_default_setup")]
        public global::G.CodeSecurityUpdateConfigurationRequestCodeScanningDefaultSetup? CodeScanningDefaultSetup { get; set; }

        /// <summary>
        /// The enablement status of secret scanning
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secret_scanning")]
        public global::G.CodeSecurityUpdateConfigurationRequestSecretScanning? SecretScanning { get; set; }

        /// <summary>
        /// The enablement status of secret scanning push protection
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secret_scanning_push_protection")]
        public global::G.CodeSecurityUpdateConfigurationRequestSecretScanningPushProtection? SecretScanningPushProtection { get; set; }

        /// <summary>
        /// The enablement status of secret scanning validity checks
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secret_scanning_validity_checks")]
        public global::G.CodeSecurityUpdateConfigurationRequestSecretScanningValidityChecks? SecretScanningValidityChecks { get; set; }

        /// <summary>
        /// The enablement status of secret scanning non-provider patterns
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secret_scanning_non_provider_patterns")]
        public global::G.CodeSecurityUpdateConfigurationRequestSecretScanningNonProviderPatterns? SecretScanningNonProviderPatterns { get; set; }

        /// <summary>
        /// The enablement status of private vulnerability reporting
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("private_vulnerability_reporting")]
        public global::G.CodeSecurityUpdateConfigurationRequestPrivateVulnerabilityReporting? PrivateVulnerabilityReporting { get; set; }

        /// <summary>
        /// The enforcement status for a security configuration
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enforcement")]
        public global::G.CodeSecurityUpdateConfigurationRequestEnforcement? Enforcement { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeSecurityUpdateConfigurationRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the code security configuration. Must be unique within the organization.
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
        public CodeSecurityUpdateConfigurationRequest(
            string? name,
            string? description,
            global::G.CodeSecurityUpdateConfigurationRequestAdvancedSecurity? advancedSecurity,
            global::G.CodeSecurityUpdateConfigurationRequestDependencyGraph? dependencyGraph,
            global::G.CodeSecurityUpdateConfigurationRequestDependencyGraphAutosubmitAction? dependencyGraphAutosubmitAction,
            global::G.CodeSecurityUpdateConfigurationRequestDependencyGraphAutosubmitActionOptions? dependencyGraphAutosubmitActionOptions,
            global::G.CodeSecurityUpdateConfigurationRequestDependabotAlerts? dependabotAlerts,
            global::G.CodeSecurityUpdateConfigurationRequestDependabotSecurityUpdates? dependabotSecurityUpdates,
            global::G.CodeSecurityUpdateConfigurationRequestCodeScanningDefaultSetup? codeScanningDefaultSetup,
            global::G.CodeSecurityUpdateConfigurationRequestSecretScanning? secretScanning,
            global::G.CodeSecurityUpdateConfigurationRequestSecretScanningPushProtection? secretScanningPushProtection,
            global::G.CodeSecurityUpdateConfigurationRequestSecretScanningValidityChecks? secretScanningValidityChecks,
            global::G.CodeSecurityUpdateConfigurationRequestSecretScanningNonProviderPatterns? secretScanningNonProviderPatterns,
            global::G.CodeSecurityUpdateConfigurationRequestPrivateVulnerabilityReporting? privateVulnerabilityReporting,
            global::G.CodeSecurityUpdateConfigurationRequestEnforcement? enforcement)
        {
            this.Name = name;
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
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeSecurityUpdateConfigurationRequest" /> class.
        /// </summary>
        public CodeSecurityUpdateConfigurationRequest()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.CodeSecurityUpdateConfigurationRequest? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.CodeSecurityUpdateConfigurationRequest>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.CodeSecurityUpdateConfigurationRequest?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.CodeSecurityUpdateConfigurationRequest?>(serializer.Deserialize<global::G.CodeSecurityUpdateConfigurationRequest>(jsonReader));
        }

    }
}
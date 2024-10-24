﻿//HintName: G.Models.CodeSecurityConfiguration.g.cs

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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// The name of the code security configuration. Must be unique within the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The type of the code security configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CodeSecurityConfigurationTargetTypeJsonConverter))]
        public global::G.CodeSecurityConfigurationTargetType? TargetType { get; set; }

        /// <summary>
        /// A description of the code security configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The enablement status of GitHub Advanced Security
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("advanced_security")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CodeSecurityConfigurationAdvancedSecurityJsonConverter))]
        public global::G.CodeSecurityConfigurationAdvancedSecurity? AdvancedSecurity { get; set; }

        /// <summary>
        /// The enablement status of Dependency Graph
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependency_graph")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CodeSecurityConfigurationDependencyGraphJsonConverter))]
        public global::G.CodeSecurityConfigurationDependencyGraph? DependencyGraph { get; set; }

        /// <summary>
        /// The enablement status of Automatic dependency submission
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependency_graph_autosubmit_action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CodeSecurityConfigurationDependencyGraphAutosubmitActionJsonConverter))]
        public global::G.CodeSecurityConfigurationDependencyGraphAutosubmitAction? DependencyGraphAutosubmitAction { get; set; }

        /// <summary>
        /// Feature options for Automatic dependency submission
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependency_graph_autosubmit_action_options")]
        public global::G.CodeSecurityConfigurationDependencyGraphAutosubmitActionOptions? DependencyGraphAutosubmitActionOptions { get; set; }

        /// <summary>
        /// The enablement status of Dependabot alerts
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependabot_alerts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CodeSecurityConfigurationDependabotAlertsJsonConverter))]
        public global::G.CodeSecurityConfigurationDependabotAlerts? DependabotAlerts { get; set; }

        /// <summary>
        /// The enablement status of Dependabot security updates
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependabot_security_updates")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CodeSecurityConfigurationDependabotSecurityUpdatesJsonConverter))]
        public global::G.CodeSecurityConfigurationDependabotSecurityUpdates? DependabotSecurityUpdates { get; set; }

        /// <summary>
        /// The enablement status of code scanning default setup
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_scanning_default_setup")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CodeSecurityConfigurationCodeScanningDefaultSetupJsonConverter))]
        public global::G.CodeSecurityConfigurationCodeScanningDefaultSetup? CodeScanningDefaultSetup { get; set; }

        /// <summary>
        /// The enablement status of secret scanning
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CodeSecurityConfigurationSecretScanningJsonConverter))]
        public global::G.CodeSecurityConfigurationSecretScanning? SecretScanning { get; set; }

        /// <summary>
        /// The enablement status of secret scanning push protection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_push_protection")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CodeSecurityConfigurationSecretScanningPushProtectionJsonConverter))]
        public global::G.CodeSecurityConfigurationSecretScanningPushProtection? SecretScanningPushProtection { get; set; }

        /// <summary>
        /// The enablement status of secret scanning validity checks
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_validity_checks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CodeSecurityConfigurationSecretScanningValidityChecksJsonConverter))]
        public global::G.CodeSecurityConfigurationSecretScanningValidityChecks? SecretScanningValidityChecks { get; set; }

        /// <summary>
        /// The enablement status of secret scanning non-provider patterns
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_non_provider_patterns")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CodeSecurityConfigurationSecretScanningNonProviderPatternsJsonConverter))]
        public global::G.CodeSecurityConfigurationSecretScanningNonProviderPatterns? SecretScanningNonProviderPatterns { get; set; }

        /// <summary>
        /// The enablement status of private vulnerability reporting
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private_vulnerability_reporting")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CodeSecurityConfigurationPrivateVulnerabilityReportingJsonConverter))]
        public global::G.CodeSecurityConfigurationPrivateVulnerabilityReporting? PrivateVulnerabilityReporting { get; set; }

        /// <summary>
        /// The enforcement status for a security configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforcement")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CodeSecurityConfigurationEnforcementJsonConverter))]
        public global::G.CodeSecurityConfigurationEnforcement? Enforcement { get; set; }

        /// <summary>
        /// The URL of the configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The URL of the configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::G.CodeSecurityConfiguration? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.CodeSecurityConfiguration),
                jsonSerializerContext) as global::G.CodeSecurityConfiguration;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.CodeSecurityConfiguration? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.CodeSecurityConfiguration>(
                json,
                jsonSerializerOptions);
        }

    }
}
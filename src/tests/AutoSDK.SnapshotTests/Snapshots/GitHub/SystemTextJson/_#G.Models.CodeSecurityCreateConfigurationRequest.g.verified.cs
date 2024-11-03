//HintName: G.Models.CodeSecurityCreateConfigurationRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeSecurityCreateConfigurationRequest
    {
        /// <summary>
        /// The name of the code security configuration. Must be unique within the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A description of the code security configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// The enablement status of GitHub Advanced Security<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("advanced_security")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CodeSecurityCreateConfigurationRequestAdvancedSecurityJsonConverter))]
        public global::G.CodeSecurityCreateConfigurationRequestAdvancedSecurity? AdvancedSecurity { get; set; }

        /// <summary>
        /// The enablement status of Dependency Graph<br/>
        /// Default Value: enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependency_graph")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CodeSecurityCreateConfigurationRequestDependencyGraphJsonConverter))]
        public global::G.CodeSecurityCreateConfigurationRequestDependencyGraph? DependencyGraph { get; set; }

        /// <summary>
        /// The enablement status of Automatic dependency submission<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependency_graph_autosubmit_action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CodeSecurityCreateConfigurationRequestDependencyGraphAutosubmitActionJsonConverter))]
        public global::G.CodeSecurityCreateConfigurationRequestDependencyGraphAutosubmitAction? DependencyGraphAutosubmitAction { get; set; }

        /// <summary>
        /// Feature options for Automatic dependency submission
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependency_graph_autosubmit_action_options")]
        public global::G.CodeSecurityCreateConfigurationRequestDependencyGraphAutosubmitActionOptions? DependencyGraphAutosubmitActionOptions { get; set; }

        /// <summary>
        /// The enablement status of Dependabot alerts<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependabot_alerts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CodeSecurityCreateConfigurationRequestDependabotAlertsJsonConverter))]
        public global::G.CodeSecurityCreateConfigurationRequestDependabotAlerts? DependabotAlerts { get; set; }

        /// <summary>
        /// The enablement status of Dependabot security updates<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependabot_security_updates")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CodeSecurityCreateConfigurationRequestDependabotSecurityUpdatesJsonConverter))]
        public global::G.CodeSecurityCreateConfigurationRequestDependabotSecurityUpdates? DependabotSecurityUpdates { get; set; }

        /// <summary>
        /// The enablement status of code scanning default setup<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_scanning_default_setup")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CodeSecurityCreateConfigurationRequestCodeScanningDefaultSetupJsonConverter))]
        public global::G.CodeSecurityCreateConfigurationRequestCodeScanningDefaultSetup? CodeScanningDefaultSetup { get; set; }

        /// <summary>
        /// The enablement status of secret scanning<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CodeSecurityCreateConfigurationRequestSecretScanningJsonConverter))]
        public global::G.CodeSecurityCreateConfigurationRequestSecretScanning? SecretScanning { get; set; }

        /// <summary>
        /// The enablement status of secret scanning push protection<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_push_protection")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CodeSecurityCreateConfigurationRequestSecretScanningPushProtectionJsonConverter))]
        public global::G.CodeSecurityCreateConfigurationRequestSecretScanningPushProtection? SecretScanningPushProtection { get; set; }

        /// <summary>
        /// The enablement status of secret scanning validity checks<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_validity_checks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CodeSecurityCreateConfigurationRequestSecretScanningValidityChecksJsonConverter))]
        public global::G.CodeSecurityCreateConfigurationRequestSecretScanningValidityChecks? SecretScanningValidityChecks { get; set; }

        /// <summary>
        /// The enablement status of secret scanning non provider patterns<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_non_provider_patterns")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CodeSecurityCreateConfigurationRequestSecretScanningNonProviderPatternsJsonConverter))]
        public global::G.CodeSecurityCreateConfigurationRequestSecretScanningNonProviderPatterns? SecretScanningNonProviderPatterns { get; set; }

        /// <summary>
        /// The enablement status of private vulnerability reporting<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private_vulnerability_reporting")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CodeSecurityCreateConfigurationRequestPrivateVulnerabilityReportingJsonConverter))]
        public global::G.CodeSecurityCreateConfigurationRequestPrivateVulnerabilityReporting? PrivateVulnerabilityReporting { get; set; }

        /// <summary>
        /// The enforcement status for a security configuration<br/>
        /// Default Value: enforced
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforcement")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CodeSecurityCreateConfigurationRequestEnforcementJsonConverter))]
        public global::G.CodeSecurityCreateConfigurationRequestEnforcement? Enforcement { get; set; }

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
        public static global::G.CodeSecurityCreateConfigurationRequest? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.CodeSecurityCreateConfigurationRequest),
                jsonSerializerContext) as global::G.CodeSecurityCreateConfigurationRequest;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.CodeSecurityCreateConfigurationRequest? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.CodeSecurityCreateConfigurationRequest>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.CodeSecurityCreateConfigurationRequest?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.CodeSecurityCreateConfigurationRequest),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.CodeSecurityCreateConfigurationRequest;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.CodeSecurityCreateConfigurationRequest?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.CodeSecurityCreateConfigurationRequest?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}
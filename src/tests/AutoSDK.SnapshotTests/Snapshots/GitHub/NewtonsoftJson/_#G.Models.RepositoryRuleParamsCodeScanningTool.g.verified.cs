//HintName: G.Models.RepositoryRuleParamsCodeScanningTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A tool that must provide code scanning results for this rule to pass.
    /// </summary>
    public sealed partial class RepositoryRuleParamsCodeScanningTool
    {
        /// <summary>
        /// The severity level at which code scanning results that raise alerts block a reference update. For more information on alert severity levels, see "[About code scanning alerts](https://docs.github.com/code-security/code-scanning/managing-code-scanning-alerts/about-code-scanning-alerts#about-alert-severity-and-security-severity-levels)."
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("alerts_threshold", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RepositoryRuleParamsCodeScanningToolAlertsThreshold AlertsThreshold { get; set; } = default!;

        /// <summary>
        /// The severity level at which code scanning results that raise security alerts block a reference update. For more information on security severity levels, see "[About code scanning alerts](https://docs.github.com/code-security/code-scanning/managing-code-scanning-alerts/about-code-scanning-alerts#about-alert-severity-and-security-severity-levels)."
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("security_alerts_threshold", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RepositoryRuleParamsCodeScanningToolSecurityAlertsThreshold SecurityAlertsThreshold { get; set; } = default!;

        /// <summary>
        /// The name of a code scanning tool
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool", Required = global::Newtonsoft.Json.Required.Always)]
        public string Tool { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleParamsCodeScanningTool" /> class.
        /// </summary>
        /// <param name="alertsThreshold">
        /// The severity level at which code scanning results that raise alerts block a reference update. For more information on alert severity levels, see "[About code scanning alerts](https://docs.github.com/code-security/code-scanning/managing-code-scanning-alerts/about-code-scanning-alerts#about-alert-severity-and-security-severity-levels)."
        /// </param>
        /// <param name="securityAlertsThreshold">
        /// The severity level at which code scanning results that raise security alerts block a reference update. For more information on security severity levels, see "[About code scanning alerts](https://docs.github.com/code-security/code-scanning/managing-code-scanning-alerts/about-code-scanning-alerts#about-alert-severity-and-security-severity-levels)."
        /// </param>
        /// <param name="tool">
        /// The name of a code scanning tool
        /// </param>
        public RepositoryRuleParamsCodeScanningTool(
            global::G.RepositoryRuleParamsCodeScanningToolAlertsThreshold alertsThreshold,
            global::G.RepositoryRuleParamsCodeScanningToolSecurityAlertsThreshold securityAlertsThreshold,
            string tool)
        {
            this.AlertsThreshold = alertsThreshold;
            this.SecurityAlertsThreshold = securityAlertsThreshold;
            this.Tool = tool ?? throw new global::System.ArgumentNullException(nameof(tool));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleParamsCodeScanningTool" /> class.
        /// </summary>
        public RepositoryRuleParamsCodeScanningTool()
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
        public static global::G.RepositoryRuleParamsCodeScanningTool? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.RepositoryRuleParamsCodeScanningTool>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.RepositoryRuleParamsCodeScanningTool?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.RepositoryRuleParamsCodeScanningTool?>(serializer.Deserialize<global::G.RepositoryRuleParamsCodeScanningTool>(jsonReader));
        }

    }
}
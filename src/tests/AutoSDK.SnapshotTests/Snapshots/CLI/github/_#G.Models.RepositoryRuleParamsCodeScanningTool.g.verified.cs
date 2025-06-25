﻿//HintName: G.Models.RepositoryRuleParamsCodeScanningTool.g.cs

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
        [global::System.Text.Json.Serialization.JsonPropertyName("alerts_threshold")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RepositoryRuleParamsCodeScanningToolAlertsThresholdJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RepositoryRuleParamsCodeScanningToolAlertsThreshold AlertsThreshold { get; set; }

        /// <summary>
        /// The severity level at which code scanning results that raise security alerts block a reference update. For more information on security severity levels, see "[About code scanning alerts](https://docs.github.com/code-security/code-scanning/managing-code-scanning-alerts/about-code-scanning-alerts#about-alert-severity-and-security-severity-levels)."
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_alerts_threshold")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RepositoryRuleParamsCodeScanningToolSecurityAlertsThresholdJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RepositoryRuleParamsCodeScanningToolSecurityAlertsThreshold SecurityAlertsThreshold { get; set; }

        /// <summary>
        /// The name of a code scanning tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Tool { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
    }
}
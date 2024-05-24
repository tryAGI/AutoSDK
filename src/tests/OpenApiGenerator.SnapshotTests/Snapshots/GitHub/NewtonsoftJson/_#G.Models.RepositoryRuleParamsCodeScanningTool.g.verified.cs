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
        public RepositoryRuleParamsCodeScanningToolAlertsThreshold AlertsThreshold { get; set; } = default!;

        /// <summary>
        /// The severity level at which code scanning results that raise security alerts block a reference update. For more information on security severity levels, see "[About code scanning alerts](https://docs.github.com/code-security/code-scanning/managing-code-scanning-alerts/about-code-scanning-alerts#about-alert-severity-and-security-severity-levels)."
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("security_alerts_threshold", Required = global::Newtonsoft.Json.Required.Always)]
        public RepositoryRuleParamsCodeScanningToolSecurityAlertsThreshold SecurityAlertsThreshold { get; set; } = default!;

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
    }
}
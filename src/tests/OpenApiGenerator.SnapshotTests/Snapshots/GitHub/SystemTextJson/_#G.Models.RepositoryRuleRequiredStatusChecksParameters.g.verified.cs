//HintName: G.Models.RepositoryRuleRequiredStatusChecksParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RepositoryRuleRequiredStatusChecksParameters
    {
        /// <summary>
        /// Status checks that are required.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_status_checks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<RepositoryRuleParamsStatusCheckConfiguration> RequiredStatusChecks { get; set; }

        /// <summary>
        /// Whether pull requests targeting a matching branch must be tested with the latest code. This setting will not take effect unless at least one status check is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strict_required_status_checks_policy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool StrictRequiredStatusChecksPolicy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
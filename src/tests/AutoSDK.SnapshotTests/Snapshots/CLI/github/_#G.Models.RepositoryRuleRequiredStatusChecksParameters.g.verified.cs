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
        /// Allow repositories and branches to be created if a check would otherwise prohibit it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("do_not_enforce_on_create")]
        public bool? DoNotEnforceOnCreate { get; set; }

        /// <summary>
        /// Status checks that are required.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_status_checks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.RepositoryRuleParamsStatusCheckConfiguration> RequiredStatusChecks { get; set; }

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

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleRequiredStatusChecksParameters" /> class.
        /// </summary>
        /// <param name="doNotEnforceOnCreate">
        /// Allow repositories and branches to be created if a check would otherwise prohibit it.
        /// </param>
        /// <param name="requiredStatusChecks">
        /// Status checks that are required.
        /// </param>
        /// <param name="strictRequiredStatusChecksPolicy">
        /// Whether pull requests targeting a matching branch must be tested with the latest code. This setting will not take effect unless at least one status check is enabled.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RepositoryRuleRequiredStatusChecksParameters(
            global::System.Collections.Generic.IList<global::G.RepositoryRuleParamsStatusCheckConfiguration> requiredStatusChecks,
            bool strictRequiredStatusChecksPolicy,
            bool? doNotEnforceOnCreate)
        {
            this.RequiredStatusChecks = requiredStatusChecks ?? throw new global::System.ArgumentNullException(nameof(requiredStatusChecks));
            this.StrictRequiredStatusChecksPolicy = strictRequiredStatusChecksPolicy;
            this.DoNotEnforceOnCreate = doNotEnforceOnCreate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleRequiredStatusChecksParameters" /> class.
        /// </summary>
        public RepositoryRuleRequiredStatusChecksParameters()
        {
        }
    }
}
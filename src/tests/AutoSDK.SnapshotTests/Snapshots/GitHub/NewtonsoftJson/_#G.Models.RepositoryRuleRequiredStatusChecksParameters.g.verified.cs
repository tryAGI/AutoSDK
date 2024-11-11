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
        [global::Newtonsoft.Json.JsonProperty("do_not_enforce_on_create")]
        public bool? DoNotEnforceOnCreate { get; set; }

        /// <summary>
        /// Status checks that are required.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required_status_checks", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.RepositoryRuleParamsStatusCheckConfiguration> RequiredStatusChecks { get; set; } = default!;

        /// <summary>
        /// Whether pull requests targeting a matching branch must be tested with the latest code. This setting will not take effect unless at least one status check is enabled.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("strict_required_status_checks_policy", Required = global::Newtonsoft.Json.Required.Always)]
        public bool StrictRequiredStatusChecksPolicy { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
//HintName: G.Models.RepositoryRuleWorkflowsParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RepositoryRuleWorkflowsParameters
    {
        /// <summary>
        /// Allow repositories and branches to be created if a check would otherwise prohibit it.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("do_not_enforce_on_create")]
        public bool? DoNotEnforceOnCreate { get; set; }

        /// <summary>
        /// Workflows that must pass for this rule to pass.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflows", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.RepositoryRuleParamsWorkflowFileReference> Workflows { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleWorkflowsParameters" /> class.
        /// </summary>
        /// <param name="doNotEnforceOnCreate">
        /// Allow repositories and branches to be created if a check would otherwise prohibit it.
        /// </param>
        /// <param name="workflows">
        /// Workflows that must pass for this rule to pass.
        /// </param>
        public RepositoryRuleWorkflowsParameters(
            global::System.Collections.Generic.IList<global::G.RepositoryRuleParamsWorkflowFileReference> workflows,
            bool? doNotEnforceOnCreate)
        {
            this.Workflows = workflows ?? throw new global::System.ArgumentNullException(nameof(workflows));
            this.DoNotEnforceOnCreate = doNotEnforceOnCreate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleWorkflowsParameters" /> class.
        /// </summary>
        public RepositoryRuleWorkflowsParameters()
        {
        }
    }
}
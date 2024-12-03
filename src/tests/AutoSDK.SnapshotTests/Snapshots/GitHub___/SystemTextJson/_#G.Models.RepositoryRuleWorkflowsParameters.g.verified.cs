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
        [global::System.Text.Json.Serialization.JsonPropertyName("do_not_enforce_on_create")]
        public bool? DoNotEnforceOnCreate { get; set; }

        /// <summary>
        /// Workflows that must pass for this rule to pass.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflows")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.RepositoryRuleParamsWorkflowFileReference> Workflows { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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
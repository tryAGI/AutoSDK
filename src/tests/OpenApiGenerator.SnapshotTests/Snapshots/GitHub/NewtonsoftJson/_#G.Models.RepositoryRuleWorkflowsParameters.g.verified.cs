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
        /// Workflows that must pass for this rule to pass.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflows", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<RepositoryRuleParamsWorkflowFileReference> Workflows { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
//HintName: G.Models.RepositoryRuleWorkflows.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Require all changes made to a targeted branch to pass the specified workflows before they can be merged.
    /// </summary>
    public sealed partial class RepositoryRuleWorkflows
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RepositoryRuleWorkflowsType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters")]
        public global::G.RepositoryRuleWorkflowsParameters? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleWorkflows" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="parameters"></param>
        public RepositoryRuleWorkflows(
            global::G.RepositoryRuleWorkflowsType type,
            global::G.RepositoryRuleWorkflowsParameters? parameters)
        {
            this.Type = type;
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleWorkflows" /> class.
        /// </summary>
        public RepositoryRuleWorkflows()
        {
        }
    }
}
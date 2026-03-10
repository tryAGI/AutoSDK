//HintName: G.Models.WorkflowFeaturesUsageCommonModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowFeaturesUsageCommonModel
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_node")]
        public global::G.FeatureStatusCommonModel? ToolNode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("standalone_agent_node")]
        public global::G.FeatureStatusCommonModel? StandaloneAgentNode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phone_number_node")]
        public global::G.FeatureStatusCommonModel? PhoneNumberNode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_node")]
        public global::G.FeatureStatusCommonModel? EndNode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowFeaturesUsageCommonModel" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Default Value: false
        /// </param>
        /// <param name="toolNode"></param>
        /// <param name="standaloneAgentNode"></param>
        /// <param name="phoneNumberNode"></param>
        /// <param name="endNode"></param>
        public WorkflowFeaturesUsageCommonModel(
            bool? enabled,
            global::G.FeatureStatusCommonModel? toolNode,
            global::G.FeatureStatusCommonModel? standaloneAgentNode,
            global::G.FeatureStatusCommonModel? phoneNumberNode,
            global::G.FeatureStatusCommonModel? endNode)
        {
            this.Enabled = enabled;
            this.ToolNode = toolNode;
            this.StandaloneAgentNode = standaloneAgentNode;
            this.PhoneNumberNode = phoneNumberNode;
            this.EndNode = endNode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowFeaturesUsageCommonModel" /> class.
        /// </summary>
        public WorkflowFeaturesUsageCommonModel()
        {
        }
    }
}
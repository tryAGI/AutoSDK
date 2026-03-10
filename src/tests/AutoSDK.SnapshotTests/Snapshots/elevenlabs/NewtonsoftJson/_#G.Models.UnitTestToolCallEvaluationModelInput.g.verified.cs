//HintName: G.Models.UnitTestToolCallEvaluationModelInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UnitTestToolCallEvaluationModelInput
    {
        /// <summary>
        /// Parameters to evaluate for the agent's tool call. If empty, the tool call parameters are not evaluated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters")]
        public global::System.Collections.Generic.IList<global::G.UnitTestToolCallParameter>? Parameters { get; set; }

        /// <summary>
        /// The tool to evaluate a call against.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("referenced_tool")]
        public global::G.ReferencedToolCommonModel? ReferencedTool { get; set; }

        /// <summary>
        /// Whether to verify that the tool was NOT called.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("verify_absence")]
        public bool? VerifyAbsence { get; set; }

        /// <summary>
        /// Configuration for testing workflow node transitions. When set, the test will verify the agent transitions to the specified workflow node.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflow_node_transition")]
        public global::G.UnitTestWorkflowNodeTransitionEvaluationNodeId? WorkflowNodeTransition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitTestToolCallEvaluationModelInput" /> class.
        /// </summary>
        /// <param name="parameters">
        /// Parameters to evaluate for the agent's tool call. If empty, the tool call parameters are not evaluated.
        /// </param>
        /// <param name="referencedTool">
        /// The tool to evaluate a call against.
        /// </param>
        /// <param name="verifyAbsence">
        /// Whether to verify that the tool was NOT called.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="workflowNodeTransition">
        /// Configuration for testing workflow node transitions. When set, the test will verify the agent transitions to the specified workflow node.
        /// </param>
        public UnitTestToolCallEvaluationModelInput(
            global::System.Collections.Generic.IList<global::G.UnitTestToolCallParameter>? parameters,
            global::G.ReferencedToolCommonModel? referencedTool,
            bool? verifyAbsence,
            global::G.UnitTestWorkflowNodeTransitionEvaluationNodeId? workflowNodeTransition)
        {
            this.Parameters = parameters;
            this.ReferencedTool = referencedTool;
            this.VerifyAbsence = verifyAbsence;
            this.WorkflowNodeTransition = workflowNodeTransition;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitTestToolCallEvaluationModelInput" /> class.
        /// </summary>
        public UnitTestToolCallEvaluationModelInput()
        {
        }
    }
}
//HintName: G.Models.SingleTestRunRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SingleTestRunRequestModel
    {
        /// <summary>
        /// ID of the test to run
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("test_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string TestId { get; set; } = default!;

        /// <summary>
        /// ID of the workflow node to run the test on. If not provided, the test will be run on the agent's default workflow node.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflow_node_id")]
        public string? WorkflowNodeId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleTestRunRequestModel" /> class.
        /// </summary>
        /// <param name="testId">
        /// ID of the test to run
        /// </param>
        /// <param name="workflowNodeId">
        /// ID of the workflow node to run the test on. If not provided, the test will be run on the agent's default workflow node.
        /// </param>
        public SingleTestRunRequestModel(
            string testId,
            string? workflowNodeId)
        {
            this.TestId = testId ?? throw new global::System.ArgumentNullException(nameof(testId));
            this.WorkflowNodeId = workflowNodeId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleTestRunRequestModel" /> class.
        /// </summary>
        public SingleTestRunRequestModel()
        {
        }
    }
}
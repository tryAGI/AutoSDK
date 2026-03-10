//HintName: G.Models.AttachedTestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AttachedTestModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("test_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string TestId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflow_node_id")]
        public string? WorkflowNodeId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachedTestModel" /> class.
        /// </summary>
        /// <param name="testId"></param>
        /// <param name="workflowNodeId"></param>
        public AttachedTestModel(
            string testId,
            string? workflowNodeId)
        {
            this.TestId = testId ?? throw new global::System.ArgumentNullException(nameof(testId));
            this.WorkflowNodeId = workflowNodeId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachedTestModel" /> class.
        /// </summary>
        public AttachedTestModel()
        {
        }
    }
}
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
        [global::System.Text.Json.Serialization.JsonPropertyName("test_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_node_id")]
        public string? WorkflowNodeId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachedTestModel" /> class.
        /// </summary>
        /// <param name="testId"></param>
        /// <param name="workflowNodeId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
//HintName: G.Models.WorkflowNodeExecuteHistory.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowNodeExecuteHistory
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_finish")]
        public bool? IsFinish { get; set; }

        /// <summary>
        /// 执行成功
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_output")]
        public string? NodeOutput { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowNodeExecuteHistory" /> class.
        /// </summary>
        /// <param name="isFinish"></param>
        /// <param name="nodeOutput">
        /// 执行成功
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowNodeExecuteHistory(
            bool? isFinish,
            string? nodeOutput)
        {
            this.IsFinish = isFinish;
            this.NodeOutput = nodeOutput;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowNodeExecuteHistory" /> class.
        /// </summary>
        public WorkflowNodeExecuteHistory()
        {
        }
    }
}
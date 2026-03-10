//HintName: G.Models.WorkflowToolNodeModelInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowToolNodeModelInput
    {
        /// <summary>
        /// Default Value: tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Position of the node in the workflow.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        public global::G.PositionInput? Position { get; set; }

        /// <summary>
        /// The ids of outgoing edges in the order they should be evaluated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edge_order")]
        public global::System.Collections.Generic.IList<string>? EdgeOrder { get; set; }

        /// <summary>
        /// List of tools to execute in parallel. The entire node is considered successful if all tools are executed successfully.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::G.WorkflowToolLocator>? Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowToolNodeModelInput" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: tool
        /// </param>
        /// <param name="position">
        /// Position of the node in the workflow.
        /// </param>
        /// <param name="edgeOrder">
        /// The ids of outgoing edges in the order they should be evaluated.
        /// </param>
        /// <param name="tools">
        /// List of tools to execute in parallel. The entire node is considered successful if all tools are executed successfully.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowToolNodeModelInput(
            string? type,
            global::G.PositionInput? position,
            global::System.Collections.Generic.IList<string>? edgeOrder,
            global::System.Collections.Generic.IList<global::G.WorkflowToolLocator>? tools)
        {
            this.Type = type;
            this.Position = position;
            this.EdgeOrder = edgeOrder;
            this.Tools = tools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowToolNodeModelInput" /> class.
        /// </summary>
        public WorkflowToolNodeModelInput()
        {
        }
    }
}
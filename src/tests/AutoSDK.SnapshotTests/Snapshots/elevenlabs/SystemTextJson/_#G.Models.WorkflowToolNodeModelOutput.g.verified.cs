//HintName: G.Models.WorkflowToolNodeModelOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowToolNodeModelOutput
    {
        /// <summary>
        /// Default Value: tool
        /// </summary>
        /// <default>"tool"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "tool";

        /// <summary>
        /// Position of the node in the workflow.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PositionOutput Position { get; set; }

        /// <summary>
        /// The ids of outgoing edges in the order they should be evaluated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edge_order")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> EdgeOrder { get; set; }

        /// <summary>
        /// List of tools to execute in parallel. The entire node is considered successful if all tools are executed successfully.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.WorkflowToolLocator> Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowToolNodeModelOutput" /> class.
        /// </summary>
        /// <param name="position">
        /// Position of the node in the workflow.
        /// </param>
        /// <param name="edgeOrder">
        /// The ids of outgoing edges in the order they should be evaluated.
        /// </param>
        /// <param name="tools">
        /// List of tools to execute in parallel. The entire node is considered successful if all tools are executed successfully.
        /// </param>
        /// <param name="type">
        /// Default Value: tool
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowToolNodeModelOutput(
            global::G.PositionOutput position,
            global::System.Collections.Generic.IList<string> edgeOrder,
            global::System.Collections.Generic.IList<global::G.WorkflowToolLocator> tools,
            string type = "tool")
        {
            this.Type = type;
            this.Position = position ?? throw new global::System.ArgumentNullException(nameof(position));
            this.EdgeOrder = edgeOrder ?? throw new global::System.ArgumentNullException(nameof(edgeOrder));
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowToolNodeModelOutput" /> class.
        /// </summary>
        public WorkflowToolNodeModelOutput()
        {
        }
    }
}
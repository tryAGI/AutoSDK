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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Position of the node in the workflow.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("position")]
        public global::G.PositionInput? Position { get; set; }

        /// <summary>
        /// The ids of outgoing edges in the order they should be evaluated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("edge_order")]
        public global::System.Collections.Generic.IList<string>? EdgeOrder { get; set; }

        /// <summary>
        /// List of tools to execute in parallel. The entire node is considered successful if all tools are executed successfully.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools")]
        public global::System.Collections.Generic.IList<global::G.WorkflowToolLocator>? Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
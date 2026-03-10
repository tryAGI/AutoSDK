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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "tool";

        /// <summary>
        /// Position of the node in the workflow.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("position", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PositionOutput Position { get; set; } = default!;

        /// <summary>
        /// The ids of outgoing edges in the order they should be evaluated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("edge_order", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> EdgeOrder { get; set; } = default!;

        /// <summary>
        /// List of tools to execute in parallel. The entire node is considered successful if all tools are executed successfully.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.WorkflowToolLocator> Tools { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowToolNodeModelOutput" /> class.
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
        public WorkflowToolNodeModelOutput(
            global::G.PositionOutput position,
            global::System.Collections.Generic.IList<string> edgeOrder,
            global::System.Collections.Generic.IList<global::G.WorkflowToolLocator> tools,
            string type = "tool")
        {
            this.Position = position ?? throw new global::System.ArgumentNullException(nameof(position));
            this.EdgeOrder = edgeOrder ?? throw new global::System.ArgumentNullException(nameof(edgeOrder));
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowToolNodeModelOutput" /> class.
        /// </summary>
        public WorkflowToolNodeModelOutput()
        {
        }
    }
}
//HintName: G.Models.WorkflowEndNodeModelOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowEndNodeModelOutput
    {
        /// <summary>
        /// Default Value: end
        /// </summary>
        /// <default>"end"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "end";

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowEndNodeModelOutput" /> class.
        /// </summary>
        /// <param name="position">
        /// Position of the node in the workflow.
        /// </param>
        /// <param name="edgeOrder">
        /// The ids of outgoing edges in the order they should be evaluated.
        /// </param>
        /// <param name="type">
        /// Default Value: end
        /// </param>
        public WorkflowEndNodeModelOutput(
            global::G.PositionOutput position,
            global::System.Collections.Generic.IList<string> edgeOrder,
            string type = "end")
        {
            this.Type = type;
            this.Position = position ?? throw new global::System.ArgumentNullException(nameof(position));
            this.EdgeOrder = edgeOrder ?? throw new global::System.ArgumentNullException(nameof(edgeOrder));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowEndNodeModelOutput" /> class.
        /// </summary>
        public WorkflowEndNodeModelOutput()
        {
        }
    }
}
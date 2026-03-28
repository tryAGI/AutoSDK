//HintName: G.Models.WorkflowStartNodeModelOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowStartNodeModelOutput
    {
        /// <summary>
        /// Default Value: start
        /// </summary>
        /// <default>"start"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "start";

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowStartNodeModelOutput" /> class.
        /// </summary>
        /// <param name="position">
        /// Position of the node in the workflow.
        /// </param>
        /// <param name="edgeOrder">
        /// The ids of outgoing edges in the order they should be evaluated.
        /// </param>
        /// <param name="type">
        /// Default Value: start
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowStartNodeModelOutput(
            global::G.PositionOutput position,
            global::System.Collections.Generic.IList<string> edgeOrder,
            string type = "start")
        {
            this.Type = type;
            this.Position = position ?? throw new global::System.ArgumentNullException(nameof(position));
            this.EdgeOrder = edgeOrder ?? throw new global::System.ArgumentNullException(nameof(edgeOrder));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowStartNodeModelOutput" /> class.
        /// </summary>
        public WorkflowStartNodeModelOutput()
        {
        }
    }
}
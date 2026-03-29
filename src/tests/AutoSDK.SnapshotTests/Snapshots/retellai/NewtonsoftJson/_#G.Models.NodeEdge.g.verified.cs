//HintName: G.Models.NodeEdge.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NodeEdge
    {
        /// <summary>
        /// Unique identifier for the edge
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transition_condition", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.PromptCondition, global::G.EquationCondition> TransitionCondition { get; set; } = default!;

        /// <summary>
        /// ID of the destination node
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("destination_node_id")]
        public string? DestinationNodeId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeEdge" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the edge
        /// </param>
        /// <param name="transitionCondition"></param>
        /// <param name="destinationNodeId">
        /// ID of the destination node
        /// </param>
        public NodeEdge(
            string id,
            global::G.OneOf<global::G.PromptCondition, global::G.EquationCondition> transitionCondition,
            string? destinationNodeId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.TransitionCondition = transitionCondition;
            this.DestinationNodeId = destinationNodeId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeEdge" /> class.
        /// </summary>
        public NodeEdge()
        {
        }
    }
}
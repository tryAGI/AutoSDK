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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transition_condition")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.PromptCondition, global::G.EquationCondition>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<global::G.PromptCondition, global::G.EquationCondition> TransitionCondition { get; set; }

        /// <summary>
        /// ID of the destination node
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destination_node_id")]
        public string? DestinationNodeId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
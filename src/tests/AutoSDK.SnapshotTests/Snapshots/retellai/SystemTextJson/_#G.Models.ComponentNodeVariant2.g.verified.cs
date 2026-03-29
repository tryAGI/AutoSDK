//HintName: G.Models.ComponentNodeVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ComponentNodeVariant2
    {
        /// <summary>
        /// Type of the node
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ComponentNodeVariant2TypeJsonConverter))]
        public global::G.ComponentNodeVariant2Type Type { get; set; }

        /// <summary>
        /// The reference ID of the component
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("component_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ComponentId { get; set; }

        /// <summary>
        /// Type of component:<br/>
        /// - local: stored in conversation flow's components array<br/>
        /// - shared: stored in stand-alone conversation-flow-component table
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("component_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ComponentNodeVariant2ComponentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ComponentNodeVariant2ComponentType ComponentType { get; set; }

        /// <summary>
        /// Array of edges for conditional transitions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edges")]
        public global::System.Collections.Generic.IList<global::G.NodeEdge>? Edges { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("else_edge")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ElseEdgeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ElseEdge ElseEdge { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finetune_transition_examples")]
        public global::System.Collections.Generic.IList<global::G.NodeFinetuneTransitionExample>? FinetuneTransitionExamples { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentNodeVariant2" /> class.
        /// </summary>
        /// <param name="componentId">
        /// The reference ID of the component
        /// </param>
        /// <param name="componentType">
        /// Type of component:<br/>
        /// - local: stored in conversation flow's components array<br/>
        /// - shared: stored in stand-alone conversation-flow-component table
        /// </param>
        /// <param name="elseEdge"></param>
        /// <param name="type">
        /// Type of the node
        /// </param>
        /// <param name="edges">
        /// Array of edges for conditional transitions
        /// </param>
        /// <param name="finetuneTransitionExamples"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ComponentNodeVariant2(
            string componentId,
            global::G.ComponentNodeVariant2ComponentType componentType,
            global::G.ElseEdge elseEdge,
            global::G.ComponentNodeVariant2Type type,
            global::System.Collections.Generic.IList<global::G.NodeEdge>? edges,
            global::System.Collections.Generic.IList<global::G.NodeFinetuneTransitionExample>? finetuneTransitionExamples)
        {
            this.Type = type;
            this.ComponentId = componentId ?? throw new global::System.ArgumentNullException(nameof(componentId));
            this.ComponentType = componentType;
            this.Edges = edges;
            this.ElseEdge = elseEdge;
            this.FinetuneTransitionExamples = finetuneTransitionExamples;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentNodeVariant2" /> class.
        /// </summary>
        public ComponentNodeVariant2()
        {
        }
    }
}
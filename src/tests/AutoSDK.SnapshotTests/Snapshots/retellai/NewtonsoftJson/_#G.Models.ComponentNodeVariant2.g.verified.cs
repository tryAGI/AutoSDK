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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ComponentNodeVariant2Type Type { get; set; }

        /// <summary>
        /// The reference ID of the component
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("component_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ComponentId { get; set; } = default!;

        /// <summary>
        /// Type of component:<br/>
        /// - local: stored in conversation flow's components array<br/>
        /// - shared: stored in stand-alone conversation-flow-component table
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("component_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ComponentNodeVariant2ComponentType ComponentType { get; set; } = default!;

        /// <summary>
        /// Array of edges for conditional transitions
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("edges")]
        public global::System.Collections.Generic.IList<global::G.NodeEdge>? Edges { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("else_edge", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ElseEdge ElseEdge { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finetune_transition_examples")]
        public global::System.Collections.Generic.IList<global::G.NodeFinetuneTransitionExample>? FinetuneTransitionExamples { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
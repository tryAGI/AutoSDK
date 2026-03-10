//HintName: G.Models.WorkflowEdgeModelInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowEdgeModelInput
    {
        /// <summary>
        /// ID of the source node.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source", Required = global::Newtonsoft.Json.Required.Always)]
        public string Source { get; set; } = default!;

        /// <summary>
        /// ID of the target node.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target", Required = global::Newtonsoft.Json.Required.Always)]
        public string Target { get; set; } = default!;

        /// <summary>
        /// Condition that must be met for the edge to be traversed in the forward direction (source to target).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("forward_condition")]
        public global::G.ForwardConditionVariant1? ForwardCondition { get; set; }

        /// <summary>
        /// Condition that must be met for the edge to be traversed in the backward direction (target to source).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("backward_condition")]
        public global::G.BackwardConditionVariant1? BackwardCondition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowEdgeModelInput" /> class.
        /// </summary>
        /// <param name="source">
        /// ID of the source node.
        /// </param>
        /// <param name="target">
        /// ID of the target node.
        /// </param>
        /// <param name="forwardCondition">
        /// Condition that must be met for the edge to be traversed in the forward direction (source to target).
        /// </param>
        /// <param name="backwardCondition">
        /// Condition that must be met for the edge to be traversed in the backward direction (target to source).
        /// </param>
        public WorkflowEdgeModelInput(
            string source,
            string target,
            global::G.ForwardConditionVariant1? forwardCondition,
            global::G.BackwardConditionVariant1? backwardCondition)
        {
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Target = target ?? throw new global::System.ArgumentNullException(nameof(target));
            this.ForwardCondition = forwardCondition;
            this.BackwardCondition = backwardCondition;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowEdgeModelInput" /> class.
        /// </summary>
        public WorkflowEdgeModelInput()
        {
        }
    }
}
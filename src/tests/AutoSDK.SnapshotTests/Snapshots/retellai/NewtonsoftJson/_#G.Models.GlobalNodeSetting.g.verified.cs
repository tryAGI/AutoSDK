//HintName: G.Models.GlobalNodeSetting.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GlobalNodeSetting
    {
        /// <summary>
        /// Condition for global node activation, cannot be empty
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("condition", Required = global::Newtonsoft.Json.Required.Always)]
        public string Condition { get; set; } = default!;

        /// <summary>
        /// The conditions for global node go back. There would be no destination_node_id for these edges.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("go_back_conditions")]
        public global::System.Collections.Generic.IList<global::G.NodeEdge>? GoBackConditions { get; set; }

        /// <summary>
        /// The same global node won't be triggered again within the next N node transitions.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cool_down")]
        public double? CoolDown { get; set; }

        /// <summary>
        /// Transition to this node
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("positive_finetune_examples")]
        public global::System.Collections.Generic.IList<global::G.GlobalNodeFinetuneTransitionExample>? PositiveFinetuneExamples { get; set; }

        /// <summary>
        /// Don't transition to this node
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("negative_finetune_examples")]
        public global::System.Collections.Generic.IList<global::G.GlobalNodeFinetuneTransitionExample>? NegativeFinetuneExamples { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalNodeSetting" /> class.
        /// </summary>
        /// <param name="condition">
        /// Condition for global node activation, cannot be empty
        /// </param>
        /// <param name="goBackConditions">
        /// The conditions for global node go back. There would be no destination_node_id for these edges.
        /// </param>
        /// <param name="coolDown">
        /// The same global node won't be triggered again within the next N node transitions.
        /// </param>
        /// <param name="positiveFinetuneExamples">
        /// Transition to this node
        /// </param>
        /// <param name="negativeFinetuneExamples">
        /// Don't transition to this node
        /// </param>
        public GlobalNodeSetting(
            string condition,
            global::System.Collections.Generic.IList<global::G.NodeEdge>? goBackConditions,
            double? coolDown,
            global::System.Collections.Generic.IList<global::G.GlobalNodeFinetuneTransitionExample>? positiveFinetuneExamples,
            global::System.Collections.Generic.IList<global::G.GlobalNodeFinetuneTransitionExample>? negativeFinetuneExamples)
        {
            this.Condition = condition ?? throw new global::System.ArgumentNullException(nameof(condition));
            this.GoBackConditions = goBackConditions;
            this.CoolDown = coolDown;
            this.PositiveFinetuneExamples = positiveFinetuneExamples;
            this.NegativeFinetuneExamples = negativeFinetuneExamples;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalNodeSetting" /> class.
        /// </summary>
        public GlobalNodeSetting()
        {
        }
    }
}
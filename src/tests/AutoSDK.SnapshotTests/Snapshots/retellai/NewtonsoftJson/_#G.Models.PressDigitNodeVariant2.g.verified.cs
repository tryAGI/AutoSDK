//HintName: G.Models.PressDigitNodeVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PressDigitNodeVariant2
    {
        /// <summary>
        /// Type of the node
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PressDigitNodeVariant2TypeJsonConverter))]
        public global::G.PressDigitNodeVariant2Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("instruction", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NodeInstructionPrompt Instruction { get; set; } = default!;

        /// <summary>
        /// Delay in milliseconds before pressing the digit
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delay_ms")]
        public int? DelayMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("edges")]
        public global::System.Collections.Generic.IList<global::G.NodeEdge>? Edges { get; set; }

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
        /// Initializes a new instance of the <see cref="PressDigitNodeVariant2" /> class.
        /// </summary>
        /// <param name="instruction"></param>
        /// <param name="type">
        /// Type of the node
        /// </param>
        /// <param name="delayMs">
        /// Delay in milliseconds before pressing the digit
        /// </param>
        /// <param name="edges"></param>
        /// <param name="finetuneTransitionExamples"></param>
        public PressDigitNodeVariant2(
            global::G.NodeInstructionPrompt instruction,
            global::G.PressDigitNodeVariant2Type type,
            int? delayMs,
            global::System.Collections.Generic.IList<global::G.NodeEdge>? edges,
            global::System.Collections.Generic.IList<global::G.NodeFinetuneTransitionExample>? finetuneTransitionExamples)
        {
            this.Type = type;
            this.Instruction = instruction ?? throw new global::System.ArgumentNullException(nameof(instruction));
            this.DelayMs = delayMs;
            this.Edges = edges;
            this.FinetuneTransitionExamples = finetuneTransitionExamples;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PressDigitNodeVariant2" /> class.
        /// </summary>
        public PressDigitNodeVariant2()
        {
        }
    }
}
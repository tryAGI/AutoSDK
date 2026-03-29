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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PressDigitNodeVariant2TypeJsonConverter))]
        public global::G.PressDigitNodeVariant2Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instruction")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.NodeInstructionPrompt Instruction { get; set; }

        /// <summary>
        /// Delay in milliseconds before pressing the digit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delay_ms")]
        public int? DelayMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edges")]
        public global::System.Collections.Generic.IList<global::G.NodeEdge>? Edges { get; set; }

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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
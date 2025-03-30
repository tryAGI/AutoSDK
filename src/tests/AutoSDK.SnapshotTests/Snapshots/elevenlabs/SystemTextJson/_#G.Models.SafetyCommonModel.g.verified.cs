//HintName: G.Models.SafetyCommonModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Safety object that has the information of safety evaluations based on used voice.
    /// </summary>
    public sealed partial class SafetyCommonModel
    {
        /// <summary>
        /// Safety evaluation of the agent. Prompt and first message is taken into account.<br/>
        /// The unsafe reason is provided from the evaluation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ivc")]
        public global::G.SafetyEvaluation? Ivc { get; set; }

        /// <summary>
        /// Safety evaluation of the agent. Prompt and first message is taken into account.<br/>
        /// The unsafe reason is provided from the evaluation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("non_ivc")]
        public global::G.SafetyEvaluation? NonIvc { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SafetyCommonModel" /> class.
        /// </summary>
        /// <param name="ivc">
        /// Safety evaluation of the agent. Prompt and first message is taken into account.<br/>
        /// The unsafe reason is provided from the evaluation
        /// </param>
        /// <param name="nonIvc">
        /// Safety evaluation of the agent. Prompt and first message is taken into account.<br/>
        /// The unsafe reason is provided from the evaluation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SafetyCommonModel(
            global::G.SafetyEvaluation? ivc,
            global::G.SafetyEvaluation? nonIvc)
        {
            this.Ivc = ivc;
            this.NonIvc = nonIvc;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SafetyCommonModel" /> class.
        /// </summary>
        public SafetyCommonModel()
        {
        }
    }
}
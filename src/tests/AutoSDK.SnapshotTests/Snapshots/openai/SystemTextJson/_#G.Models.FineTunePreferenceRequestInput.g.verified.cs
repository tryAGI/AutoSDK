//HintName: G.Models.FineTunePreferenceRequestInput.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The per-line training example of a fine-tuning input file for chat models using the dpo method.
    /// </summary>
    public sealed partial class FineTunePreferenceRequestInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public global::G.FineTunePreferenceRequestInputInput? Input { get; set; }

        /// <summary>
        /// The preferred completion message for the output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preferred_completion")]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.ChatCompletionRequestAssistantMessage>>? PreferredCompletion { get; set; }

        /// <summary>
        /// The non-preferred completion message for the output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("non_preferred_completion")]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.ChatCompletionRequestAssistantMessage>>? NonPreferredCompletion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTunePreferenceRequestInput" /> class.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="preferredCompletion">
        /// The preferred completion message for the output.
        /// </param>
        /// <param name="nonPreferredCompletion">
        /// The non-preferred completion message for the output.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FineTunePreferenceRequestInput(
            global::G.FineTunePreferenceRequestInputInput? input,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.ChatCompletionRequestAssistantMessage>>? preferredCompletion,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.ChatCompletionRequestAssistantMessage>>? nonPreferredCompletion)
        {
            this.Input = input;
            this.PreferredCompletion = preferredCompletion;
            this.NonPreferredCompletion = nonPreferredCompletion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTunePreferenceRequestInput" /> class.
        /// </summary>
        public FineTunePreferenceRequestInput()
        {
        }
    }
}
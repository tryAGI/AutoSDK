//HintName: G.Models.CompletionResponseStreamChoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompletionResponseStreamChoice
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DeltaMessage Delta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CompletionResponseStreamChoiceFinishReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CompletionResponseStreamChoiceFinishReason? FinishReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionResponseStreamChoice" /> class.
        /// </summary>
        /// <param name="delta"></param>
        /// <param name="finishReason"></param>
        /// <param name="index"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompletionResponseStreamChoice(
            global::G.DeltaMessage delta,
            global::G.CompletionResponseStreamChoiceFinishReason? finishReason,
            int index)
        {
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
            this.FinishReason = finishReason;
            this.Index = index;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionResponseStreamChoice" /> class.
        /// </summary>
        public CompletionResponseStreamChoice()
        {
        }
    }
}
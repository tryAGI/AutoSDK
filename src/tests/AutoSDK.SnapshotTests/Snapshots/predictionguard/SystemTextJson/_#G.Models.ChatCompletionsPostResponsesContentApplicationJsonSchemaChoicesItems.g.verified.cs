//HintName: G.Models.ChatCompletionsPostResponsesContentApplicationJsonSchemaChoicesItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionsPostResponsesContentApplicationJsonSchemaChoicesItems
    {
        /// <summary>
        /// The index position in the collection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public int? Index { get; set; }

        /// <summary>
        /// The incremental message delta (streaming only).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        public global::G.ChatCompletionsPostResponsesContentApplicationJsonSchemaChoicesItemsDelta? Delta { get; set; }

        /// <summary>
        /// A result choice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public global::G.ChatCompletionsPostResponsesContentApplicationJsonSchemaChoicesItemsMessage? Message { get; set; }

        /// <summary>
        /// The reason the generation finished.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        public string? FinishReason { get; set; }

        /// <summary>
        /// The complete generated text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generated_text")]
        public string? GeneratedText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionsPostResponsesContentApplicationJsonSchemaChoicesItems" /> class.
        /// </summary>
        /// <param name="index">
        /// The index position in the collection.
        /// </param>
        /// <param name="delta">
        /// The incremental message delta (streaming only).
        /// </param>
        /// <param name="message">
        /// A result choice.
        /// </param>
        /// <param name="finishReason">
        /// The reason the generation finished.
        /// </param>
        /// <param name="generatedText">
        /// The complete generated text.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionsPostResponsesContentApplicationJsonSchemaChoicesItems(
            int? index,
            global::G.ChatCompletionsPostResponsesContentApplicationJsonSchemaChoicesItemsDelta? delta,
            global::G.ChatCompletionsPostResponsesContentApplicationJsonSchemaChoicesItemsMessage? message,
            string? finishReason,
            string? generatedText)
        {
            this.Index = index;
            this.Delta = delta;
            this.Message = message;
            this.FinishReason = finishReason;
            this.GeneratedText = generatedText;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionsPostResponsesContentApplicationJsonSchemaChoicesItems" /> class.
        /// </summary>
        public ChatCompletionsPostResponsesContentApplicationJsonSchemaChoicesItems()
        {
        }
    }
}
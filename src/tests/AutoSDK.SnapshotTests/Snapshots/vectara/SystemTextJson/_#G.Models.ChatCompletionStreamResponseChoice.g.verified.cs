//HintName: G.Models.ChatCompletionStreamResponseChoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A single chat completion chunk choice in a streaming response.
    /// </summary>
    public sealed partial class ChatCompletionStreamResponseChoice
    {
        /// <summary>
        /// The index of the choice in the array of choices.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// A partial message update to be merged with previous chunks in a streaming response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ChatCompletionStreamResponseDelta Delta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionStreamResponseChoice" /> class.
        /// </summary>
        /// <param name="index">
        /// The index of the choice in the array of choices.
        /// </param>
        /// <param name="delta">
        /// A partial message update to be merged with previous chunks in a streaming response.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionStreamResponseChoice(
            int index,
            global::G.ChatCompletionStreamResponseDelta delta)
        {
            this.Index = index;
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionStreamResponseChoice" /> class.
        /// </summary>
        public ChatCompletionStreamResponseChoice()
        {
        }
    }
}
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
        [global::Newtonsoft.Json.JsonProperty("index", Required = global::Newtonsoft.Json.Required.Always)]
        public int Index { get; set; } = default!;

        /// <summary>
        /// A partial message update to be merged with previous chunks in a streaming response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delta", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ChatCompletionStreamResponseDelta Delta { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
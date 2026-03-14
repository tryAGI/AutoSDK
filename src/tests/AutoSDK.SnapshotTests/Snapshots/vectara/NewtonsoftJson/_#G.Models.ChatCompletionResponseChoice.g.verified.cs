//HintName: G.Models.ChatCompletionResponseChoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A single chat completion choice returned in the response
    /// </summary>
    public sealed partial class ChatCompletionResponseChoice
    {
        /// <summary>
        /// The index of the choice in the array of choices.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index", Required = global::Newtonsoft.Json.Required.Always)]
        public int Index { get; set; } = default!;

        /// <summary>
        /// A message in the chat completion response from the assistant.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ChatCompletionResponseMessage Message { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionResponseChoice" /> class.
        /// </summary>
        /// <param name="index">
        /// The index of the choice in the array of choices.
        /// </param>
        /// <param name="message">
        /// A message in the chat completion response from the assistant.
        /// </param>
        public ChatCompletionResponseChoice(
            int index,
            global::G.ChatCompletionResponseMessage message)
        {
            this.Index = index;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionResponseChoice" /> class.
        /// </summary>
        public ChatCompletionResponseChoice()
        {
        }
    }
}
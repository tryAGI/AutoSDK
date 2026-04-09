//HintName: G.Models.CreateChatCompletionStreamResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The response object for streaming chat completions in chunks.
    /// </summary>
    public sealed partial class CreateChatCompletionStreamResponse
    {
        /// <summary>
        /// The object type, which is always 'chat.completion.chunk' for streaming responses.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateChatCompletionStreamResponseObjectJsonConverter))]
        public global::G.CreateChatCompletionStreamResponseObject Object { get; set; }

        /// <summary>
        /// A list of chat completion chunks.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("choices", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ChatCompletionStreamResponseChoice> Choices { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionStreamResponse" /> class.
        /// </summary>
        /// <param name="choices">
        /// A list of chat completion chunks.
        /// </param>
        /// <param name="object">
        /// The object type, which is always 'chat.completion.chunk' for streaming responses.
        /// </param>
        public CreateChatCompletionStreamResponse(
            global::System.Collections.Generic.IList<global::G.ChatCompletionStreamResponseChoice> choices,
            global::G.CreateChatCompletionStreamResponseObject @object)
        {
            this.Object = @object;
            this.Choices = choices ?? throw new global::System.ArgumentNullException(nameof(choices));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionStreamResponse" /> class.
        /// </summary>
        public CreateChatCompletionStreamResponse()
        {
        }
    }
}
//HintName: G.Models.CreateChatCompletionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response object containing the generated chat completion.
    /// </summary>
    public sealed partial class CreateChatCompletionResponse
    {
        /// <summary>
        /// The object type, which is always 'chat.completion'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.CreateChatCompletionResponseObject Object { get; set; }

        /// <summary>
        /// A list of chat completion choices. Can be more than one if `n` is greater than `1`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("choices", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ChatCompletionResponseChoice> Choices { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionResponse" /> class.
        /// </summary>
        /// <param name="choices">
        /// A list of chat completion choices. Can be more than one if `n` is greater than `1`.
        /// </param>
        /// <param name="object">
        /// The object type, which is always 'chat.completion'.
        /// </param>
        public CreateChatCompletionResponse(
            global::System.Collections.Generic.IList<global::G.ChatCompletionResponseChoice> choices,
            global::G.CreateChatCompletionResponseObject @object)
        {
            this.Object = @object;
            this.Choices = choices ?? throw new global::System.ArgumentNullException(nameof(choices));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionResponse" /> class.
        /// </summary>
        public CreateChatCompletionResponse()
        {
        }
    }
}
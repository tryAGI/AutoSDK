//HintName: G.Models.CreateChatCompletionStreamResponseChoiceLogprobs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Log probability information for the choice.
    /// </summary>
    public sealed partial class CreateChatCompletionStreamResponseChoiceLogprobs
    {
        /// <summary>
        /// A list of message content tokens with log probability information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public global::System.Collections.Generic.IList<global::G.ChatCompletionTokenLogprob>? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionStreamResponseChoiceLogprobs" /> class.
        /// </summary>
        /// <param name="content">
        /// A list of message content tokens with log probability information.
        /// </param>
        public CreateChatCompletionStreamResponseChoiceLogprobs(
            global::System.Collections.Generic.IList<global::G.ChatCompletionTokenLogprob>? content)
        {
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionStreamResponseChoiceLogprobs" /> class.
        /// </summary>
        public CreateChatCompletionStreamResponseChoiceLogprobs()
        {
        }
    }
}
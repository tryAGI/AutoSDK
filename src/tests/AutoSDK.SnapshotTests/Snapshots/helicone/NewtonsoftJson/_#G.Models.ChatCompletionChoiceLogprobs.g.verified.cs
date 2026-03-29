//HintName: G.Models.ChatCompletionChoiceLogprobs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Log probability information for the choice.
    /// </summary>
    public sealed partial class ChatCompletionChoiceLogprobs
    {
        /// <summary>
        /// A list of message content tokens with log probability information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public global::System.Collections.Generic.IList<global::G.ChatCompletionTokenLogprob>? Content { get; set; }

        /// <summary>
        /// A list of message refusal tokens with log probability information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("refusal")]
        public global::System.Collections.Generic.IList<global::G.ChatCompletionTokenLogprob>? Refusal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionChoiceLogprobs" /> class.
        /// </summary>
        /// <param name="content">
        /// A list of message content tokens with log probability information.
        /// </param>
        /// <param name="refusal">
        /// A list of message refusal tokens with log probability information.
        /// </param>
        public ChatCompletionChoiceLogprobs(
            global::System.Collections.Generic.IList<global::G.ChatCompletionTokenLogprob>? content,
            global::System.Collections.Generic.IList<global::G.ChatCompletionTokenLogprob>? refusal)
        {
            this.Content = content;
            this.Refusal = refusal;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionChoiceLogprobs" /> class.
        /// </summary>
        public ChatCompletionChoiceLogprobs()
        {
        }
    }
}
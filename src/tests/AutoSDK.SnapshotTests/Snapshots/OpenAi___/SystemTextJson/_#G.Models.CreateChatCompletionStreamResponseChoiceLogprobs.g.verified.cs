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
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ChatCompletionTokenLogprob>? Content { get; set; }

        /// <summary>
        /// A list of message refusal tokens with log probability information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refusal")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ChatCompletionTokenLogprob>? Refusal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionStreamResponseChoiceLogprobs" /> class.
        /// </summary>
        /// <param name="content">
        /// A list of message content tokens with log probability information.
        /// </param>
        /// <param name="refusal">
        /// A list of message refusal tokens with log probability information.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateChatCompletionStreamResponseChoiceLogprobs(
            global::System.Collections.Generic.IList<global::G.ChatCompletionTokenLogprob>? content,
            global::System.Collections.Generic.IList<global::G.ChatCompletionTokenLogprob>? refusal)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Refusal = refusal ?? throw new global::System.ArgumentNullException(nameof(refusal));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionStreamResponseChoiceLogprobs" /> class.
        /// </summary>
        public CreateChatCompletionStreamResponseChoiceLogprobs()
        {
        }
    }
}
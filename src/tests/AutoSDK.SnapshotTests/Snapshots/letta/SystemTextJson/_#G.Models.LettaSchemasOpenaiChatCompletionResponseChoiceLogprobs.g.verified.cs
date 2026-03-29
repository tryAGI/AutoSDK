//HintName: G.Models.LettaSchemasOpenaiChatCompletionResponseChoiceLogprobs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LettaSchemasOpenaiChatCompletionResponseChoiceLogprobs
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::System.Collections.Generic.IList<global::G.LettaSchemasOpenaiChatCompletionResponseChatCompletionTokenLogprob>? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refusal")]
        public global::System.Collections.Generic.IList<global::G.LettaSchemasOpenaiChatCompletionResponseChatCompletionTokenLogprob>? Refusal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaSchemasOpenaiChatCompletionResponseChoiceLogprobs" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="refusal"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LettaSchemasOpenaiChatCompletionResponseChoiceLogprobs(
            global::System.Collections.Generic.IList<global::G.LettaSchemasOpenaiChatCompletionResponseChatCompletionTokenLogprob>? content,
            global::System.Collections.Generic.IList<global::G.LettaSchemasOpenaiChatCompletionResponseChatCompletionTokenLogprob>? refusal)
        {
            this.Content = content;
            this.Refusal = refusal;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaSchemasOpenaiChatCompletionResponseChoiceLogprobs" /> class.
        /// </summary>
        public LettaSchemasOpenaiChatCompletionResponseChoiceLogprobs()
        {
        }
    }
}
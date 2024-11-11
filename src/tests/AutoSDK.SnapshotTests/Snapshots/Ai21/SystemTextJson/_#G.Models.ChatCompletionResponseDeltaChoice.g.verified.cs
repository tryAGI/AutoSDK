//HintName: G.Models.ChatCompletionResponseDeltaChoice.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionResponseDeltaChoice
    {
        /// <summary>
        /// Always zero in streamed responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// - **The first message** in the stream will be an object set to `{"role":"assistant"}`.<br/>
        /// - **Subsequent messages** will have an object `{"content": __token__}` with the generated token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverterFactory2))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<global::G.ChatStreamingFirstDelta, global::G.ChatStreamingContentDelta> Delta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprobs")]
        public global::G.Logprobs? Logprobs { get; set; }

        /// <summary>
        /// One of the following string values:<br/>
        ///   - `null`: All messages but the last will return null for `finish_reason`.<br/>
        ///   - `stop`: The response ended naturally as a complete answer (due to<br/>
        ///     [end-of-sequence token](https://huggingface.co/docs/transformers/v4.32.1/en/llm_tutorial#generate-text))<br/>
        ///      or because the model generated a stop sequence provided in the request.<br/>
        ///   - `length`:  The response ended by reaching `max_tokens`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        public string? FinishReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionResponseDeltaChoice" /> class.
        /// </summary>
        /// <param name="index">
        /// Always zero in streamed responses.
        /// </param>
        /// <param name="delta">
        /// - **The first message** in the stream will be an object set to `{"role":"assistant"}`.<br/>
        /// - **Subsequent messages** will have an object `{"content": __token__}` with the generated token.
        /// </param>
        /// <param name="logprobs"></param>
        /// <param name="finishReason">
        /// One of the following string values:<br/>
        ///   - `null`: All messages but the last will return null for `finish_reason`.<br/>
        ///   - `stop`: The response ended naturally as a complete answer (due to<br/>
        ///     [end-of-sequence token](https://huggingface.co/docs/transformers/v4.32.1/en/llm_tutorial#generate-text))<br/>
        ///      or because the model generated a stop sequence provided in the request.<br/>
        ///   - `length`:  The response ended by reaching `max_tokens`.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ChatCompletionResponseDeltaChoice(
            int index,
            global::G.AnyOf<global::G.ChatStreamingFirstDelta, global::G.ChatStreamingContentDelta> delta,
            global::G.Logprobs? logprobs,
            string? finishReason)
        {
            this.Index = index;
            this.Delta = delta;
            this.Logprobs = logprobs;
            this.FinishReason = finishReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionResponseDeltaChoice" /> class.
        /// </summary>
        public ChatCompletionResponseDeltaChoice()
        {
        }
    }
}
//HintName: G.Models.CreateChatCompletionStreamResponseUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An optional field that will only be present when you set `stream_options: {"include_usage": true}` in your request.<br/>
    /// When present, it contains a null value except for the last chunk which contains the token usage statistics for the entire request.
    /// </summary>
    public sealed partial class CreateChatCompletionStreamResponseUsage
    {
        /// <summary>
        /// Number of tokens in the generated completion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CompletionTokens { get; set; }

        /// <summary>
        /// Number of tokens in the prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PromptTokens { get; set; }

        /// <summary>
        /// Total number of tokens used in the request (prompt + completion).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionStreamResponseUsage" /> class.
        /// </summary>
        /// <param name="completionTokens">
        /// Number of tokens in the generated completion.
        /// </param>
        /// <param name="promptTokens">
        /// Number of tokens in the prompt.
        /// </param>
        /// <param name="totalTokens">
        /// Total number of tokens used in the request (prompt + completion).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateChatCompletionStreamResponseUsage(
            int completionTokens,
            int promptTokens,
            int totalTokens)
        {
            this.CompletionTokens = completionTokens;
            this.PromptTokens = promptTokens;
            this.TotalTokens = totalTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionStreamResponseUsage" /> class.
        /// </summary>
        public CreateChatCompletionStreamResponseUsage()
        {
        }
    }
}
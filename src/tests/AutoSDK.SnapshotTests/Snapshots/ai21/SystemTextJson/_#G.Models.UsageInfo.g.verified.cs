//HintName: G.Models.UsageInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageInfo
    {
        /// <summary>
        /// Number of tokens in the prompt for this request. Note that the prompt token<br/>
        /// includes the entire message history, plus extra tokens needed by the system<br/>
        /// when combining the list of prompt messages into a single message, as<br/>
        /// required by the model. The number of extra tokens is typically proportional<br/>
        /// to the number of messages in the thread, and should be relatively small.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PromptTokens { get; set; }

        /// <summary>
        /// Number of tokens in the response message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CompletionTokens { get; set; }

        /// <summary>
        /// `prompt_tokens` + `completion_tokens`.
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
        /// Initializes a new instance of the <see cref="UsageInfo" /> class.
        /// </summary>
        /// <param name="promptTokens">
        /// Number of tokens in the prompt for this request. Note that the prompt token<br/>
        /// includes the entire message history, plus extra tokens needed by the system<br/>
        /// when combining the list of prompt messages into a single message, as<br/>
        /// required by the model. The number of extra tokens is typically proportional<br/>
        /// to the number of messages in the thread, and should be relatively small.
        /// </param>
        /// <param name="completionTokens">
        /// Number of tokens in the response message.
        /// </param>
        /// <param name="totalTokens">
        /// `prompt_tokens` + `completion_tokens`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageInfo(
            int promptTokens,
            int completionTokens,
            int totalTokens)
        {
            this.PromptTokens = promptTokens;
            this.CompletionTokens = completionTokens;
            this.TotalTokens = totalTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageInfo" /> class.
        /// </summary>
        public UsageInfo()
        {
        }
    }
}
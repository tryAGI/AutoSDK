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
        [global::Newtonsoft.Json.JsonProperty("completion_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int CompletionTokens { get; set; } = default!;

        /// <summary>
        /// Number of tokens in the prompt.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int PromptTokens { get; set; } = default!;

        /// <summary>
        /// Total number of tokens used in the request (prompt + completion).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalTokens { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
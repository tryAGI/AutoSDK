//HintName: G.Models.ChatCompletionStreamingDelta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The chat completion message from the model. Note: this field is deprecated for streaming. Use `delta` instead.
    /// </summary>
    public sealed partial class ChatCompletionStreamingDelta
    {
        /// <summary>
        /// The text content produced by the model. This field contains the actual output generated, reflecting the model's response to the input query or command.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public string? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ChatMessageRoleJsonConverter))]
        public global::G.ChatMessageRole? Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_calls")]
        public global::System.Collections.Generic.IList<global::G.ToolCallStreaming>? ToolCalls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("graph_data")]
        public global::G.GraphData? GraphData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("llm_data")]
        public global::G.LlmData? LlmData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("translation_data")]
        public global::G.TranslationData? TranslationData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("refusal")]
        public string? Refusal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionStreamingDelta" /> class.
        /// </summary>
        /// <param name="content">
        /// The text content produced by the model. This field contains the actual output generated, reflecting the model's response to the input query or command.
        /// </param>
        /// <param name="role"></param>
        /// <param name="toolCalls"></param>
        /// <param name="graphData"></param>
        /// <param name="llmData"></param>
        /// <param name="translationData"></param>
        /// <param name="refusal"></param>
        public ChatCompletionStreamingDelta(
            string? content,
            global::G.ChatMessageRole? role,
            global::System.Collections.Generic.IList<global::G.ToolCallStreaming>? toolCalls,
            global::G.GraphData? graphData,
            global::G.LlmData? llmData,
            global::G.TranslationData? translationData,
            string? refusal)
        {
            this.Content = content;
            this.Role = role;
            this.ToolCalls = toolCalls;
            this.GraphData = graphData;
            this.LlmData = llmData;
            this.TranslationData = translationData;
            this.Refusal = refusal;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionStreamingDelta" /> class.
        /// </summary>
        public ChatCompletionStreamingDelta()
        {
        }
    }
}
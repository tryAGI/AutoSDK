//HintName: G.Models.ChatCompletionResponseMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The chat completion message from the model. Note: this field is deprecated for streaming. Use `delta` instead.
    /// </summary>
    public sealed partial class ChatCompletionResponseMessage
    {
        /// <summary>
        /// The text content produced by the model. This field contains the actual output generated, reflecting the model's response to the input query or command.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public string Content { get; set; } = default!;

        /// <summary>
        /// Specifies the role associated with the content.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ChatCompletionResponseMessageRoleJsonConverter))]
        public global::G.ChatCompletionResponseMessageRole Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_calls")]
        public global::System.Collections.Generic.IList<global::G.ToolCall>? ToolCalls { get; set; }

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
        [global::Newtonsoft.Json.JsonProperty("web_search_data")]
        public global::G.WebSearchData? WebSearchData { get; set; }

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
        /// Initializes a new instance of the <see cref="ChatCompletionResponseMessage" /> class.
        /// </summary>
        /// <param name="content">
        /// The text content produced by the model. This field contains the actual output generated, reflecting the model's response to the input query or command.
        /// </param>
        /// <param name="role">
        /// Specifies the role associated with the content.
        /// </param>
        /// <param name="toolCalls"></param>
        /// <param name="graphData"></param>
        /// <param name="llmData"></param>
        /// <param name="translationData"></param>
        /// <param name="webSearchData"></param>
        /// <param name="refusal"></param>
        public ChatCompletionResponseMessage(
            string content,
            global::G.ChatCompletionResponseMessageRole role,
            global::System.Collections.Generic.IList<global::G.ToolCall>? toolCalls,
            global::G.GraphData? graphData,
            global::G.LlmData? llmData,
            global::G.TranslationData? translationData,
            global::G.WebSearchData? webSearchData,
            string? refusal)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Role = role;
            this.ToolCalls = toolCalls;
            this.GraphData = graphData;
            this.LlmData = llmData;
            this.TranslationData = translationData;
            this.WebSearchData = webSearchData;
            this.Refusal = refusal;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionResponseMessage" /> class.
        /// </summary>
        public ChatCompletionResponseMessage()
        {
        }
    }
}
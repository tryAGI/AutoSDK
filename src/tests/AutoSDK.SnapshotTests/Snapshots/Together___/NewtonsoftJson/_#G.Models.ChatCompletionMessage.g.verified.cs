//HintName: G.Models.ChatCompletionMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Content { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function_call")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.ChatCompletionMessageFunctionCall? FunctionCall { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        public global::G.ChatCompletionMessageRole Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_calls")]
        public global::System.Collections.Generic.IList<global::G.ToolChoice2>? ToolCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionMessage" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="role"></param>
        /// <param name="toolCalls"></param>
        public ChatCompletionMessage(
            string? content,
            global::G.ChatCompletionMessageRole role,
            global::System.Collections.Generic.IList<global::G.ToolChoice2>? toolCalls)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Role = role;
            this.ToolCalls = toolCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionMessage" /> class.
        /// </summary>
        public ChatCompletionMessage()
        {
        }
    }
}
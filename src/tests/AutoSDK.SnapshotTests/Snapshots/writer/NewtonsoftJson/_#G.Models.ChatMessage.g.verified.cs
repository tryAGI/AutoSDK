//HintName: G.Models.ChatMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatMessage
    {
        /// <summary>
        /// The content of the message. Can be either a string (for text-only messages) or an array of content fragments (for mixed text and image messages).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public global::G.OneOf<string, global::System.Collections.Generic.IList<global::G.CompositeContent>>? Content { get; set; }

        /// <summary>
        /// The role of the chat message. You can provide a system prompt by setting the role to `system`, or specify that a message is the result of a [tool call](https://dev.writer.com/home/tool-calling) by setting the role to `tool`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ChatMessageRequestRoleJsonConverter))]
        public global::G.ChatMessageRequestRole Role { get; set; } = default!;

        /// <summary>
        /// An optional name for the message sender. Useful for identifying different users, personas, or tools in multi-participant conversations.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_call_id")]
        public string? ToolCallId { get; set; }

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
        [global::Newtonsoft.Json.JsonProperty("refusal")]
        public string? Refusal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessage" /> class.
        /// </summary>
        /// <param name="role">
        /// The role of the chat message. You can provide a system prompt by setting the role to `system`, or specify that a message is the result of a [tool call](https://dev.writer.com/home/tool-calling) by setting the role to `tool`.
        /// </param>
        /// <param name="content">
        /// The content of the message. Can be either a string (for text-only messages) or an array of content fragments (for mixed text and image messages).
        /// </param>
        /// <param name="name">
        /// An optional name for the message sender. Useful for identifying different users, personas, or tools in multi-participant conversations.
        /// </param>
        /// <param name="toolCallId"></param>
        /// <param name="toolCalls"></param>
        /// <param name="graphData"></param>
        /// <param name="refusal"></param>
        public ChatMessage(
            global::G.ChatMessageRequestRole role,
            global::G.OneOf<string, global::System.Collections.Generic.IList<global::G.CompositeContent>>? content,
            string? name,
            string? toolCallId,
            global::System.Collections.Generic.IList<global::G.ToolCall>? toolCalls,
            global::G.GraphData? graphData,
            string? refusal)
        {
            this.Content = content;
            this.Role = role;
            this.Name = name;
            this.ToolCallId = toolCallId;
            this.ToolCalls = toolCalls;
            this.GraphData = graphData;
            this.Refusal = refusal;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessage" /> class.
        /// </summary>
        public ChatMessage()
        {
        }
    }
}
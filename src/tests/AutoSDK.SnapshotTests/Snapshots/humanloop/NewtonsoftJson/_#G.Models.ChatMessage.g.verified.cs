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
        /// Role of the message author.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ChatMessageRoleJsonConverter))]
        public global::G.ChatMessageRole Role { get; set; } = default!;

        /// <summary>
        /// The content of the message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Name of the message author.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Tool call ID for tool messages.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("toolCallId")]
        public string? ToolCallId { get; set; }

        /// <summary>
        /// Tool calls made by the assistant.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("toolCalls")]
        public global::System.Collections.Generic.IList<global::G.ToolCallResponse>? ToolCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessage" /> class.
        /// </summary>
        /// <param name="role">
        /// Role of the message author.
        /// </param>
        /// <param name="content">
        /// The content of the message.
        /// </param>
        /// <param name="name">
        /// Name of the message author.
        /// </param>
        /// <param name="toolCallId">
        /// Tool call ID for tool messages.
        /// </param>
        /// <param name="toolCalls">
        /// Tool calls made by the assistant.
        /// </param>
        public ChatMessage(
            global::G.ChatMessageRole role,
            string? content,
            string? name,
            string? toolCallId,
            global::System.Collections.Generic.IList<global::G.ToolCallResponse>? toolCalls)
        {
            this.Role = role;
            this.Content = content;
            this.Name = name;
            this.ToolCallId = toolCallId;
            this.ToolCalls = toolCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessage" /> class.
        /// </summary>
        public ChatMessage()
        {
        }
    }
}
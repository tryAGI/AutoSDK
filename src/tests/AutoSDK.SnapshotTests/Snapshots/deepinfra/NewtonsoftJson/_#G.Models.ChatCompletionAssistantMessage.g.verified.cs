﻿//HintName: G.Models.ChatCompletionAssistantMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionAssistantMessage
    {
        /// <summary>
        /// the role of the author of this message<br/>
        /// Default Value: assistant
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        public global::G.ChatCompletionAssistantMessageRole? Role { get; set; }

        /// <summary>
        /// the message content
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public string? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// the tool calls generated by the mode
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_calls")]
        public global::System.Collections.Generic.IList<global::G.ChatCompletionMessageToolCall>? ToolCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionAssistantMessage" /> class.
        /// </summary>
        /// <param name="role">
        /// the role of the author of this message<br/>
        /// Default Value: assistant
        /// </param>
        /// <param name="content">
        /// the message content
        /// </param>
        /// <param name="name"></param>
        /// <param name="toolCalls">
        /// the tool calls generated by the mode
        /// </param>
        public ChatCompletionAssistantMessage(
            global::G.ChatCompletionAssistantMessageRole? role,
            string? content,
            string? name,
            global::System.Collections.Generic.IList<global::G.ChatCompletionMessageToolCall>? toolCalls)
        {
            this.Role = role;
            this.Content = content;
            this.Name = name;
            this.ToolCalls = toolCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionAssistantMessage" /> class.
        /// </summary>
        public ChatCompletionAssistantMessage()
        {
        }
    }
}
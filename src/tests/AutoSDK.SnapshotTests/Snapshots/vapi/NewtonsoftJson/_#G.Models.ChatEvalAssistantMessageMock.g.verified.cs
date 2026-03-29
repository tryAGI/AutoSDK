//HintName: G.Models.ChatEvalAssistantMessageMock.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatEvalAssistantMessageMock
    {
        /// <summary>
        /// This is the role of the message author.<br/>
        /// For a mock assistant message, the role is always 'assistant'<br/>
        /// @default 'assistant'<br/>
        /// Default Value: assistant
        /// </summary>
        /// <default>global::G.ChatEvalAssistantMessageMockRole.Assistant</default>
        [global::Newtonsoft.Json.JsonProperty("role")]
        public global::G.ChatEvalAssistantMessageMockRole Role { get; set; } = global::G.ChatEvalAssistantMessageMockRole.Assistant;

        /// <summary>
        /// This is the content of the assistant message.<br/>
        /// This is the message that the assistant would have sent.<br/>
        /// Example: The weather in San Francisco is sunny.
        /// </summary>
        /// <example>The weather in San Francisco is sunny.</example>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public string? Content { get; set; }

        /// <summary>
        /// This is the tool calls that will be made by the assistant.<br/>
        /// Example: [{ name: "get_weather", arguments: { city: "San Francisco" } }]
        /// </summary>
        /// <example>[{ name: "get_weather", arguments: { city: "San Francisco" } }]</example>
        [global::Newtonsoft.Json.JsonProperty("toolCalls")]
        public global::System.Collections.Generic.IList<global::G.ChatEvalAssistantMessageMockToolCall>? ToolCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatEvalAssistantMessageMock" /> class.
        /// </summary>
        /// <param name="content">
        /// This is the content of the assistant message.<br/>
        /// This is the message that the assistant would have sent.<br/>
        /// Example: The weather in San Francisco is sunny.
        /// </param>
        /// <param name="toolCalls">
        /// This is the tool calls that will be made by the assistant.<br/>
        /// Example: [{ name: "get_weather", arguments: { city: "San Francisco" } }]
        /// </param>
        /// <param name="role">
        /// This is the role of the message author.<br/>
        /// For a mock assistant message, the role is always 'assistant'<br/>
        /// @default 'assistant'<br/>
        /// Default Value: assistant
        /// </param>
        public ChatEvalAssistantMessageMock(
            string? content,
            global::System.Collections.Generic.IList<global::G.ChatEvalAssistantMessageMockToolCall>? toolCalls,
            global::G.ChatEvalAssistantMessageMockRole role = global::G.ChatEvalAssistantMessageMockRole.Assistant)
        {
            this.Role = role;
            this.Content = content;
            this.ToolCalls = toolCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatEvalAssistantMessageMock" /> class.
        /// </summary>
        public ChatEvalAssistantMessageMock()
        {
        }
    }
}
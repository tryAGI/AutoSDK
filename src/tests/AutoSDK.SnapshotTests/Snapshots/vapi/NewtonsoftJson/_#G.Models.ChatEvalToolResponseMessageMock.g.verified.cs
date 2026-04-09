//HintName: G.Models.ChatEvalToolResponseMessageMock.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatEvalToolResponseMessageMock
    {
        /// <summary>
        /// This is the role of the message author.<br/>
        /// For a mock tool response message, the role is always 'tool'<br/>
        /// @default 'tool'<br/>
        /// Default Value: tool
        /// </summary>
        /// <default>global::G.ChatEvalToolResponseMessageMockRole.Tool</default>
        [global::Newtonsoft.Json.JsonProperty("role")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ChatEvalToolResponseMessageMockRoleJsonConverter))]
        public global::G.ChatEvalToolResponseMessageMockRole Role { get; set; } = global::G.ChatEvalToolResponseMessageMockRole.Tool;

        /// <summary>
        /// This is the content of the tool response message. JSON Objects should be stringified.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public string Content { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatEvalToolResponseMessageMock" /> class.
        /// </summary>
        /// <param name="content">
        /// This is the content of the tool response message. JSON Objects should be stringified.
        /// </param>
        /// <param name="role">
        /// This is the role of the message author.<br/>
        /// For a mock tool response message, the role is always 'tool'<br/>
        /// @default 'tool'<br/>
        /// Default Value: tool
        /// </param>
        public ChatEvalToolResponseMessageMock(
            string content,
            global::G.ChatEvalToolResponseMessageMockRole role = global::G.ChatEvalToolResponseMessageMockRole.Tool)
        {
            this.Role = role;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatEvalToolResponseMessageMock" /> class.
        /// </summary>
        public ChatEvalToolResponseMessageMock()
        {
        }
    }
}
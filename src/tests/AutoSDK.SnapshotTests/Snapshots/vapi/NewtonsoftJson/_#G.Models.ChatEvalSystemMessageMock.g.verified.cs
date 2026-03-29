//HintName: G.Models.ChatEvalSystemMessageMock.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatEvalSystemMessageMock
    {
        /// <summary>
        /// This is the role of the message author.<br/>
        /// For a mock system message, the role is always 'system'<br/>
        /// @default 'system'<br/>
        /// Default Value: system
        /// </summary>
        /// <default>global::G.ChatEvalSystemMessageMockRole.System</default>
        [global::Newtonsoft.Json.JsonProperty("role")]
        public global::G.ChatEvalSystemMessageMockRole Role { get; set; } = global::G.ChatEvalSystemMessageMockRole.System;

        /// <summary>
        /// This is the content of the system message that would have been added in the middle of the conversation.<br/>
        /// Do not include the assistant prompt as a part of this message. It will automatically be fetched during runtime.<br/>
        /// Example: You are a helpful assistant.
        /// </summary>
        /// <example>You are a helpful assistant.</example>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public string Content { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatEvalSystemMessageMock" /> class.
        /// </summary>
        /// <param name="content">
        /// This is the content of the system message that would have been added in the middle of the conversation.<br/>
        /// Do not include the assistant prompt as a part of this message. It will automatically be fetched during runtime.<br/>
        /// Example: You are a helpful assistant.
        /// </param>
        /// <param name="role">
        /// This is the role of the message author.<br/>
        /// For a mock system message, the role is always 'system'<br/>
        /// @default 'system'<br/>
        /// Default Value: system
        /// </param>
        public ChatEvalSystemMessageMock(
            string content,
            global::G.ChatEvalSystemMessageMockRole role = global::G.ChatEvalSystemMessageMockRole.System)
        {
            this.Role = role;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatEvalSystemMessageMock" /> class.
        /// </summary>
        public ChatEvalSystemMessageMock()
        {
        }
    }
}
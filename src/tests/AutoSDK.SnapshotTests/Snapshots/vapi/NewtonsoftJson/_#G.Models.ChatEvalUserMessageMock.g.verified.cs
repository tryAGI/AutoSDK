//HintName: G.Models.ChatEvalUserMessageMock.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatEvalUserMessageMock
    {
        /// <summary>
        /// This is the role of the message author.<br/>
        /// For a mock user message, the role is always 'user'<br/>
        /// @default 'user'<br/>
        /// Default Value: user
        /// </summary>
        /// <default>global::G.ChatEvalUserMessageMockRole.User</default>
        [global::Newtonsoft.Json.JsonProperty("role")]
        public global::G.ChatEvalUserMessageMockRole Role { get; set; } = global::G.ChatEvalUserMessageMockRole.User;

        /// <summary>
        /// This is the content of the user message.<br/>
        /// This is the message that the user would have sent.<br/>
        /// Example: Hello, how are you?
        /// </summary>
        /// <example>Hello, how are you?</example>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public string Content { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatEvalUserMessageMock" /> class.
        /// </summary>
        /// <param name="content">
        /// This is the content of the user message.<br/>
        /// This is the message that the user would have sent.<br/>
        /// Example: Hello, how are you?
        /// </param>
        /// <param name="role">
        /// This is the role of the message author.<br/>
        /// For a mock user message, the role is always 'user'<br/>
        /// @default 'user'<br/>
        /// Default Value: user
        /// </param>
        public ChatEvalUserMessageMock(
            string content,
            global::G.ChatEvalUserMessageMockRole role = global::G.ChatEvalUserMessageMockRole.User)
        {
            this.Role = role;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatEvalUserMessageMock" /> class.
        /// </summary>
        public ChatEvalUserMessageMock()
        {
        }
    }
}
//HintName: G.Models.ChatUserMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// User message
    /// </summary>
    public sealed partial class ChatUserMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        public global::G.ChatUserMessageRole Role { get; set; }

        /// <summary>
        /// User message content
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ChatUserMessageContent Content { get; set; } = default!;

        /// <summary>
        /// Optional name for the user
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatUserMessage" /> class.
        /// </summary>
        /// <param name="content">
        /// User message content
        /// </param>
        /// <param name="role"></param>
        /// <param name="name">
        /// Optional name for the user
        /// </param>
        public ChatUserMessage(
            global::G.ChatUserMessageContent content,
            global::G.ChatUserMessageRole role,
            string? name)
        {
            this.Role = role;
            this.Content = content;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatUserMessage" /> class.
        /// </summary>
        public ChatUserMessage()
        {
        }
    }
}
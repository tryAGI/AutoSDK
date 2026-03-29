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
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatUserMessageRoleJsonConverter))]
        public global::G.ChatUserMessageRole Role { get; set; }

        /// <summary>
        /// User message content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatUserMessageContentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ChatUserMessageContent Content { get; set; }

        /// <summary>
        /// Optional name for the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
//HintName: G.Models.ChatSystemMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// System message for setting behavior
    /// </summary>
    public sealed partial class ChatSystemMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatSystemMessageRoleJsonConverter))]
        public global::G.ChatSystemMessageRole Role { get; set; }

        /// <summary>
        /// System message content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatSystemMessageContentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ChatSystemMessageContent Content { get; set; }

        /// <summary>
        /// Optional name for the system message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSystemMessage" /> class.
        /// </summary>
        /// <param name="content">
        /// System message content
        /// </param>
        /// <param name="role"></param>
        /// <param name="name">
        /// Optional name for the system message
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatSystemMessage(
            global::G.ChatSystemMessageContent content,
            global::G.ChatSystemMessageRole role,
            string? name)
        {
            this.Role = role;
            this.Content = content;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSystemMessage" /> class.
        /// </summary>
        public ChatSystemMessage()
        {
        }
    }
}
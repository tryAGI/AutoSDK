//HintName: G.Models.ChatDeveloperMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Developer message
    /// </summary>
    public sealed partial class ChatDeveloperMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatDeveloperMessageRoleJsonConverter))]
        public global::G.ChatDeveloperMessageRole Role { get; set; }

        /// <summary>
        /// Developer message content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatDeveloperMessageContentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ChatDeveloperMessageContent Content { get; set; }

        /// <summary>
        /// Optional name for the developer message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatDeveloperMessage" /> class.
        /// </summary>
        /// <param name="content">
        /// Developer message content
        /// </param>
        /// <param name="role"></param>
        /// <param name="name">
        /// Optional name for the developer message
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatDeveloperMessage(
            global::G.ChatDeveloperMessageContent content,
            global::G.ChatDeveloperMessageRole role,
            string? name)
        {
            this.Role = role;
            this.Content = content;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatDeveloperMessage" /> class.
        /// </summary>
        public ChatDeveloperMessage()
        {
        }
    }
}
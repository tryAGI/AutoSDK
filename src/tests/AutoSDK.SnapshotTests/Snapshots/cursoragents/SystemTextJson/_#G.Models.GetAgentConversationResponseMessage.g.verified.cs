//HintName: G.Models.GetAgentConversationResponseMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAgentConversationResponseMessage
    {
        /// <summary>
        /// Unique identifier for the message<br/>
        /// Example: msg_123
        /// </summary>
        /// <example>msg_123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Type of message - either from the user or the model<br/>
        /// Example: user_message
        /// </summary>
        /// <example>user_message</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GetAgentConversationResponseMessageTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetAgentConversationResponseMessageType Type { get; set; }

        /// <summary>
        /// The content of the message<br/>
        /// Example: Add a README.md file with installation instructions
        /// </summary>
        /// <example>Add a README.md file with installation instructions</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentConversationResponseMessage" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the message<br/>
        /// Example: msg_123
        /// </param>
        /// <param name="type">
        /// Type of message - either from the user or the model<br/>
        /// Example: user_message
        /// </param>
        /// <param name="text">
        /// The content of the message<br/>
        /// Example: Add a README.md file with installation instructions
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAgentConversationResponseMessage(
            string id,
            global::G.GetAgentConversationResponseMessageType type,
            string text)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentConversationResponseMessage" /> class.
        /// </summary>
        public GetAgentConversationResponseMessage()
        {
        }
    }
}
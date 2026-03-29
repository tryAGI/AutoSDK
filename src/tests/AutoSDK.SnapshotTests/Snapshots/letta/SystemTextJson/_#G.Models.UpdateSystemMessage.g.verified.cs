//HintName: G.Models.UpdateSystemMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateSystemMessage
    {
        /// <summary>
        /// Default Value: system_message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_type")]
        public string? MessageType { get; set; }

        /// <summary>
        /// The message content sent by the system (can be a string or an array of multi-modal content parts)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSystemMessage" /> class.
        /// </summary>
        /// <param name="content">
        /// The message content sent by the system (can be a string or an array of multi-modal content parts)
        /// </param>
        /// <param name="messageType">
        /// Default Value: system_message
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateSystemMessage(
            string content,
            string? messageType)
        {
            this.MessageType = messageType;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSystemMessage" /> class.
        /// </summary>
        public UpdateSystemMessage()
        {
        }
    }
}
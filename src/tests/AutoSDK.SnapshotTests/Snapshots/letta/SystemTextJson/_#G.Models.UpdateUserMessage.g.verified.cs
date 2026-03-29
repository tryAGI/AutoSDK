//HintName: G.Models.UpdateUserMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateUserMessage
    {
        /// <summary>
        /// Default Value: user_message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_type")]
        public string? MessageType { get; set; }

        /// <summary>
        /// The message content sent by the user (can be a string or an array of multi-modal content parts)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.LettaUserMessageContentUnion>, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<global::System.Collections.Generic.IList<global::G.LettaUserMessageContentUnion>, string> Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateUserMessage" /> class.
        /// </summary>
        /// <param name="content">
        /// The message content sent by the user (can be a string or an array of multi-modal content parts)
        /// </param>
        /// <param name="messageType">
        /// Default Value: user_message
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateUserMessage(
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.LettaUserMessageContentUnion>, string> content,
            string? messageType)
        {
            this.MessageType = messageType;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateUserMessage" /> class.
        /// </summary>
        public UpdateUserMessage()
        {
        }
    }
}
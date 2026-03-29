//HintName: G.Models.ResponseOutputMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseOutputMessage
    {
        /// <summary>
        /// The unique ID of the output message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Content of the output message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ResponseOutputText> Content { get; set; }

        /// <summary>
        /// The role of the output message<br/>
        /// Default Value: assistant
        /// </summary>
        /// <default>global::G.ResponseOutputMessageRole.Assistant</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseOutputMessageRoleJsonConverter))]
        public global::G.ResponseOutputMessageRole Role { get; set; } = global::G.ResponseOutputMessageRole.Assistant;

        /// <summary>
        /// The status of the message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseOutputMessageStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ResponseOutputMessageStatus Status { get; set; }

        /// <summary>
        /// The type of the output message<br/>
        /// Default Value: message
        /// </summary>
        /// <default>global::G.ResponseOutputMessageType.Message</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseOutputMessageTypeJsonConverter))]
        public global::G.ResponseOutputMessageType Type { get; set; } = global::G.ResponseOutputMessageType.Message;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseOutputMessage" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of the output message
        /// </param>
        /// <param name="content">
        /// Content of the output message
        /// </param>
        /// <param name="status">
        /// The status of the message
        /// </param>
        /// <param name="role">
        /// The role of the output message<br/>
        /// Default Value: assistant
        /// </param>
        /// <param name="type">
        /// The type of the output message<br/>
        /// Default Value: message
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseOutputMessage(
            string id,
            global::System.Collections.Generic.IList<global::G.ResponseOutputText> content,
            global::G.ResponseOutputMessageStatus status,
            global::G.ResponseOutputMessageRole role = global::G.ResponseOutputMessageRole.Assistant,
            global::G.ResponseOutputMessageType type = global::G.ResponseOutputMessageType.Message)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Role = role;
            this.Status = status;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseOutputMessage" /> class.
        /// </summary>
        public ResponseOutputMessage()
        {
        }
    }
}
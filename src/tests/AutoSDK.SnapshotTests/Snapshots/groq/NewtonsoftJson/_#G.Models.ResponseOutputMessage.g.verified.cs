//HintName: G.Models.ResponseOutputMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An output message from the model.
    /// </summary>
    public sealed partial class ResponseOutputMessage
    {
        /// <summary>
        /// The type of the output message. Always `message`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ResponseOutputMessageTypeJsonConverter))]
        public global::G.ResponseOutputMessageType Type { get; set; }

        /// <summary>
        /// The unique ID of the output message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The status of the message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ResponseOutputMessageStatusJsonConverter))]
        public global::G.ResponseOutputMessageStatus? Status { get; set; }

        /// <summary>
        /// The role of the output message. Always `assistant`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ResponseOutputMessageRoleJsonConverter))]
        public global::G.ResponseOutputMessageRole Role { get; set; }

        /// <summary>
        /// The content of the output message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ResponseOutputContent> Content { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseOutputMessage" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of the output message.
        /// </param>
        /// <param name="content">
        /// The content of the output message.
        /// </param>
        /// <param name="type">
        /// The type of the output message. Always `message`.
        /// </param>
        /// <param name="status">
        /// The status of the message.
        /// </param>
        /// <param name="role">
        /// The role of the output message. Always `assistant`.
        /// </param>
        public ResponseOutputMessage(
            string id,
            global::System.Collections.Generic.IList<global::G.ResponseOutputContent> content,
            global::G.ResponseOutputMessageType type,
            global::G.ResponseOutputMessageStatus? status,
            global::G.ResponseOutputMessageRole role)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
            this.Role = role;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseOutputMessage" /> class.
        /// </summary>
        public ResponseOutputMessage()
        {
        }
    }
}
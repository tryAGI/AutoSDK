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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Content of the output message
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ResponseOutputText> Content { get; set; } = default!;

        /// <summary>
        /// The role of the output message<br/>
        /// Default Value: assistant
        /// </summary>
        /// <default>global::G.ResponseOutputMessageRole.Assistant</default>
        [global::Newtonsoft.Json.JsonProperty("role")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ResponseOutputMessageRoleJsonConverter))]
        public global::G.ResponseOutputMessageRole Role { get; set; } = global::G.ResponseOutputMessageRole.Assistant;

        /// <summary>
        /// The status of the message
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ResponseOutputMessageStatusJsonConverter))]
        public global::G.ResponseOutputMessageStatus Status { get; set; } = default!;

        /// <summary>
        /// The type of the output message<br/>
        /// Default Value: message
        /// </summary>
        /// <default>global::G.ResponseOutputMessageType.Message</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ResponseOutputMessageTypeJsonConverter))]
        public global::G.ResponseOutputMessageType Type { get; set; } = global::G.ResponseOutputMessageType.Message;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
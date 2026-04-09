//HintName: G.Models.ResponseInputMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A message input to the model with explicit type field.
    /// </summary>
    public sealed partial class ResponseInputMessage
    {
        /// <summary>
        /// The type of the message input. Always set to `message`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ResponseInputMessageTypeJsonConverter))]
        public global::G.ResponseInputMessageType Type { get; set; }

        /// <summary>
        /// The role of the message input. One of `user`, `system`, or `developer`. Note: assistant role is not supported with explicit type.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ResponseInputMessageRoleJsonConverter))]
        public global::G.ResponseInputMessageRole Role { get; set; } = default!;

        /// <summary>
        /// A list of one or many input content items.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ResponseInputContent> Content { get; set; } = default!;

        /// <summary>
        /// The status of item. Populated when items are returned via API.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ResponseInputMessageStatusJsonConverter))]
        public global::G.ResponseInputMessageStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseInputMessage" /> class.
        /// </summary>
        /// <param name="role">
        /// The role of the message input. One of `user`, `system`, or `developer`. Note: assistant role is not supported with explicit type.
        /// </param>
        /// <param name="content">
        /// A list of one or many input content items.
        /// </param>
        /// <param name="type">
        /// The type of the message input. Always set to `message`.
        /// </param>
        /// <param name="status">
        /// The status of item. Populated when items are returned via API.
        /// </param>
        public ResponseInputMessage(
            global::G.ResponseInputMessageRole role,
            global::System.Collections.Generic.IList<global::G.ResponseInputContent> content,
            global::G.ResponseInputMessageType type,
            global::G.ResponseInputMessageStatus? status)
        {
            this.Type = type;
            this.Role = role;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseInputMessage" /> class.
        /// </summary>
        public ResponseInputMessage()
        {
        }
    }
}
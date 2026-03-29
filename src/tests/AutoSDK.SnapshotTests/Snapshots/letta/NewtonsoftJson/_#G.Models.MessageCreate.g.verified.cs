//HintName: G.Models.MessageCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to create a message
    /// </summary>
    public sealed partial class MessageCreate
    {
        /// <summary>
        /// The message type to be created.<br/>
        /// Default Value: message
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The role of the participant.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MessageCreateRole Role { get; set; } = default!;

        /// <summary>
        /// The content of the message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<global::System.Collections.Generic.IList<global::G.LettaMessageContentUnion>, string> Content { get; set; } = default!;

        /// <summary>
        /// The name of the participant.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The offline threading id associated with this message
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("otid")]
        public string? Otid { get; set; }

        /// <summary>
        /// The id of the sender of the message, can be an identity id or agent id
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sender_id")]
        public string? SenderId { get; set; }

        /// <summary>
        /// The id of the LLMBatchItem that this message is associated with
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("batch_item_id")]
        public string? BatchItemId { get; set; }

        /// <summary>
        /// The multi-agent group that the message was sent in
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("group_id")]
        public string? GroupId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageCreate" /> class.
        /// </summary>
        /// <param name="role">
        /// The role of the participant.
        /// </param>
        /// <param name="content">
        /// The content of the message.
        /// </param>
        /// <param name="type">
        /// The message type to be created.<br/>
        /// Default Value: message
        /// </param>
        /// <param name="name">
        /// The name of the participant.
        /// </param>
        /// <param name="otid">
        /// The offline threading id associated with this message
        /// </param>
        /// <param name="senderId">
        /// The id of the sender of the message, can be an identity id or agent id
        /// </param>
        /// <param name="batchItemId">
        /// The id of the LLMBatchItem that this message is associated with
        /// </param>
        /// <param name="groupId">
        /// The multi-agent group that the message was sent in
        /// </param>
        public MessageCreate(
            global::G.MessageCreateRole role,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.LettaMessageContentUnion>, string> content,
            string? type,
            string? name,
            string? otid,
            string? senderId,
            string? batchItemId,
            string? groupId)
        {
            this.Type = type;
            this.Role = role;
            this.Content = content;
            this.Name = name;
            this.Otid = otid;
            this.SenderId = senderId;
            this.BatchItemId = batchItemId;
            this.GroupId = groupId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageCreate" /> class.
        /// </summary>
        public MessageCreate()
        {
        }
    }
}
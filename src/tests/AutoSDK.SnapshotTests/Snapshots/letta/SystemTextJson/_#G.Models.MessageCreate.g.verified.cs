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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The role of the participant.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MessageCreateRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MessageCreateRole Role { get; set; }

        /// <summary>
        /// The content of the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.LettaMessageContentUnion>, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<global::System.Collections.Generic.IList<global::G.LettaMessageContentUnion>, string> Content { get; set; }

        /// <summary>
        /// The name of the participant.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The offline threading id associated with this message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("otid")]
        public string? Otid { get; set; }

        /// <summary>
        /// The id of the sender of the message, can be an identity id or agent id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sender_id")]
        public string? SenderId { get; set; }

        /// <summary>
        /// The id of the LLMBatchItem that this message is associated with
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_item_id")]
        public string? BatchItemId { get; set; }

        /// <summary>
        /// The multi-agent group that the message was sent in
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_id")]
        public string? GroupId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
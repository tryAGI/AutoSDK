//HintName: G.Models.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScheduledMessagesRetrieveScheduledMessageResponseMessageMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::System.Collections.Generic.IList<global::G.OneOf<global::G.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant1, global::G.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant2>>, string> Content { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageRoleJsonConverter))]
        public global::G.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageRole Role { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("otid")]
        public string? Otid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sender_id")]
        public string? SenderId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageTypeJsonConverter))]
        public global::G.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledMessagesRetrieveScheduledMessageResponseMessageMessage" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="role"></param>
        /// <param name="name"></param>
        /// <param name="otid"></param>
        /// <param name="senderId"></param>
        /// <param name="type"></param>
        public ScheduledMessagesRetrieveScheduledMessageResponseMessageMessage(
            global::G.OneOf<global::System.Collections.Generic.IList<global::G.OneOf<global::G.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant1, global::G.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant2>>, string> content,
            global::G.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageRole role,
            string? name,
            string? otid,
            string? senderId,
            global::G.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageType? type)
        {
            this.Content = content;
            this.Role = role;
            this.Name = name;
            this.Otid = otid;
            this.SenderId = senderId;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledMessagesRetrieveScheduledMessageResponseMessageMessage" /> class.
        /// </summary>
        public ScheduledMessagesRetrieveScheduledMessageResponseMessageMessage()
        {
        }
    }
}
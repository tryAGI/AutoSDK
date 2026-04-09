//HintName: G.Models.ScheduledMessagesScheduleAgentMessageRequestMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScheduledMessagesScheduleAgentMessageRequestMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::System.Collections.Generic.IList<global::G.OneOf<global::G.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant1, global::G.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2>>, string> Content { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ScheduledMessagesScheduleAgentMessageRequestMessageRoleJsonConverter))]
        public global::G.ScheduledMessagesScheduleAgentMessageRequestMessageRole Role { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ScheduledMessagesScheduleAgentMessageRequestMessageTypeJsonConverter))]
        public global::G.ScheduledMessagesScheduleAgentMessageRequestMessageType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledMessagesScheduleAgentMessageRequestMessage" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="role"></param>
        /// <param name="name"></param>
        /// <param name="otid"></param>
        /// <param name="senderId"></param>
        /// <param name="type"></param>
        public ScheduledMessagesScheduleAgentMessageRequestMessage(
            global::G.OneOf<global::System.Collections.Generic.IList<global::G.OneOf<global::G.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant1, global::G.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2>>, string> content,
            global::G.ScheduledMessagesScheduleAgentMessageRequestMessageRole role,
            string? name,
            string? otid,
            string? senderId,
            global::G.ScheduledMessagesScheduleAgentMessageRequestMessageType? type)
        {
            this.Content = content;
            this.Role = role;
            this.Name = name;
            this.Otid = otid;
            this.SenderId = senderId;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledMessagesScheduleAgentMessageRequestMessage" /> class.
        /// </summary>
        public ScheduledMessagesScheduleAgentMessageRequestMessage()
        {
        }
    }
}
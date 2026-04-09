//HintName: G.Models.TriggerEventDataVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TriggerEventDataVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chat_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ChatId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TriggerEventDataVariant2EventTypeJsonConverter))]
        public global::G.TriggerEventDataVariant2EventType EventType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerEventDataVariant2" /> class.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="chatId"></param>
        /// <param name="eventType"></param>
        public TriggerEventDataVariant2(
            string agentId,
            string chatId,
            global::G.TriggerEventDataVariant2EventType eventType)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.ChatId = chatId ?? throw new global::System.ArgumentNullException(nameof(chatId));
            this.EventType = eventType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerEventDataVariant2" /> class.
        /// </summary>
        public TriggerEventDataVariant2()
        {
        }
    }
}
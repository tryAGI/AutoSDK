//HintName: G.Models.ChatEndEventData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatEndEventData
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
        public global::G.ChatEndEventDataEventType EventType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chat_history")]
        public global::G.ILogicalChat? ChatHistory { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatEndEventData" /> class.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="chatId"></param>
        /// <param name="eventType"></param>
        /// <param name="chatHistory"></param>
        public ChatEndEventData(
            string agentId,
            string chatId,
            global::G.ChatEndEventDataEventType eventType,
            global::G.ILogicalChat? chatHistory)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.ChatId = chatId ?? throw new global::System.ArgumentNullException(nameof(chatId));
            this.EventType = eventType;
            this.ChatHistory = chatHistory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatEndEventData" /> class.
        /// </summary>
        public ChatEndEventData()
        {
        }
    }
}
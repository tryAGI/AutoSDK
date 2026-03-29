//HintName: G.Models.ScheduledMessagesListScheduledMessagesResponseScheduledMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScheduledMessagesListScheduledMessagesResponseScheduledMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessage Message { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("schedule", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant1, global::G.ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant2> Schedule { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_scheduled_time")]
        public string? NextScheduledTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledMessagesListScheduledMessagesResponseScheduledMessage" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="agentId"></param>
        /// <param name="message"></param>
        /// <param name="schedule"></param>
        /// <param name="nextScheduledTime"></param>
        public ScheduledMessagesListScheduledMessagesResponseScheduledMessage(
            string id,
            string agentId,
            global::G.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessage message,
            global::G.OneOf<global::G.ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant1, global::G.ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant2> schedule,
            string? nextScheduledTime)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Schedule = schedule;
            this.NextScheduledTime = nextScheduledTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledMessagesListScheduledMessagesResponseScheduledMessage" /> class.
        /// </summary>
        public ScheduledMessagesListScheduledMessagesResponseScheduledMessage()
        {
        }
    }
}
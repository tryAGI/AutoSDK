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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessage Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schedule")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant1, global::G.ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<global::G.ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant1, global::G.ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant2> Schedule { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_scheduled_time")]
        public string? NextScheduledTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledMessagesListScheduledMessagesResponseScheduledMessage" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="agentId"></param>
        /// <param name="message"></param>
        /// <param name="schedule"></param>
        /// <param name="nextScheduledTime"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
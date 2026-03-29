//HintName: G.Models.ScheduledMessagesScheduleAgentMessageRequestScheduleVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScheduledMessagesScheduleAgentMessageRequestScheduleVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ScheduledMessagesScheduleAgentMessageRequestScheduleVariant1TypeJsonConverter))]
        public global::G.ScheduledMessagesScheduleAgentMessageRequestScheduleVariant1Type? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheduled_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ScheduledAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledMessagesScheduleAgentMessageRequestScheduleVariant1" /> class.
        /// </summary>
        /// <param name="scheduledAt"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScheduledMessagesScheduleAgentMessageRequestScheduleVariant1(
            double scheduledAt,
            global::G.ScheduledMessagesScheduleAgentMessageRequestScheduleVariant1Type? type)
        {
            this.Type = type;
            this.ScheduledAt = scheduledAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledMessagesScheduleAgentMessageRequestScheduleVariant1" /> class.
        /// </summary>
        public ScheduledMessagesScheduleAgentMessageRequestScheduleVariant1()
        {
        }
    }
}
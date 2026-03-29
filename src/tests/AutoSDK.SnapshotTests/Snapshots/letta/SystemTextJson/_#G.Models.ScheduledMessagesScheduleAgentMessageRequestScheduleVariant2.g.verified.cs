//HintName: G.Models.ScheduledMessagesScheduleAgentMessageRequestScheduleVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScheduledMessagesScheduleAgentMessageRequestScheduleVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ScheduledMessagesScheduleAgentMessageRequestScheduleVariant2TypeJsonConverter))]
        public global::G.ScheduledMessagesScheduleAgentMessageRequestScheduleVariant2Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cron_expression")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CronExpression { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledMessagesScheduleAgentMessageRequestScheduleVariant2" /> class.
        /// </summary>
        /// <param name="cronExpression"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScheduledMessagesScheduleAgentMessageRequestScheduleVariant2(
            string cronExpression,
            global::G.ScheduledMessagesScheduleAgentMessageRequestScheduleVariant2Type type)
        {
            this.Type = type;
            this.CronExpression = cronExpression ?? throw new global::System.ArgumentNullException(nameof(cronExpression));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledMessagesScheduleAgentMessageRequestScheduleVariant2" /> class.
        /// </summary>
        public ScheduledMessagesScheduleAgentMessageRequestScheduleVariant2()
        {
        }
    }
}
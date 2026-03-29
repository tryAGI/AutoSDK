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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ScheduledMessagesScheduleAgentMessageRequestScheduleVariant2Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cron_expression", Required = global::Newtonsoft.Json.Required.Always)]
        public string CronExpression { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledMessagesScheduleAgentMessageRequestScheduleVariant2" /> class.
        /// </summary>
        /// <param name="cronExpression"></param>
        /// <param name="type"></param>
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
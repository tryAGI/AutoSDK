//HintName: G.Models.ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant2TypeJsonConverter))]
        public global::G.ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant2Type Type { get; set; }

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
        /// Initializes a new instance of the <see cref="ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant2" /> class.
        /// </summary>
        /// <param name="cronExpression"></param>
        /// <param name="type"></param>
        public ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant2(
            string cronExpression,
            global::G.ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant2Type type)
        {
            this.Type = type;
            this.CronExpression = cronExpression ?? throw new global::System.ArgumentNullException(nameof(cronExpression));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant2" /> class.
        /// </summary>
        public ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant2()
        {
        }
    }
}
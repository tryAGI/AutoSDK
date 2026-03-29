//HintName: G.Models.ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant1Type? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scheduled_at", Required = global::Newtonsoft.Json.Required.Always)]
        public double ScheduledAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant1" /> class.
        /// </summary>
        /// <param name="scheduledAt"></param>
        /// <param name="type"></param>
        public ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant1(
            double scheduledAt,
            global::G.ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant1Type? type)
        {
            this.Type = type;
            this.ScheduledAt = scheduledAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant1" /> class.
        /// </summary>
        public ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant1()
        {
        }
    }
}
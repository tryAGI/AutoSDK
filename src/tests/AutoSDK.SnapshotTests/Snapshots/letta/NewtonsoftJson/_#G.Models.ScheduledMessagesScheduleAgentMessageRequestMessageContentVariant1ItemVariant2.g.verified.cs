//HintName: G.Models.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2Source Source { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2TypeJsonConverter))]
        public global::G.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2" /> class.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="type"></param>
        public ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2(
            global::G.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2Source source,
            global::G.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2Type type)
        {
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2" /> class.
        /// </summary>
        public ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2()
        {
        }
    }
}
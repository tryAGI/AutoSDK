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
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2Source Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2TypeJsonConverter))]
        public global::G.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2" /> class.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
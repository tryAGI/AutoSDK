//HintName: G.Models.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant2Source Source { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant2TypeJsonConverter))]
        public global::G.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant2Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant2" /> class.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="type"></param>
        public ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant2(
            global::G.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant2Source source,
            global::G.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant2Type type)
        {
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant2" /> class.
        /// </summary>
        public ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant2()
        {
        }
    }
}
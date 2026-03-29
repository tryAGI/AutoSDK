//HintName: G.Models.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signature")]
        public string? Signature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant1TypeJsonConverter))]
        public global::G.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant1Type? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant1" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="signature"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant1(
            string text,
            string? signature,
            global::G.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant1Type? type)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Signature = signature;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant1" /> class.
        /// </summary>
        public ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant1()
        {
        }
    }
}
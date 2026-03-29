//HintName: G.Models.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2Source.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2Source
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MediaType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        public string? Detail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2SourceTypeJsonConverter))]
        public global::G.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2SourceType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2Source" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="mediaType"></param>
        /// <param name="detail"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2Source(
            string data,
            string mediaType,
            string? detail,
            global::G.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2SourceType? type)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.MediaType = mediaType ?? throw new global::System.ArgumentNullException(nameof(mediaType));
            this.Detail = detail;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2Source" /> class.
        /// </summary>
        public ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2Source()
        {
        }
    }
}
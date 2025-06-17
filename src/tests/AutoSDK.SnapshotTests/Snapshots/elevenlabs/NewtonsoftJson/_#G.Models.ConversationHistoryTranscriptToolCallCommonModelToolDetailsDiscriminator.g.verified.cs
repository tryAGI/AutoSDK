//HintName: G.Models.ConversationHistoryTranscriptToolCallCommonModelToolDetailsDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationHistoryTranscriptToolCallCommonModelToolDetailsDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ConversationHistoryTranscriptToolCallCommonModelToolDetailsDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryTranscriptToolCallCommonModelToolDetailsDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public ConversationHistoryTranscriptToolCallCommonModelToolDetailsDiscriminator(
            global::G.ConversationHistoryTranscriptToolCallCommonModelToolDetailsDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryTranscriptToolCallCommonModelToolDetailsDiscriminator" /> class.
        /// </summary>
        public ConversationHistoryTranscriptToolCallCommonModelToolDetailsDiscriminator()
        {
        }
    }
}
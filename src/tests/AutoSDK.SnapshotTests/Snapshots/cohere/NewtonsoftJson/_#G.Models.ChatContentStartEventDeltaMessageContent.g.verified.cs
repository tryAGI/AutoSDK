//HintName: G.Models.ChatContentStartEventDeltaMessageContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatContentStartEventDeltaMessageContent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ChatContentStartEventDeltaMessageContentTypeJsonConverter))]
        public global::G.ChatContentStartEventDeltaMessageContentType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContentStartEventDeltaMessageContent" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="type"></param>
        public ChatContentStartEventDeltaMessageContent(
            string? text,
            global::G.ChatContentStartEventDeltaMessageContentType? type)
        {
            this.Text = text;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContentStartEventDeltaMessageContent" /> class.
        /// </summary>
        public ChatContentStartEventDeltaMessageContent()
        {
        }
    }
}
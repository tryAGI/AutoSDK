//HintName: G.Models.ChatContentStartEventVariant2DeltaMessageContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatContentStartEventVariant2DeltaMessageContent
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
        public global::G.ChatContentStartEventVariant2DeltaMessageContentType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContentStartEventVariant2DeltaMessageContent" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="type"></param>
        public ChatContentStartEventVariant2DeltaMessageContent(
            string? text,
            global::G.ChatContentStartEventVariant2DeltaMessageContentType? type)
        {
            this.Text = text;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContentStartEventVariant2DeltaMessageContent" /> class.
        /// </summary>
        public ChatContentStartEventVariant2DeltaMessageContent()
        {
        }
    }
}
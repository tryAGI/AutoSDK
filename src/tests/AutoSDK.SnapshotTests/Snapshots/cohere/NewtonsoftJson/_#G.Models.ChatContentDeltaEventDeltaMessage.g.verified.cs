//HintName: G.Models.ChatContentDeltaEventDeltaMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatContentDeltaEventDeltaMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public global::G.ChatContentDeltaEventDeltaMessageContent? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContentDeltaEventDeltaMessage" /> class.
        /// </summary>
        /// <param name="content"></param>
        public ChatContentDeltaEventDeltaMessage(
            global::G.ChatContentDeltaEventDeltaMessageContent? content)
        {
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContentDeltaEventDeltaMessage" /> class.
        /// </summary>
        public ChatContentDeltaEventDeltaMessage()
        {
        }
    }
}
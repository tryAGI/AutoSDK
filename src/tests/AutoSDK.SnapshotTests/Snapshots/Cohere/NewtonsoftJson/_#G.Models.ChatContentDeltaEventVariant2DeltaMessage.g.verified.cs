//HintName: G.Models.ChatContentDeltaEventVariant2DeltaMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatContentDeltaEventVariant2DeltaMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public global::G.ChatContentDeltaEventVariant2DeltaMessageContent? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContentDeltaEventVariant2DeltaMessage" /> class.
        /// </summary>
        /// <param name="content"></param>
        public ChatContentDeltaEventVariant2DeltaMessage(
            global::G.ChatContentDeltaEventVariant2DeltaMessageContent? content)
        {
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContentDeltaEventVariant2DeltaMessage" /> class.
        /// </summary>
        public ChatContentDeltaEventVariant2DeltaMessage()
        {
        }
    }
}
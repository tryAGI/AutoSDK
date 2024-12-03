//HintName: G.Models.ChatMessageEndEventVariant2Delta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatMessageEndEventVariant2Delta
    {
        /// <summary>
        /// The reason a chat request has finished.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finish_reason")]
        public global::G.ChatFinishReason? FinishReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage")]
        public global::G.Usage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessageEndEventVariant2Delta" /> class.
        /// </summary>
        /// <param name="finishReason">
        /// The reason a chat request has finished.
        /// </param>
        /// <param name="usage"></param>
        public ChatMessageEndEventVariant2Delta(
            global::G.ChatFinishReason? finishReason,
            global::G.Usage? usage)
        {
            this.FinishReason = finishReason;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessageEndEventVariant2Delta" /> class.
        /// </summary>
        public ChatMessageEndEventVariant2Delta()
        {
        }
    }
}
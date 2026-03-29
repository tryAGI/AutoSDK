//HintName: G.Models.ChatSDKRequestUiChatBotFeedbackFeedbackPanelTag.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatSDKRequestUiChatBotFeedbackFeedbackPanelTag
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("isNeedDetail")]
        public bool? IsNeedDetail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSDKRequestUiChatBotFeedbackFeedbackPanelTag" /> class.
        /// </summary>
        /// <param name="isNeedDetail"></param>
        /// <param name="label"></param>
        public ChatSDKRequestUiChatBotFeedbackFeedbackPanelTag(
            bool? isNeedDetail,
            string? label)
        {
            this.IsNeedDetail = isNeedDetail;
            this.Label = label;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSDKRequestUiChatBotFeedbackFeedbackPanelTag" /> class.
        /// </summary>
        public ChatSDKRequestUiChatBotFeedbackFeedbackPanelTag()
        {
        }
    }
}
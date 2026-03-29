//HintName: G.Models.ChatSDKRequestUiChatBotFeedback.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatSDKRequestUiChatBotFeedback
    {
        /// <summary>
        /// 点踩自定义框显示
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feedbackPanel", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ChatSDKRequestUiChatBotFeedbackFeedbackPanel FeedbackPanel { get; set; } = default!;

        /// <summary>
        /// 是否显示 点赞、点踩按钮
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("isNeedFeedback")]
        public bool? IsNeedFeedback { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSDKRequestUiChatBotFeedback" /> class.
        /// </summary>
        /// <param name="feedbackPanel">
        /// 点踩自定义框显示
        /// </param>
        /// <param name="isNeedFeedback">
        /// 是否显示 点赞、点踩按钮
        /// </param>
        public ChatSDKRequestUiChatBotFeedback(
            global::G.ChatSDKRequestUiChatBotFeedbackFeedbackPanel feedbackPanel,
            bool? isNeedFeedback)
        {
            this.FeedbackPanel = feedbackPanel ?? throw new global::System.ArgumentNullException(nameof(feedbackPanel));
            this.IsNeedFeedback = isNeedFeedback;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSDKRequestUiChatBotFeedback" /> class.
        /// </summary>
        public ChatSDKRequestUiChatBotFeedback()
        {
        }
    }
}
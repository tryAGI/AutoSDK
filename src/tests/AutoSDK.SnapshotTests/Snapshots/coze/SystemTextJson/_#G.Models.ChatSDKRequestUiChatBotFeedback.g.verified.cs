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
        [global::System.Text.Json.Serialization.JsonPropertyName("feedbackPanel")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ChatSDKRequestUiChatBotFeedbackFeedbackPanel FeedbackPanel { get; set; }

        /// <summary>
        /// 是否显示 点赞、点踩按钮
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isNeedFeedback")]
        public bool? IsNeedFeedback { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
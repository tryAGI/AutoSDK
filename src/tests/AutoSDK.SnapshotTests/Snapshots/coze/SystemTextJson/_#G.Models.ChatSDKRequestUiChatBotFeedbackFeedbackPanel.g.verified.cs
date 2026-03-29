//HintName: G.Models.ChatSDKRequestUiChatBotFeedbackFeedbackPanel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 点踩自定义框显示
    /// </summary>
    public sealed partial class ChatSDKRequestUiChatBotFeedbackFeedbackPanel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("placeholder")]
        public string? Placeholder { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<global::G.ChatSDKRequestUiChatBotFeedbackFeedbackPanelTag>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSDKRequestUiChatBotFeedbackFeedbackPanel" /> class.
        /// </summary>
        /// <param name="placeholder"></param>
        /// <param name="tags"></param>
        /// <param name="title"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatSDKRequestUiChatBotFeedbackFeedbackPanel(
            string? placeholder,
            global::System.Collections.Generic.IList<global::G.ChatSDKRequestUiChatBotFeedbackFeedbackPanelTag>? tags,
            string? title)
        {
            this.Placeholder = placeholder;
            this.Tags = tags;
            this.Title = title;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSDKRequestUiChatBotFeedbackFeedbackPanel" /> class.
        /// </summary>
        public ChatSDKRequestUiChatBotFeedbackFeedbackPanel()
        {
        }
    }
}
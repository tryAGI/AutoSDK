//HintName: G.Models.ChatSDKRequestUiChatBot.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatSDKRequestUiChatBot
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("el")]
        public string? El { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback")]
        public global::G.ChatSDKRequestUiChatBotFeedback? Feedback { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isNeedAddNewConversation")]
        public bool? IsNeedAddNewConversation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isNeedAudio")]
        public bool? IsNeedAudio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isNeedFunctionCallMessage")]
        public bool? IsNeedFunctionCallMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isNeedQuote")]
        public bool? IsNeedQuote { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploadable")]
        public bool? Uploadable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public double? Width { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSDKRequestUiChatBot" /> class.
        /// </summary>
        /// <param name="el"></param>
        /// <param name="feedback"></param>
        /// <param name="isNeedAddNewConversation"></param>
        /// <param name="isNeedAudio"></param>
        /// <param name="isNeedFunctionCallMessage"></param>
        /// <param name="isNeedQuote"></param>
        /// <param name="title"></param>
        /// <param name="uploadable"></param>
        /// <param name="width"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatSDKRequestUiChatBot(
            string? el,
            global::G.ChatSDKRequestUiChatBotFeedback? feedback,
            bool? isNeedAddNewConversation,
            bool? isNeedAudio,
            bool? isNeedFunctionCallMessage,
            bool? isNeedQuote,
            string? title,
            bool? uploadable,
            double? width)
        {
            this.El = el;
            this.Feedback = feedback;
            this.IsNeedAddNewConversation = isNeedAddNewConversation;
            this.IsNeedAudio = isNeedAudio;
            this.IsNeedFunctionCallMessage = isNeedFunctionCallMessage;
            this.IsNeedQuote = isNeedQuote;
            this.Title = title;
            this.Uploadable = uploadable;
            this.Width = width;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSDKRequestUiChatBot" /> class.
        /// </summary>
        public ChatSDKRequestUiChatBot()
        {
        }
    }
}
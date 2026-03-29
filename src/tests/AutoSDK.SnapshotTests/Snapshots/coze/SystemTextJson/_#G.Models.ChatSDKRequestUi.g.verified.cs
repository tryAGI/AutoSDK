//HintName: G.Models.ChatSDKRequestUi.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatSDKRequestUi
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asstBtn")]
        public global::G.ChatSDKRequestUiAsstBtn? AsstBtn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base")]
        public global::G.ChatSDKRequestUiBase? Base { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chatBot")]
        public global::G.ChatSDKRequestUiChatBot? ChatBot { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversations")]
        public global::G.ChatSDKRequestUiConversations? Conversations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("footer")]
        public global::G.ChatSDKRequestUiFooter? Footer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("header")]
        public global::G.ChatSDKRequestUiHeader? Header { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSDKRequestUi" /> class.
        /// </summary>
        /// <param name="asstBtn"></param>
        /// <param name="base"></param>
        /// <param name="chatBot"></param>
        /// <param name="conversations"></param>
        /// <param name="footer"></param>
        /// <param name="header"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatSDKRequestUi(
            global::G.ChatSDKRequestUiAsstBtn? asstBtn,
            global::G.ChatSDKRequestUiBase? @base,
            global::G.ChatSDKRequestUiChatBot? chatBot,
            global::G.ChatSDKRequestUiConversations? conversations,
            global::G.ChatSDKRequestUiFooter? footer,
            global::G.ChatSDKRequestUiHeader? header)
        {
            this.AsstBtn = asstBtn;
            this.Base = @base;
            this.ChatBot = chatBot;
            this.Conversations = conversations;
            this.Footer = footer;
            this.Header = header;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSDKRequestUi" /> class.
        /// </summary>
        public ChatSDKRequestUi()
        {
        }
    }
}
//HintName: G.Models.ChatSDKRequestUiConversations.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatSDKRequestUiConversations
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("isNeed")]
        public bool? IsNeed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSDKRequestUiConversations" /> class.
        /// </summary>
        /// <param name="isNeed"></param>
        public ChatSDKRequestUiConversations(
            bool? isNeed)
        {
            this.IsNeed = isNeed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSDKRequestUiConversations" /> class.
        /// </summary>
        public ChatSDKRequestUiConversations()
        {
        }
    }
}
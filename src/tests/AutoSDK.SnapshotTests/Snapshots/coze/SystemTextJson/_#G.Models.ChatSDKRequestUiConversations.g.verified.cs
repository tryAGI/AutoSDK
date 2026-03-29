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
        [global::System.Text.Json.Serialization.JsonPropertyName("isNeed")]
        public bool? IsNeed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSDKRequestUiConversations" /> class.
        /// </summary>
        /// <param name="isNeed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
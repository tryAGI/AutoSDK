//HintName: G.Models.ChatSDKRequestUiAsstBtn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatSDKRequestUiAsstBtn
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
        /// Initializes a new instance of the <see cref="ChatSDKRequestUiAsstBtn" /> class.
        /// </summary>
        /// <param name="isNeed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatSDKRequestUiAsstBtn(
            bool? isNeed)
        {
            this.IsNeed = isNeed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSDKRequestUiAsstBtn" /> class.
        /// </summary>
        public ChatSDKRequestUiAsstBtn()
        {
        }
    }
}
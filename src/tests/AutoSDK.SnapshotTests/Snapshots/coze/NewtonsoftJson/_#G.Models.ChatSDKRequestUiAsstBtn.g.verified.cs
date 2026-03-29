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
        [global::Newtonsoft.Json.JsonProperty("isNeed")]
        public bool? IsNeed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSDKRequestUiAsstBtn" /> class.
        /// </summary>
        /// <param name="isNeed"></param>
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
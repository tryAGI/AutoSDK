//HintName: G.Models.ChatSDKRequestUiHeader.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatSDKRequestUiHeader
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("isNeedClose")]
        public bool? IsNeedClose { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("isShow")]
        public bool? IsShow { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSDKRequestUiHeader" /> class.
        /// </summary>
        /// <param name="isNeedClose"></param>
        /// <param name="isShow"></param>
        public ChatSDKRequestUiHeader(
            bool? isNeedClose,
            bool? isShow)
        {
            this.IsNeedClose = isNeedClose;
            this.IsShow = isShow;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSDKRequestUiHeader" /> class.
        /// </summary>
        public ChatSDKRequestUiHeader()
        {
        }
    }
}
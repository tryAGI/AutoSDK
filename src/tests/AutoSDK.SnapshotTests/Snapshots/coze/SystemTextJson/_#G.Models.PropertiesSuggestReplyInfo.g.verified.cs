//HintName: G.Models.PropertiesSuggestReplyInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PropertiesSuggestReplyInfo
    {
        /// <summary>
        /// custom 模式下的自定义 prompt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customized_prompt")]
        public string? CustomizedPrompt { get; set; }

        /// <summary>
        /// 回复模式
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reply_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PropertiesSuggestReplyInfoReplyModeJsonConverter))]
        public global::G.PropertiesSuggestReplyInfoReplyMode? ReplyMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesSuggestReplyInfo" /> class.
        /// </summary>
        /// <param name="customizedPrompt">
        /// custom 模式下的自定义 prompt
        /// </param>
        /// <param name="replyMode">
        /// 回复模式
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PropertiesSuggestReplyInfo(
            string? customizedPrompt,
            global::G.PropertiesSuggestReplyInfoReplyMode? replyMode)
        {
            this.CustomizedPrompt = customizedPrompt;
            this.ReplyMode = replyMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesSuggestReplyInfo" /> class.
        /// </summary>
        public PropertiesSuggestReplyInfo()
        {
        }
    }
}
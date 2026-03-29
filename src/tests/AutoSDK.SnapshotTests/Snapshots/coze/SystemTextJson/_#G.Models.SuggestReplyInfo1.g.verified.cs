//HintName: G.Models.SuggestReplyInfo1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SuggestReplyInfo1
    {
        /// <summary>
        /// 用户自定义建议问题
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customized_suggest_prompt")]
        public string? CustomizedSuggestPrompt { get; set; }

        /// <summary>
        /// 对应 Coze Auto-Suggestion建议问题模型
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suggest_reply_mode")]
        public int? SuggestReplyMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SuggestReplyInfo1" /> class.
        /// </summary>
        /// <param name="customizedSuggestPrompt">
        /// 用户自定义建议问题
        /// </param>
        /// <param name="suggestReplyMode">
        /// 对应 Coze Auto-Suggestion建议问题模型
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SuggestReplyInfo1(
            string? customizedSuggestPrompt,
            int? suggestReplyMode)
        {
            this.CustomizedSuggestPrompt = customizedSuggestPrompt;
            this.SuggestReplyMode = suggestReplyMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SuggestReplyInfo1" /> class.
        /// </summary>
        public SuggestReplyInfo1()
        {
        }
    }
}
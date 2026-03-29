//HintName: G.Models.PropertiesPromptInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PropertiesPromptInfo
    {
        /// <summary>
        /// 前缀提示词模式下的prompt内容
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix_prompt_info")]
        public global::G.PropertiesPromptInfoPropertiesPrefixPromptInfo? PrefixPromptInfo { get; set; }

        /// <summary>
        /// 文本prompt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// 提示词模式
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PropertiesPromptInfoPromptModeJsonConverter))]
        public global::G.PropertiesPromptInfoPromptMode? PromptMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesPromptInfo" /> class.
        /// </summary>
        /// <param name="prefixPromptInfo">
        /// 前缀提示词模式下的prompt内容
        /// </param>
        /// <param name="prompt">
        /// 文本prompt
        /// </param>
        /// <param name="promptMode">
        /// 提示词模式
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PropertiesPromptInfo(
            global::G.PropertiesPromptInfoPropertiesPrefixPromptInfo? prefixPromptInfo,
            string? prompt,
            global::G.PropertiesPromptInfoPromptMode? promptMode)
        {
            this.PrefixPromptInfo = prefixPromptInfo;
            this.Prompt = prompt;
            this.PromptMode = promptMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesPromptInfo" /> class.
        /// </summary>
        public PropertiesPromptInfo()
        {
        }
    }
}
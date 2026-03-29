//HintName: G.Models.PropertiesPromptInfoPropertiesPrefixPromptInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 前缀提示词模式下的prompt内容
    /// </summary>
    public sealed partial class PropertiesPromptInfoPropertiesPrefixPromptInfo
    {
        /// <summary>
        /// 不支持前缀提示词部分
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dynamic_prompt")]
        public string? DynamicPrompt { get; set; }

        /// <summary>
        /// 前缀提示词
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prefix_prompt")]
        public string? PrefixPrompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesPromptInfoPropertiesPrefixPromptInfo" /> class.
        /// </summary>
        /// <param name="dynamicPrompt">
        /// 不支持前缀提示词部分
        /// </param>
        /// <param name="prefixPrompt">
        /// 前缀提示词
        /// </param>
        public PropertiesPromptInfoPropertiesPrefixPromptInfo(
            string? dynamicPrompt,
            string? prefixPrompt)
        {
            this.DynamicPrompt = dynamicPrompt;
            this.PrefixPrompt = prefixPrompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesPromptInfoPropertiesPrefixPromptInfo" /> class.
        /// </summary>
        public PropertiesPromptInfoPropertiesPrefixPromptInfo()
        {
        }
    }
}
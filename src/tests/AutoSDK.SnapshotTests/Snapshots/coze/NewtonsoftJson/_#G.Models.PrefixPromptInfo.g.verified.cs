//HintName: G.Models.PrefixPromptInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PrefixPromptInfo
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
        /// Initializes a new instance of the <see cref="PrefixPromptInfo" /> class.
        /// </summary>
        /// <param name="dynamicPrompt">
        /// 不支持前缀提示词部分
        /// </param>
        /// <param name="prefixPrompt">
        /// 前缀提示词
        /// </param>
        public PrefixPromptInfo(
            string? dynamicPrompt,
            string? prefixPrompt)
        {
            this.DynamicPrompt = dynamicPrompt;
            this.PrefixPrompt = prefixPrompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrefixPromptInfo" /> class.
        /// </summary>
        public PrefixPromptInfo()
        {
        }
    }
}
//HintName: G.Models.PromptAnthropicThinkingConfigDisabled.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptAnthropicThinkingConfigDisabled
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"disabled"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "disabled";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAnthropicThinkingConfigDisabled" /> class.
        /// </summary>
        /// <param name="type"></param>
        public PromptAnthropicThinkingConfigDisabled(
            string type = "disabled")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAnthropicThinkingConfigDisabled" /> class.
        /// </summary>
        public PromptAnthropicThinkingConfigDisabled()
        {
        }
    }
}
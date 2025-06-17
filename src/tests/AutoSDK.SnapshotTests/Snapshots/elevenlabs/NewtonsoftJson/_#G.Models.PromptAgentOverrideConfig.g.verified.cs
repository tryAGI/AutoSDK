//HintName: G.Models.PromptAgentOverrideConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptAgentOverrideConfig
    {
        /// <summary>
        /// Whether to allow overriding the prompt field.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt")]
        public bool? Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAgentOverrideConfig" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Whether to allow overriding the prompt field.<br/>
        /// Default Value: false
        /// </param>
        public PromptAgentOverrideConfig(
            bool? prompt)
        {
            this.Prompt = prompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAgentOverrideConfig" /> class.
        /// </summary>
        public PromptAgentOverrideConfig()
        {
        }
    }
}
//HintName: G.Models.AgentConfigOverrideConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentConfigOverrideConfig
    {
        /// <summary>
        /// Whether to allow overriding the first_message field.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("first_message")]
        public bool? FirstMessage { get; set; }

        /// <summary>
        /// Whether to allow overriding the language field.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language")]
        public bool? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt")]
        public global::G.PromptAgentOverrideConfig? Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConfigOverrideConfig" /> class.
        /// </summary>
        /// <param name="firstMessage">
        /// Whether to allow overriding the first_message field.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="language">
        /// Whether to allow overriding the language field.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="prompt"></param>
        public AgentConfigOverrideConfig(
            bool? firstMessage,
            bool? language,
            global::G.PromptAgentOverrideConfig? prompt)
        {
            this.FirstMessage = firstMessage;
            this.Language = language;
            this.Prompt = prompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConfigOverrideConfig" /> class.
        /// </summary>
        public AgentConfigOverrideConfig()
        {
        }
    }
}
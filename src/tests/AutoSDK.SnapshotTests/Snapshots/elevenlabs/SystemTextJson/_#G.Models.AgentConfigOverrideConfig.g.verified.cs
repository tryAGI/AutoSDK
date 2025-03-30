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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public global::G.PromptAgentOverrideConfig? Prompt { get; set; }

        /// <summary>
        /// Whether to allow overriding the first message<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_message")]
        public bool? FirstMessage { get; set; }

        /// <summary>
        /// Whether to allow overriding the language<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public bool? Language { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConfigOverrideConfig" /> class.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="firstMessage">
        /// Whether to allow overriding the first message<br/>
        /// Default Value: false
        /// </param>
        /// <param name="language">
        /// Whether to allow overriding the language<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentConfigOverrideConfig(
            global::G.PromptAgentOverrideConfig? prompt,
            bool? firstMessage,
            bool? language)
        {
            this.Prompt = prompt;
            this.FirstMessage = firstMessage;
            this.Language = language;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConfigOverrideConfig" /> class.
        /// </summary>
        public AgentConfigOverrideConfig()
        {
        }
    }
}
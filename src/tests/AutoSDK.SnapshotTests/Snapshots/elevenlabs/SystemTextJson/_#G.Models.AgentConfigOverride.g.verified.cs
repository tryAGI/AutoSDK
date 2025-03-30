//HintName: G.Models.AgentConfigOverride.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentConfigOverride
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public global::G.PromptAgentOverride? Prompt { get; set; }

        /// <summary>
        /// If non-empty, the first message the agent will say. If empty, the agent waits for the user to start the discussion
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_message")]
        public string? FirstMessage { get; set; }

        /// <summary>
        /// The language of the agent, used for ASR and TTS
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConfigOverride" /> class.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="firstMessage">
        /// If non-empty, the first message the agent will say. If empty, the agent waits for the user to start the discussion
        /// </param>
        /// <param name="language">
        /// The language of the agent, used for ASR and TTS
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentConfigOverride(
            global::G.PromptAgentOverride? prompt,
            string? firstMessage,
            string? language)
        {
            this.Prompt = prompt;
            this.FirstMessage = firstMessage;
            this.Language = language;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConfigOverride" /> class.
        /// </summary>
        public AgentConfigOverride()
        {
        }
    }
}
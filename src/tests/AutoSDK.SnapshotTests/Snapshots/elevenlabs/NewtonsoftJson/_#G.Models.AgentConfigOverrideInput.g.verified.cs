//HintName: G.Models.AgentConfigOverrideInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"first_message":"Hello, how can I help you today?","language":"en","prompt":{"llm":"gemini-2.0-flash-001","prompt":"You are a helpful assistant that can answer questions about the topic of the conversation."}}
    /// </summary>
    public sealed partial class AgentConfigOverrideInput
    {
        /// <summary>
        /// If non-empty, the first message the agent will say. If empty, the agent waits for the user to start the discussion.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("first_message")]
        public string? FirstMessage { get; set; }

        /// <summary>
        /// Language of the agent - used for ASR and TTS
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language")]
        public string? Language { get; set; }

        /// <summary>
        /// The prompt for the agent
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt")]
        public global::G.PromptAgentAPIModelOverride? Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConfigOverrideInput" /> class.
        /// </summary>
        /// <param name="firstMessage">
        /// If non-empty, the first message the agent will say. If empty, the agent waits for the user to start the discussion.
        /// </param>
        /// <param name="language">
        /// Language of the agent - used for ASR and TTS
        /// </param>
        /// <param name="prompt">
        /// The prompt for the agent
        /// </param>
        public AgentConfigOverrideInput(
            string? firstMessage,
            string? language,
            global::G.PromptAgentAPIModelOverride? prompt)
        {
            this.FirstMessage = firstMessage;
            this.Language = language;
            this.Prompt = prompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConfigOverrideInput" /> class.
        /// </summary>
        public AgentConfigOverrideInput()
        {
        }
    }
}
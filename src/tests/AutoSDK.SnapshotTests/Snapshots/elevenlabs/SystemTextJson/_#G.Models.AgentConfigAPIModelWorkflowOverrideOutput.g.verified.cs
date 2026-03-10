//HintName: G.Models.AgentConfigAPIModelWorkflowOverrideOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"disable_first_message_interruptions":false,"dynamic_variables":{"dynamic_variable_placeholders":{"user_name":"John Doe"}},"first_message":"Hello, how can I help you today?","language":"en","prompt":{"knowledge_base":[],"llm":"gemini-2.0-flash-001","max_tokens":-1,"prompt":"You are a helpful assistant that can answer questions about the topic of the conversation.","temperature":0.0,"tool_ids":[],"tools":[]}}
    /// </summary>
    public sealed partial class AgentConfigAPIModelWorkflowOverrideOutput
    {
        /// <summary>
        /// If non-empty, the first message the agent will say. If empty, the agent waits for the user to start the discussion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_message")]
        public string? FirstMessage { get; set; }

        /// <summary>
        /// Language of the agent - used for ASR and TTS
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// When enabled and language is Hindi, the agent will respond in Hinglish
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hinglish_mode")]
        public bool? HinglishMode { get; set; }

        /// <summary>
        /// Configuration for dynamic variables
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_variables")]
        public global::G.DynamicVariablesConfigWorkflowOverride? DynamicVariables { get; set; }

        /// <summary>
        /// If true, the user will not be able to interrupt the agent while the first message is being delivered.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_first_message_interruptions")]
        public bool? DisableFirstMessageInterruptions { get; set; }

        /// <summary>
        /// The prompt for the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public global::G.PromptAgentAPIModelWorkflowOverrideOutput? Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConfigAPIModelWorkflowOverrideOutput" /> class.
        /// </summary>
        /// <param name="firstMessage">
        /// If non-empty, the first message the agent will say. If empty, the agent waits for the user to start the discussion.
        /// </param>
        /// <param name="language">
        /// Language of the agent - used for ASR and TTS
        /// </param>
        /// <param name="hinglishMode">
        /// When enabled and language is Hindi, the agent will respond in Hinglish
        /// </param>
        /// <param name="dynamicVariables">
        /// Configuration for dynamic variables
        /// </param>
        /// <param name="disableFirstMessageInterruptions">
        /// If true, the user will not be able to interrupt the agent while the first message is being delivered.
        /// </param>
        /// <param name="prompt">
        /// The prompt for the agent
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentConfigAPIModelWorkflowOverrideOutput(
            string? firstMessage,
            string? language,
            bool? hinglishMode,
            global::G.DynamicVariablesConfigWorkflowOverride? dynamicVariables,
            bool? disableFirstMessageInterruptions,
            global::G.PromptAgentAPIModelWorkflowOverrideOutput? prompt)
        {
            this.FirstMessage = firstMessage;
            this.Language = language;
            this.HinglishMode = hinglishMode;
            this.DynamicVariables = dynamicVariables;
            this.DisableFirstMessageInterruptions = disableFirstMessageInterruptions;
            this.Prompt = prompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConfigAPIModelWorkflowOverrideOutput" /> class.
        /// </summary>
        public AgentConfigAPIModelWorkflowOverrideOutput()
        {
        }
    }
}
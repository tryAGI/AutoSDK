//HintName: G.Models.AgentConfigAPIModelInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"disable_first_message_interruptions":false,"first_message":"Hello, how can I help you today?","language":"en"}
    /// </summary>
    public sealed partial class AgentConfigAPIModelInput
    {
        /// <summary>
        /// If non-empty, the first message the agent will say. If empty, the agent waits for the user to start the discussion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_message")]
        public string? FirstMessage { get; set; }

        /// <summary>
        /// Language of the agent - used for ASR and TTS<br/>
        /// Default Value: en
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// When enabled and language is Hindi, the agent will respond in Hinglish<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hinglish_mode")]
        public bool? HinglishMode { get; set; }

        /// <summary>
        /// Configuration for dynamic variables<br/>
        /// Example: {"dynamic_variable_placeholders":{"user_name":"John Doe"}}
        /// </summary>
        /// <example>{"dynamic_variable_placeholders":{"user_name":"John Doe"}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_variables")]
        public global::G.DynamicVariablesConfig? DynamicVariables { get; set; }

        /// <summary>
        /// If true, the user will not be able to interrupt the agent while the first message is being delivered.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_first_message_interruptions")]
        public bool? DisableFirstMessageInterruptions { get; set; }

        /// <summary>
        /// The prompt for the agent<br/>
        /// Example: {"knowledge_base":[],"llm":"gemini-2.0-flash-001","max_tokens":-1,"prompt":"You are a helpful assistant that can answer questions about the topic of the conversation.","temperature":0.0,"tool_ids":[],"tools":[]}
        /// </summary>
        /// <example>{"knowledge_base":[],"llm":"gemini-2.0-flash-001","max_tokens":-1,"prompt":"You are a helpful assistant that can answer questions about the topic of the conversation.","temperature":0.0,"tool_ids":[],"tools":[]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public global::G.PromptAgentAPIModelInput? Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConfigAPIModelInput" /> class.
        /// </summary>
        /// <param name="firstMessage">
        /// If non-empty, the first message the agent will say. If empty, the agent waits for the user to start the discussion.
        /// </param>
        /// <param name="language">
        /// Language of the agent - used for ASR and TTS<br/>
        /// Default Value: en
        /// </param>
        /// <param name="hinglishMode">
        /// When enabled and language is Hindi, the agent will respond in Hinglish<br/>
        /// Default Value: false
        /// </param>
        /// <param name="dynamicVariables">
        /// Configuration for dynamic variables<br/>
        /// Example: {"dynamic_variable_placeholders":{"user_name":"John Doe"}}
        /// </param>
        /// <param name="disableFirstMessageInterruptions">
        /// If true, the user will not be able to interrupt the agent while the first message is being delivered.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="prompt">
        /// The prompt for the agent<br/>
        /// Example: {"knowledge_base":[],"llm":"gemini-2.0-flash-001","max_tokens":-1,"prompt":"You are a helpful assistant that can answer questions about the topic of the conversation.","temperature":0.0,"tool_ids":[],"tools":[]}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentConfigAPIModelInput(
            string? firstMessage,
            string? language,
            bool? hinglishMode,
            global::G.DynamicVariablesConfig? dynamicVariables,
            bool? disableFirstMessageInterruptions,
            global::G.PromptAgentAPIModelInput? prompt)
        {
            this.FirstMessage = firstMessage;
            this.Language = language;
            this.HinglishMode = hinglishMode;
            this.DynamicVariables = dynamicVariables;
            this.DisableFirstMessageInterruptions = disableFirstMessageInterruptions;
            this.Prompt = prompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConfigAPIModelInput" /> class.
        /// </summary>
        public AgentConfigAPIModelInput()
        {
        }
    }
}
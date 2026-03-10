//HintName: G.Models.PromptAgentAPIModelWorkflowOverrideInput.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"knowledge_base":[],"llm":"gemini-2.0-flash-001","max_tokens":-1,"prompt":"You are a helpful assistant that can answer questions about the topic of the conversation.","temperature":0.0,"tool_ids":[],"tools":[]}
    /// </summary>
    public sealed partial class PromptAgentAPIModelWorkflowOverrideInput
    {
        /// <summary>
        /// The prompt for the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// The LLM to query with the prompt and the chat history. If using data residency, the LLM must be supported in the data residency environment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm")]
        public global::G.Llm? Llm { get; set; }

        /// <summary>
        /// Reasoning effort of the model. Only available for some models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_effort")]
        public global::G.LLMReasoningEffort? ReasoningEffort { get; set; }

        /// <summary>
        /// Max number of tokens used for thinking. Use 0 to turn off if supported by the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thinking_budget")]
        public int? ThinkingBudget { get; set; }

        /// <summary>
        /// The temperature for the LLM
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// If greater than 0, maximum number of tokens the LLM can predict
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// A list of IDs of tools used by the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_ids")]
        public global::System.Collections.Generic.IList<string>? ToolIds { get; set; }

        /// <summary>
        /// Built-in system tools to be used by the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("built_in_tools")]
        public global::G.BuiltInToolsWorkflowOverrideInput? BuiltInTools { get; set; }

        /// <summary>
        /// A list of MCP server ids to be used by the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_server_ids")]
        public global::System.Collections.Generic.IList<string>? McpServerIds { get; set; }

        /// <summary>
        /// A list of Native MCP server ids to be used by the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("native_mcp_server_ids")]
        public global::System.Collections.Generic.IList<string>? NativeMcpServerIds { get; set; }

        /// <summary>
        /// A list of knowledge bases to be used by the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledge_base")]
        public global::System.Collections.Generic.IList<global::G.KnowledgeBaseLocator>? KnowledgeBase { get; set; }

        /// <summary>
        /// Definition for a custom LLM if LLM field is set to 'CUSTOM_LLM'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_llm")]
        public global::G.CustomLLM? CustomLlm { get; set; }

        /// <summary>
        /// Whether to remove the default personality lines from the system prompt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignore_default_personality")]
        public bool? IgnoreDefaultPersonality { get; set; }

        /// <summary>
        /// Configuration for RAG
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rag")]
        public global::G.RagConfigWorkflowOverride? Rag { get; set; }

        /// <summary>
        /// Timezone for displaying current time in system prompt. If set, the current time will be included in the system prompt using this timezone. Must be a valid timezone name (e.g., 'America/New_York', 'Europe/London', 'UTC').
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// Configuration for backup LLM cascading. Can be disabled, use system defaults, or specify custom order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backup_llm_config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.BackupLLMDefault, global::G.BackupLLMDisabled, global::G.BackupLLMOverride, object>))]
        public global::G.AnyOf<global::G.BackupLLMDefault, global::G.BackupLLMDisabled, global::G.BackupLLMOverride, object>? BackupLlmConfig { get; set; }

        /// <summary>
        /// Time in seconds before cascading to backup LLM. Must be between 2 and 15 seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cascade_timeout_seconds")]
        public double? CascadeTimeoutSeconds { get; set; }

        /// <summary>
        /// A list of tools that the agent can use over the course of the conversation, use tool_ids instead
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::G.ToolsVariant1Item>? Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAgentAPIModelWorkflowOverrideInput" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt for the agent
        /// </param>
        /// <param name="llm">
        /// The LLM to query with the prompt and the chat history. If using data residency, the LLM must be supported in the data residency environment
        /// </param>
        /// <param name="reasoningEffort">
        /// Reasoning effort of the model. Only available for some models.
        /// </param>
        /// <param name="thinkingBudget">
        /// Max number of tokens used for thinking. Use 0 to turn off if supported by the model.
        /// </param>
        /// <param name="temperature">
        /// The temperature for the LLM
        /// </param>
        /// <param name="maxTokens">
        /// If greater than 0, maximum number of tokens the LLM can predict
        /// </param>
        /// <param name="toolIds">
        /// A list of IDs of tools used by the agent
        /// </param>
        /// <param name="builtInTools">
        /// Built-in system tools to be used by the agent
        /// </param>
        /// <param name="mcpServerIds">
        /// A list of MCP server ids to be used by the agent
        /// </param>
        /// <param name="nativeMcpServerIds">
        /// A list of Native MCP server ids to be used by the agent
        /// </param>
        /// <param name="knowledgeBase">
        /// A list of knowledge bases to be used by the agent
        /// </param>
        /// <param name="customLlm">
        /// Definition for a custom LLM if LLM field is set to 'CUSTOM_LLM'
        /// </param>
        /// <param name="ignoreDefaultPersonality">
        /// Whether to remove the default personality lines from the system prompt
        /// </param>
        /// <param name="rag">
        /// Configuration for RAG
        /// </param>
        /// <param name="timezone">
        /// Timezone for displaying current time in system prompt. If set, the current time will be included in the system prompt using this timezone. Must be a valid timezone name (e.g., 'America/New_York', 'Europe/London', 'UTC').
        /// </param>
        /// <param name="backupLlmConfig">
        /// Configuration for backup LLM cascading. Can be disabled, use system defaults, or specify custom order.
        /// </param>
        /// <param name="cascadeTimeoutSeconds">
        /// Time in seconds before cascading to backup LLM. Must be between 2 and 15 seconds.
        /// </param>
        /// <param name="tools">
        /// A list of tools that the agent can use over the course of the conversation, use tool_ids instead
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptAgentAPIModelWorkflowOverrideInput(
            string? prompt,
            global::G.Llm? llm,
            global::G.LLMReasoningEffort? reasoningEffort,
            int? thinkingBudget,
            double? temperature,
            int? maxTokens,
            global::System.Collections.Generic.IList<string>? toolIds,
            global::G.BuiltInToolsWorkflowOverrideInput? builtInTools,
            global::System.Collections.Generic.IList<string>? mcpServerIds,
            global::System.Collections.Generic.IList<string>? nativeMcpServerIds,
            global::System.Collections.Generic.IList<global::G.KnowledgeBaseLocator>? knowledgeBase,
            global::G.CustomLLM? customLlm,
            bool? ignoreDefaultPersonality,
            global::G.RagConfigWorkflowOverride? rag,
            string? timezone,
            global::G.AnyOf<global::G.BackupLLMDefault, global::G.BackupLLMDisabled, global::G.BackupLLMOverride, object>? backupLlmConfig,
            double? cascadeTimeoutSeconds,
            global::System.Collections.Generic.IList<global::G.ToolsVariant1Item>? tools)
        {
            this.Prompt = prompt;
            this.Llm = llm;
            this.ReasoningEffort = reasoningEffort;
            this.ThinkingBudget = thinkingBudget;
            this.Temperature = temperature;
            this.MaxTokens = maxTokens;
            this.ToolIds = toolIds;
            this.BuiltInTools = builtInTools;
            this.McpServerIds = mcpServerIds;
            this.NativeMcpServerIds = nativeMcpServerIds;
            this.KnowledgeBase = knowledgeBase;
            this.CustomLlm = customLlm;
            this.IgnoreDefaultPersonality = ignoreDefaultPersonality;
            this.Rag = rag;
            this.Timezone = timezone;
            this.BackupLlmConfig = backupLlmConfig;
            this.CascadeTimeoutSeconds = cascadeTimeoutSeconds;
            this.Tools = tools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAgentAPIModelWorkflowOverrideInput" /> class.
        /// </summary>
        public PromptAgentAPIModelWorkflowOverrideInput()
        {
        }
    }
}
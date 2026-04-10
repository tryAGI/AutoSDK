//HintName: G.Models.ReasoningStep.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A single step in the Research model's chain-of-thought reasoning.
    /// </summary>
    public sealed partial class ReasoningStep
    {
        /// <summary>
        /// "assistant" for agent reasoning, "tool" for tool execution results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ReasoningStepRoleJsonConverter))]
        public global::G.ReasoningStepRole? Role { get; set; }

        /// <summary>
        /// Natural language explanation of the agent's intent before acting.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reasoning_content")]
        public string? ReasoningContent { get; set; }

        /// <summary>
        /// Tool execution result or final content. Can be a string or a structured object (e.g., tool output).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public global::G.OneOf<string, object>? Content { get; set; }

        /// <summary>
        /// Internal tools invoked during this step.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_calls")]
        public global::System.Collections.Generic.IList<global::G.ReasoningToolCall>? ToolCalls { get; set; }

        /// <summary>
        /// Links a tool result step to its originating tool call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_call_id")]
        public string? ToolCallId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningStep" /> class.
        /// </summary>
        /// <param name="role">
        /// "assistant" for agent reasoning, "tool" for tool execution results.
        /// </param>
        /// <param name="reasoningContent">
        /// Natural language explanation of the agent's intent before acting.
        /// </param>
        /// <param name="content">
        /// Tool execution result or final content. Can be a string or a structured object (e.g., tool output).
        /// </param>
        /// <param name="toolCalls">
        /// Internal tools invoked during this step.
        /// </param>
        /// <param name="toolCallId">
        /// Links a tool result step to its originating tool call.
        /// </param>
        public ReasoningStep(
            global::G.ReasoningStepRole? role,
            string? reasoningContent,
            global::G.OneOf<string, object>? content,
            global::System.Collections.Generic.IList<global::G.ReasoningToolCall>? toolCalls,
            string? toolCallId)
        {
            this.Role = role;
            this.ReasoningContent = reasoningContent;
            this.Content = content;
            this.ToolCalls = toolCalls;
            this.ToolCallId = toolCallId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningStep" /> class.
        /// </summary>
        public ReasoningStep()
        {
        }
    }
}
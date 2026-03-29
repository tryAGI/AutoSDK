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
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ReasoningStepRoleJsonConverter))]
        public global::G.ReasoningStepRole? Role { get; set; }

        /// <summary>
        /// Natural language explanation of the agent's intent before acting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_content")]
        public string? ReasoningContent { get; set; }

        /// <summary>
        /// Tool execution result or final content. Can be a string or a structured object (e.g., tool output).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<string, object>))]
        public global::G.OneOf<string, object>? Content { get; set; }

        /// <summary>
        /// Internal tools invoked during this step.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls")]
        public global::System.Collections.Generic.IList<global::G.ReasoningToolCall>? ToolCalls { get; set; }

        /// <summary>
        /// Links a tool result step to its originating tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_id")]
        public string? ToolCallId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
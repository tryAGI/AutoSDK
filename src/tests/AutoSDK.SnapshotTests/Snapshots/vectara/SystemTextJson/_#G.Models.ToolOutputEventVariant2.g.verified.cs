//HintName: G.Models.ToolOutputEventVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolOutputEventVariant2
    {
        /// <summary>
        /// The type of event.<br/>
        /// Default Value: tool_output
        /// </summary>
        /// <default>"tool_output"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "tool_output";

        /// <summary>
        /// The unique identifier for the tool call, matching the input event.<br/>
        /// Example: call_tool_search_001
        /// </summary>
        /// <example>call_tool_search_001</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolCallId { get; set; }

        /// <summary>
        /// The name of the tool configuration that was invoked, as defined in the agent's tool_configurations map.<br/>
        /// Example: customer_search
        /// </summary>
        /// <example>customer_search</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_configuration_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolConfigurationName { get; set; }

        /// <summary>
        /// Name of the tool that was called.<br/>
        /// Example: web_search
        /// </summary>
        /// <example>web_search</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolName { get; set; }

        /// <summary>
        /// Output data from the tool.<br/>
        /// Example: {"result":"Current weather is 70\u00B0F and sunny"}
        /// </summary>
        /// <example>{"result":"Current weather is 70\u00B0F and sunny"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object ToolOutput { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolOutputEventVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of event.<br/>
        /// Default Value: tool_output
        /// </param>
        /// <param name="toolCallId">
        /// The unique identifier for the tool call, matching the input event.<br/>
        /// Example: call_tool_search_001
        /// </param>
        /// <param name="toolConfigurationName">
        /// The name of the tool configuration that was invoked, as defined in the agent's tool_configurations map.<br/>
        /// Example: customer_search
        /// </param>
        /// <param name="toolName">
        /// Name of the tool that was called.<br/>
        /// Example: web_search
        /// </param>
        /// <param name="toolOutput">
        /// Output data from the tool.<br/>
        /// Example: {"result":"Current weather is 70\u00B0F and sunny"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolOutputEventVariant2(
            string type,
            string toolCallId,
            string toolConfigurationName,
            string toolName,
            object toolOutput)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
            this.ToolConfigurationName = toolConfigurationName ?? throw new global::System.ArgumentNullException(nameof(toolConfigurationName));
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.ToolOutput = toolOutput ?? throw new global::System.ArgumentNullException(nameof(toolOutput));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolOutputEventVariant2" /> class.
        /// </summary>
        public ToolOutputEventVariant2()
        {
        }
    }
}
//HintName: G.Models.ToolInputEventVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolInputEventVariant2
    {
        /// <summary>
        /// The type of event.<br/>
        /// Default Value: tool_input
        /// </summary>
        /// <default>"tool_input"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "tool_input";

        /// <summary>
        /// The identifier for the tool call.<br/>
        /// Example: call_tool_search_001
        /// </summary>
        /// <example>call_tool_search_001</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolCallId { get; set; }

        /// <summary>
        /// The name of the tool configuration being invoked, as defined in the agent's tool_configurations map.<br/>
        /// Example: customer_search
        /// </summary>
        /// <example>customer_search</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_configuration_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolConfigurationName { get; set; }

        /// <summary>
        /// Name of the tool being called.<br/>
        /// Example: web_search
        /// </summary>
        /// <example>web_search</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolName { get; set; }

        /// <summary>
        /// Input data for the tool.<br/>
        /// Example: {"query":"weather in San Francisco"}
        /// </summary>
        /// <example>{"query":"weather in San Francisco"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object ToolInput { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolInputEventVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of event.<br/>
        /// Default Value: tool_input
        /// </param>
        /// <param name="toolCallId">
        /// The identifier for the tool call.<br/>
        /// Example: call_tool_search_001
        /// </param>
        /// <param name="toolConfigurationName">
        /// The name of the tool configuration being invoked, as defined in the agent's tool_configurations map.<br/>
        /// Example: customer_search
        /// </param>
        /// <param name="toolName">
        /// Name of the tool being called.<br/>
        /// Example: web_search
        /// </param>
        /// <param name="toolInput">
        /// Input data for the tool.<br/>
        /// Example: {"query":"weather in San Francisco"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolInputEventVariant2(
            string type,
            string toolCallId,
            string toolConfigurationName,
            string toolName,
            object toolInput)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
            this.ToolConfigurationName = toolConfigurationName ?? throw new global::System.ArgumentNullException(nameof(toolConfigurationName));
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.ToolInput = toolInput ?? throw new global::System.ArgumentNullException(nameof(toolInput));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolInputEventVariant2" /> class.
        /// </summary>
        public ToolInputEventVariant2()
        {
        }
    }
}
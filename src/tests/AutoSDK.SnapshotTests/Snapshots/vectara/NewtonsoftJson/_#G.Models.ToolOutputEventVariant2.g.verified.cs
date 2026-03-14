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
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// The unique identifier for the tool call, matching the input event.<br/>
        /// Example: call_tool_search_001
        /// </summary>
        /// <example>call_tool_search_001</example>
        [global::Newtonsoft.Json.JsonProperty("tool_call_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolCallId { get; set; } = default!;

        /// <summary>
        /// The name of the tool configuration that was invoked, as defined in the agent's tool_configurations map.<br/>
        /// Example: customer_search
        /// </summary>
        /// <example>customer_search</example>
        [global::Newtonsoft.Json.JsonProperty("tool_configuration_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolConfigurationName { get; set; } = default!;

        /// <summary>
        /// Name of the tool that was called.<br/>
        /// Example: web_search
        /// </summary>
        /// <example>web_search</example>
        [global::Newtonsoft.Json.JsonProperty("tool_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolName { get; set; } = default!;

        /// <summary>
        /// Output data from the tool.<br/>
        /// Example: {"result":"Current weather is 70\u00B0F and sunny"}
        /// </summary>
        /// <example>{"result":"Current weather is 70\u00B0F and sunny"}</example>
        [global::Newtonsoft.Json.JsonProperty("tool_output", Required = global::Newtonsoft.Json.Required.Always)]
        public object ToolOutput { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
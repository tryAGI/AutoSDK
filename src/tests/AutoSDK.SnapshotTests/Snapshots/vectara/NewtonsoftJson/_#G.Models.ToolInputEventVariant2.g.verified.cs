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
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// The identifier for the tool call.<br/>
        /// Example: call_tool_search_001
        /// </summary>
        /// <example>call_tool_search_001</example>
        [global::Newtonsoft.Json.JsonProperty("tool_call_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolCallId { get; set; } = default!;

        /// <summary>
        /// The name of the tool configuration being invoked, as defined in the agent's tool_configurations map.<br/>
        /// Example: customer_search
        /// </summary>
        /// <example>customer_search</example>
        [global::Newtonsoft.Json.JsonProperty("tool_configuration_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolConfigurationName { get; set; } = default!;

        /// <summary>
        /// Name of the tool being called.<br/>
        /// Example: web_search
        /// </summary>
        /// <example>web_search</example>
        [global::Newtonsoft.Json.JsonProperty("tool_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolName { get; set; } = default!;

        /// <summary>
        /// Input data for the tool.<br/>
        /// Example: {"query":"weather in San Francisco"}
        /// </summary>
        /// <example>{"query":"weather in San Francisco"}</example>
        [global::Newtonsoft.Json.JsonProperty("tool_input", Required = global::Newtonsoft.Json.Required.Always)]
        public object ToolInput { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
//HintName: G.Models.InlineDynamicVectaraToolConfiguration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An inline configuration for built-in Vectara tools that have implementations within the platform but do not have a dedicated configuration type schema. Use the List Tools endpoint to discover available tools and obtain the `tool_id` required for this configuration.
    /// </summary>
    public sealed partial class InlineDynamicVectaraToolConfiguration
    {
        /// <summary>
        /// The type of tool configuration, which is always 'dynamic_vectara' for generic Vectara tool configurations.<br/>
        /// Default Value: dynamic_vectara
        /// </summary>
        /// <default>"dynamic_vectara"</default>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Unique identifier for a tool.<br/>
        /// Example: tol_123e4567-e89b-12d3-a456-426614174000
        /// </summary>
        /// <example>tol_123e4567-e89b-12d3-a456-426614174000</example>
        [global::Newtonsoft.Json.JsonProperty("tool_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolId { get; set; } = default!;

        /// <summary>
        /// Velocity template for generating dynamic tool descriptions. When set, this template is rendered at runtime to produce the tool description.<br/>
        /// Available Velocity variables:<br/>
        /// - `$agent.name` - Agent name<br/>
        /// - `$agent.metadata` - Agent metadata map<br/>
        /// - `$session.key` - Session key<br/>
        /// - `$session.metadata` - Session metadata map<br/>
        /// - `$currentDate` - Current date/time in ISO 8601 format (e.g., "2025-10-24T15:30:45Z")<br/>
        /// Example: "Search tool configured for agent $agent.name on $currentDate"
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description_template")]
        public string? DescriptionTemplate { get; set; }

        /// <summary>
        /// Optional hardcoded arguments for tool calls. The key specifies the location in the tool arguments to overide, and the value specifies what to override with. The LLM will not be able to change the parameters, nor know those values exist within the tool.<br/>
        /// The values can also be dynamic references to context values using $ref with dot notation path syntax:<br/>
        /// - Static value: "fixed_value" or 123<br/>
        /// - Dynamic reference: `{"$ref": "session.metadata.field_name"}`<br/>
        /// References are resolved at runtime from context:<br/>
        /// - session.metadata.* - Access session metadata fields<br/>
        /// - agent.metadata.* - Access agent metadata fields<br/>
        /// Example:<br/>
        ///   `{"query": {"$ref": ".session.metadata.query"}}`<br/>
        /// If you want to have a real value `"$ref"` use `"$$ref"`, that is you can escape the first $ by using $$.<br/>
        /// Example: {"custom_param":"value","limit":10}
        /// </summary>
        /// <example>{"custom_param":"value","limit":10}</example>
        [global::Newtonsoft.Json.JsonProperty("argument_override")]
        public object? ArgumentOverride { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InlineDynamicVectaraToolConfiguration" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of tool configuration, which is always 'dynamic_vectara' for generic Vectara tool configurations.<br/>
        /// Default Value: dynamic_vectara
        /// </param>
        /// <param name="toolId">
        /// Unique identifier for a tool.<br/>
        /// Example: tol_123e4567-e89b-12d3-a456-426614174000
        /// </param>
        /// <param name="descriptionTemplate">
        /// Velocity template for generating dynamic tool descriptions. When set, this template is rendered at runtime to produce the tool description.<br/>
        /// Available Velocity variables:<br/>
        /// - `$agent.name` - Agent name<br/>
        /// - `$agent.metadata` - Agent metadata map<br/>
        /// - `$session.key` - Session key<br/>
        /// - `$session.metadata` - Session metadata map<br/>
        /// - `$currentDate` - Current date/time in ISO 8601 format (e.g., "2025-10-24T15:30:45Z")<br/>
        /// Example: "Search tool configured for agent $agent.name on $currentDate"
        /// </param>
        /// <param name="argumentOverride">
        /// Optional hardcoded arguments for tool calls. The key specifies the location in the tool arguments to overide, and the value specifies what to override with. The LLM will not be able to change the parameters, nor know those values exist within the tool.<br/>
        /// The values can also be dynamic references to context values using $ref with dot notation path syntax:<br/>
        /// - Static value: "fixed_value" or 123<br/>
        /// - Dynamic reference: `{"$ref": "session.metadata.field_name"}`<br/>
        /// References are resolved at runtime from context:<br/>
        /// - session.metadata.* - Access session metadata fields<br/>
        /// - agent.metadata.* - Access agent metadata fields<br/>
        /// Example:<br/>
        ///   `{"query": {"$ref": ".session.metadata.query"}}`<br/>
        /// If you want to have a real value `"$ref"` use `"$$ref"`, that is you can escape the first $ by using $$.<br/>
        /// Example: {"custom_param":"value","limit":10}
        /// </param>
        public InlineDynamicVectaraToolConfiguration(
            string type,
            string toolId,
            string? descriptionTemplate,
            object? argumentOverride)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.ToolId = toolId ?? throw new global::System.ArgumentNullException(nameof(toolId));
            this.DescriptionTemplate = descriptionTemplate;
            this.ArgumentOverride = argumentOverride;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InlineDynamicVectaraToolConfiguration" /> class.
        /// </summary>
        public InlineDynamicVectaraToolConfiguration()
        {
        }
    }
}
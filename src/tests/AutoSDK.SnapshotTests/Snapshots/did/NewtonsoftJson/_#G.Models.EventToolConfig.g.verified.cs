//HintName: G.Models.EventToolConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Tool configuration for event-specific usage
    /// </summary>
    public sealed partial class EventToolConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EventToolConfig" /> class.
        /// </summary>
        /// <param name="toolId"></param>
        public EventToolConfig(
            string toolId)
        {
            this.ToolId = toolId ?? throw new global::System.ArgumentNullException(nameof(toolId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventToolConfig" /> class.
        /// </summary>
        public EventToolConfig()
        {
        }
    }
}
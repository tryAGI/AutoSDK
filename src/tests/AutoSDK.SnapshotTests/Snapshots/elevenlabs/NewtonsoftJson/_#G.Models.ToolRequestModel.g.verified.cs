//HintName: G.Models.ToolRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolRequestModel
    {
        /// <summary>
        /// Configuration for the tool
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ToolConfig ToolConfig { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolRequestModel" /> class.
        /// </summary>
        /// <param name="toolConfig">
        /// Configuration for the tool
        /// </param>
        public ToolRequestModel(
            global::G.ToolConfig toolConfig)
        {
            this.ToolConfig = toolConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolRequestModel" /> class.
        /// </summary>
        public ToolRequestModel()
        {
        }
    }
}
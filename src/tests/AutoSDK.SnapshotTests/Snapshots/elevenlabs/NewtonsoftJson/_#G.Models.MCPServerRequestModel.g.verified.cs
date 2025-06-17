//HintName: G.Models.MCPServerRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request model for creating/updating an MCP Server configuration.
    /// </summary>
    public sealed partial class MCPServerRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MCPServerConfigInput Config { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPServerRequestModel" /> class.
        /// </summary>
        /// <param name="config"></param>
        public MCPServerRequestModel(
            global::G.MCPServerConfigInput config)
        {
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPServerRequestModel" /> class.
        /// </summary>
        public MCPServerRequestModel()
        {
        }
    }
}
//HintName: G.Models.MCPServersResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response model for a list of MCP Server configurations.
    /// </summary>
    public sealed partial class MCPServersResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mcp_servers", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.MCPServerResponseModel> McpServers { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPServersResponseModel" /> class.
        /// </summary>
        /// <param name="mcpServers"></param>
        public MCPServersResponseModel(
            global::System.Collections.Generic.IList<global::G.MCPServerResponseModel> mcpServers)
        {
            this.McpServers = mcpServers ?? throw new global::System.ArgumentNullException(nameof(mcpServers));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPServersResponseModel" /> class.
        /// </summary>
        public MCPServersResponseModel()
        {
        }
    }
}
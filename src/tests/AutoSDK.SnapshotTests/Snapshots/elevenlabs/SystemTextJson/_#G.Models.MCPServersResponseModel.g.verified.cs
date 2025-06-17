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
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_servers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.MCPServerResponseModel> McpServers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPServersResponseModel" /> class.
        /// </summary>
        /// <param name="mcpServers"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
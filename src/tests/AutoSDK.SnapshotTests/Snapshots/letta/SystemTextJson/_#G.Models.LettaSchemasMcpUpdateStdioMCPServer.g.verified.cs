//HintName: G.Models.LettaSchemasMcpUpdateStdioMCPServer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Update a Stdio MCP server
    /// </summary>
    public sealed partial class LettaSchemasMcpUpdateStdioMCPServer
    {
        /// <summary>
        /// The name of the MCP server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_name")]
        public string? ServerName { get; set; }

        /// <summary>
        /// The configuration for the server (MCP 'local' client will run this command)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stdio_config")]
        public global::G.StdioServerConfig? StdioConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaSchemasMcpUpdateStdioMCPServer" /> class.
        /// </summary>
        /// <param name="serverName">
        /// The name of the MCP server
        /// </param>
        /// <param name="stdioConfig">
        /// The configuration for the server (MCP 'local' client will run this command)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LettaSchemasMcpUpdateStdioMCPServer(
            string? serverName,
            global::G.StdioServerConfig? stdioConfig)
        {
            this.ServerName = serverName;
            this.StdioConfig = stdioConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaSchemasMcpUpdateStdioMCPServer" /> class.
        /// </summary>
        public LettaSchemasMcpUpdateStdioMCPServer()
        {
        }
    }
}
//HintName: G.Models.LettaSchemasMcpServerUpdateStdioMCPServer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Update schema for Stdio MCP server - all fields optional
    /// </summary>
    public sealed partial class LettaSchemasMcpServerUpdateStdioMCPServer
    {
        /// <summary>
        /// Default Value: stdio
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mcp_server_type")]
        public string? McpServerType { get; set; }

        /// <summary>
        /// The command to run (MCP 'local' client will run this command)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("command")]
        public string? Command { get; set; }

        /// <summary>
        /// The arguments to pass to the command
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("args")]
        public global::System.Collections.Generic.IList<string>? Args { get; set; }

        /// <summary>
        /// Environment variables to set
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("env")]
        public global::System.Collections.Generic.Dictionary<string, string>? Env { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaSchemasMcpServerUpdateStdioMCPServer" /> class.
        /// </summary>
        /// <param name="mcpServerType">
        /// Default Value: stdio
        /// </param>
        /// <param name="command">
        /// The command to run (MCP 'local' client will run this command)
        /// </param>
        /// <param name="args">
        /// The arguments to pass to the command
        /// </param>
        /// <param name="env">
        /// Environment variables to set
        /// </param>
        public LettaSchemasMcpServerUpdateStdioMCPServer(
            string? mcpServerType,
            string? command,
            global::System.Collections.Generic.IList<string>? args,
            global::System.Collections.Generic.Dictionary<string, string>? env)
        {
            this.McpServerType = mcpServerType;
            this.Command = command;
            this.Args = args;
            this.Env = env;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaSchemasMcpServerUpdateStdioMCPServer" /> class.
        /// </summary>
        public LettaSchemasMcpServerUpdateStdioMCPServer()
        {
        }
    }
}
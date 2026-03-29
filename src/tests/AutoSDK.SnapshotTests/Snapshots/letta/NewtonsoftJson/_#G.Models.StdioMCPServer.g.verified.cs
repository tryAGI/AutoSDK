//HintName: G.Models.StdioMCPServer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A Stdio MCP server
    /// </summary>
    public sealed partial class StdioMCPServer
    {
        /// <summary>
        /// Default Value: stdio
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mcp_server_type")]
        public string? McpServerType { get; set; }

        /// <summary>
        /// The command to run (MCP 'local' client will run this command)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("command", Required = global::Newtonsoft.Json.Required.Always)]
        public string Command { get; set; } = default!;

        /// <summary>
        /// The arguments to pass to the command
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("args", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Args { get; set; } = default!;

        /// <summary>
        /// Environment variables to set
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("env")]
        public global::System.Collections.Generic.Dictionary<string, string>? Env { get; set; }

        /// <summary>
        /// The human-friendly ID of the Mcp_server
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The name of the MCP server
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("server_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ServerName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StdioMCPServer" /> class.
        /// </summary>
        /// <param name="command">
        /// The command to run (MCP 'local' client will run this command)
        /// </param>
        /// <param name="args">
        /// The arguments to pass to the command
        /// </param>
        /// <param name="serverName">
        /// The name of the MCP server
        /// </param>
        /// <param name="mcpServerType">
        /// Default Value: stdio
        /// </param>
        /// <param name="env">
        /// Environment variables to set
        /// </param>
        /// <param name="id">
        /// The human-friendly ID of the Mcp_server
        /// </param>
        public StdioMCPServer(
            string command,
            global::System.Collections.Generic.IList<string> args,
            string serverName,
            string? mcpServerType,
            global::System.Collections.Generic.Dictionary<string, string>? env,
            string? id)
        {
            this.McpServerType = mcpServerType;
            this.Command = command ?? throw new global::System.ArgumentNullException(nameof(command));
            this.Args = args ?? throw new global::System.ArgumentNullException(nameof(args));
            this.Env = env;
            this.Id = id;
            this.ServerName = serverName ?? throw new global::System.ArgumentNullException(nameof(serverName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StdioMCPServer" /> class.
        /// </summary>
        public StdioMCPServer()
        {
        }
    }
}
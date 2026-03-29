//HintName: G.Models.CreateStdioMCPServer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Create a new Stdio MCP server
    /// </summary>
    public sealed partial class CreateStdioMCPServer
    {
        /// <summary>
        /// Default Value: stdio
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_server_type")]
        public string? McpServerType { get; set; }

        /// <summary>
        /// The command to run (MCP 'local' client will run this command)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("command")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Command { get; set; }

        /// <summary>
        /// The arguments to pass to the command
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("args")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Args { get; set; }

        /// <summary>
        /// Environment variables to set
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("env")]
        public global::System.Collections.Generic.Dictionary<string, string>? Env { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStdioMCPServer" /> class.
        /// </summary>
        /// <param name="command">
        /// The command to run (MCP 'local' client will run this command)
        /// </param>
        /// <param name="args">
        /// The arguments to pass to the command
        /// </param>
        /// <param name="mcpServerType">
        /// Default Value: stdio
        /// </param>
        /// <param name="env">
        /// Environment variables to set
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateStdioMCPServer(
            string command,
            global::System.Collections.Generic.IList<string> args,
            string? mcpServerType,
            global::System.Collections.Generic.Dictionary<string, string>? env)
        {
            this.McpServerType = mcpServerType;
            this.Command = command ?? throw new global::System.ArgumentNullException(nameof(command));
            this.Args = args ?? throw new global::System.ArgumentNullException(nameof(args));
            this.Env = env;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStdioMCPServer" /> class.
        /// </summary>
        public CreateStdioMCPServer()
        {
        }
    }
}
//HintName: G.Models.StdioServerConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StdioServerConfig
    {
        /// <summary>
        /// The name of the server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServerName { get; set; }

        /// <summary>
        /// Default Value: stdio
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MCPServerTypeJsonConverter))]
        public global::G.MCPServerType? Type { get; set; }

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
        /// Initializes a new instance of the <see cref="StdioServerConfig" /> class.
        /// </summary>
        /// <param name="serverName">
        /// The name of the server
        /// </param>
        /// <param name="command">
        /// The command to run (MCP 'local' client will run this command)
        /// </param>
        /// <param name="args">
        /// The arguments to pass to the command
        /// </param>
        /// <param name="type">
        /// Default Value: stdio
        /// </param>
        /// <param name="env">
        /// Environment variables to set
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StdioServerConfig(
            string serverName,
            string command,
            global::System.Collections.Generic.IList<string> args,
            global::G.MCPServerType? type,
            global::System.Collections.Generic.Dictionary<string, string>? env)
        {
            this.ServerName = serverName ?? throw new global::System.ArgumentNullException(nameof(serverName));
            this.Type = type;
            this.Command = command ?? throw new global::System.ArgumentNullException(nameof(command));
            this.Args = args ?? throw new global::System.ArgumentNullException(nameof(args));
            this.Env = env;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StdioServerConfig" /> class.
        /// </summary>
        public StdioServerConfig()
        {
        }
    }
}
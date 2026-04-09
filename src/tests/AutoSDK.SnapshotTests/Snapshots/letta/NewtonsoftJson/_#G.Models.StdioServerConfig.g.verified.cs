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
        [global::Newtonsoft.Json.JsonProperty("server_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ServerName { get; set; } = default!;

        /// <summary>
        /// Default Value: stdio
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.MCPServerTypeJsonConverter))]
        public global::G.MCPServerType? Type { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
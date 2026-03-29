//HintName: G.Models.CreateMCPServerRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to create a new MCP server with configuration.
    /// </summary>
    public sealed partial class CreateMCPServerRequest
    {
        /// <summary>
        /// The name of the MCP server
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("server_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ServerName { get; set; } = default!;

        /// <summary>
        /// The MCP server configuration (Stdio, SSE, or Streamable HTTP)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Config Config { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMCPServerRequest" /> class.
        /// </summary>
        /// <param name="serverName">
        /// The name of the MCP server
        /// </param>
        /// <param name="config">
        /// The MCP server configuration (Stdio, SSE, or Streamable HTTP)
        /// </param>
        public CreateMCPServerRequest(
            string serverName,
            global::G.Config config)
        {
            this.ServerName = serverName ?? throw new global::System.ArgumentNullException(nameof(serverName));
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMCPServerRequest" /> class.
        /// </summary>
        public CreateMCPServerRequest()
        {
        }
    }
}
//HintName: G.Models.UpdateMCPServerRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to update an existing MCP server configuration.
    /// </summary>
    public sealed partial class UpdateMCPServerRequest
    {
        /// <summary>
        /// The name of the MCP server
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("server_name")]
        public string? ServerName { get; set; }

        /// <summary>
        /// The MCP server configuration updates (Stdio, SSE, or Streamable HTTP)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Config4 Config { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMCPServerRequest" /> class.
        /// </summary>
        /// <param name="config">
        /// The MCP server configuration updates (Stdio, SSE, or Streamable HTTP)
        /// </param>
        /// <param name="serverName">
        /// The name of the MCP server
        /// </param>
        public UpdateMCPServerRequest(
            global::G.Config4 config,
            string? serverName)
        {
            this.ServerName = serverName;
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMCPServerRequest" /> class.
        /// </summary>
        public UpdateMCPServerRequest()
        {
        }
    }
}
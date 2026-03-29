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
        [global::System.Text.Json.Serialization.JsonPropertyName("server_name")]
        public string? ServerName { get; set; }

        /// <summary>
        /// The MCP server configuration updates (Stdio, SSE, or Streamable HTTP)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.Config4JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Config4 Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
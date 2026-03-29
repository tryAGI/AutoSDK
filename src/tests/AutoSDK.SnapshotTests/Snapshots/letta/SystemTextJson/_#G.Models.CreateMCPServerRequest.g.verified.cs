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
        [global::System.Text.Json.Serialization.JsonPropertyName("server_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServerName { get; set; }

        /// <summary>
        /// The MCP server configuration (Stdio, SSE, or Streamable HTTP)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConfigJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Config Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
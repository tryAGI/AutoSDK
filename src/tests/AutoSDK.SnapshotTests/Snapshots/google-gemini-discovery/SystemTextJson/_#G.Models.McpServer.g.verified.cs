//HintName: G.Models.McpServer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A MCPServer is a server that can be called by the model to perform actions. It is a server that implements the MCP protocol. Next ID: 5
    /// </summary>
    public sealed partial class McpServer
    {
        /// <summary>
        /// A transport that can stream HTTP requests and responses. Next ID: 6
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("streamableHttpTransport")]
        public global::G.StreamableHttpTransport? StreamableHttpTransport { get; set; }

        /// <summary>
        /// The name of the MCPServer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServer" /> class.
        /// </summary>
        /// <param name="streamableHttpTransport">
        /// A transport that can stream HTTP requests and responses. Next ID: 6
        /// </param>
        /// <param name="name">
        /// The name of the MCPServer.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpServer(
            global::G.StreamableHttpTransport? streamableHttpTransport,
            string? name)
        {
            this.StreamableHttpTransport = streamableHttpTransport;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServer" /> class.
        /// </summary>
        public McpServer()
        {
        }
    }
}
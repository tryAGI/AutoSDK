//HintName: G.Models.MCPServerSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// MCP server schema for agent files with remapped ID.
    /// </summary>
    public sealed partial class MCPServerSchema
    {
        /// <summary>
        /// Human-readable MCP server ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServerType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServerName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_url")]
        public string? ServerUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stdio_config")]
        public object? StdioConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata_")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPServerSchema" /> class.
        /// </summary>
        /// <param name="id">
        /// Human-readable MCP server ID
        /// </param>
        /// <param name="serverType"></param>
        /// <param name="serverName"></param>
        /// <param name="serverUrl"></param>
        /// <param name="stdioConfig"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPServerSchema(
            string id,
            string serverType,
            string serverName,
            string? serverUrl,
            object? stdioConfig,
            object? metadata)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ServerType = serverType ?? throw new global::System.ArgumentNullException(nameof(serverType));
            this.ServerName = serverName ?? throw new global::System.ArgumentNullException(nameof(serverName));
            this.ServerUrl = serverUrl;
            this.StdioConfig = stdioConfig;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPServerSchema" /> class.
        /// </summary>
        public MCPServerSchema()
        {
        }
    }
}
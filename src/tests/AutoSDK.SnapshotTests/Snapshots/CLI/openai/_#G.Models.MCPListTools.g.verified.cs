//HintName: G.Models.MCPListTools.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A list of tools available on an MCP server.
    /// </summary>
    public sealed partial class MCPListTools
    {
        /// <summary>
        /// The type of the item. Always `mcp_list_tools`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MCPListToolsTypeJsonConverter))]
        public global::G.MCPListToolsType Type { get; set; }

        /// <summary>
        /// The unique ID of the list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The label of the MCP server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServerLabel { get; set; }

        /// <summary>
        /// The tools available on the server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.MCPListToolsTool> Tools { get; set; }

        /// <summary>
        /// Error message if the server could not list tools.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPListTools" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the item. Always `mcp_list_tools`.
        /// </param>
        /// <param name="id">
        /// The unique ID of the list.
        /// </param>
        /// <param name="serverLabel">
        /// The label of the MCP server.
        /// </param>
        /// <param name="tools">
        /// The tools available on the server.
        /// </param>
        /// <param name="error">
        /// Error message if the server could not list tools.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPListTools(
            string id,
            string serverLabel,
            global::System.Collections.Generic.IList<global::G.MCPListToolsTool> tools,
            global::G.MCPListToolsType type,
            string? error)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ServerLabel = serverLabel ?? throw new global::System.ArgumentNullException(nameof(serverLabel));
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
            this.Type = type;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPListTools" /> class.
        /// </summary>
        public MCPListTools()
        {
        }
    }
}
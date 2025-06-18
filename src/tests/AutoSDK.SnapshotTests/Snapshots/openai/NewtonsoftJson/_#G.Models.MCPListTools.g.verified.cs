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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.MCPListToolsType Type { get; set; }

        /// <summary>
        /// The unique ID of the list.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The label of the MCP server.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("server_label", Required = global::Newtonsoft.Json.Required.Always)]
        public string ServerLabel { get; set; } = default!;

        /// <summary>
        /// The tools available on the server.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.MCPListToolsTool> Tools { get; set; } = default!;

        /// <summary>
        /// Error message if the server could not list tools.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
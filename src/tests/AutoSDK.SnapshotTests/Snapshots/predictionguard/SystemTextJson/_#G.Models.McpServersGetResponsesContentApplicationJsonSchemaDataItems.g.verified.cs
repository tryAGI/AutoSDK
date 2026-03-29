//HintName: G.Models.McpServersGetResponsesContentApplicationJsonSchemaDataItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class McpServersGetResponsesContentApplicationJsonSchemaDataItems
    {
        /// <summary>
        /// The id of the MCP server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_label")]
        public string? ServerLabel { get; set; }

        /// <summary>
        /// The object type (mcp_server).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// The date the MCP server was added.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public int? Created { get; set; }

        /// <summary>
        /// The name of the organization that owns the MCP server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owned_by")]
        public string? OwnedBy { get; set; }

        /// <summary>
        /// A short description of the MCP server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_description")]
        public string? ServerDescription { get; set; }

        /// <summary>
        /// An array containing the available tools included in the MCP server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("available_tools")]
        public global::System.Collections.Generic.IList<string>? AvailableTools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServersGetResponsesContentApplicationJsonSchemaDataItems" /> class.
        /// </summary>
        /// <param name="serverLabel">
        /// The id of the MCP server.
        /// </param>
        /// <param name="object">
        /// The object type (mcp_server).
        /// </param>
        /// <param name="created">
        /// The date the MCP server was added.
        /// </param>
        /// <param name="ownedBy">
        /// The name of the organization that owns the MCP server.
        /// </param>
        /// <param name="serverDescription">
        /// A short description of the MCP server.
        /// </param>
        /// <param name="availableTools">
        /// An array containing the available tools included in the MCP server.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpServersGetResponsesContentApplicationJsonSchemaDataItems(
            string? serverLabel,
            string? @object,
            int? created,
            string? ownedBy,
            string? serverDescription,
            global::System.Collections.Generic.IList<string>? availableTools)
        {
            this.ServerLabel = serverLabel;
            this.Object = @object;
            this.Created = created;
            this.OwnedBy = ownedBy;
            this.ServerDescription = serverDescription;
            this.AvailableTools = availableTools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServersGetResponsesContentApplicationJsonSchemaDataItems" /> class.
        /// </summary>
        public McpServersGetResponsesContentApplicationJsonSchemaDataItems()
        {
        }
    }
}
//HintName: G.Models.McpToolsGetResponsesContentApplicationJsonSchemaDataItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The MCP tool information.
    /// </summary>
    public sealed partial class McpToolsGetResponsesContentApplicationJsonSchemaDataItems
    {
        /// <summary>
        /// The id of the MCP tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The object type (mcp_tool).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public string? Object { get; set; }

        /// <summary>
        /// A short description of the MCP tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The parameters necessary for using the MCP tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters")]
        public object? Parameters { get; set; }

        /// <summary>
        /// The date the MCP tool was added.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created")]
        public int? Created { get; set; }

        /// <summary>
        /// The name of the organization that owns the MCP tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owned_by")]
        public string? OwnedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpToolsGetResponsesContentApplicationJsonSchemaDataItems" /> class.
        /// </summary>
        /// <param name="id">
        /// The id of the MCP tool.
        /// </param>
        /// <param name="object">
        /// The object type (mcp_tool).
        /// </param>
        /// <param name="description">
        /// A short description of the MCP tool.
        /// </param>
        /// <param name="parameters">
        /// The parameters necessary for using the MCP tool.
        /// </param>
        /// <param name="created">
        /// The date the MCP tool was added.
        /// </param>
        /// <param name="ownedBy">
        /// The name of the organization that owns the MCP tool.
        /// </param>
        public McpToolsGetResponsesContentApplicationJsonSchemaDataItems(
            string? id,
            string? @object,
            string? description,
            object? parameters,
            int? created,
            string? ownedBy)
        {
            this.Id = id;
            this.Object = @object;
            this.Description = description;
            this.Parameters = parameters;
            this.Created = created;
            this.OwnedBy = ownedBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpToolsGetResponsesContentApplicationJsonSchemaDataItems" /> class.
        /// </summary>
        public McpToolsGetResponsesContentApplicationJsonSchemaDataItems()
        {
        }
    }
}
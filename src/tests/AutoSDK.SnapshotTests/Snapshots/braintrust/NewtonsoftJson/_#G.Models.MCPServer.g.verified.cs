//HintName: G.Models.MCPServer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MCPServer
    {
        /// <summary>
        /// Unique identifier for the MCP server
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Unique identifier for the project that the MCP server belongs under
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// Identifies the user who created the MCP server
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id")]
        public global::System.Guid? UserId { get; set; }

        /// <summary>
        /// Date of MCP server creation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created")]
        public global::System.DateTime? Created { get; set; }

        /// <summary>
        /// Date of MCP server deletion, or null if the MCP server is still active
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleted_at")]
        public global::System.DateTime? DeletedAt { get; set; }

        /// <summary>
        /// Name of the MCP server. Within a project, MCP server names are unique
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Textual description of the MCP server
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// URL of the MCP server endpoint
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPServer" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the MCP server
        /// </param>
        /// <param name="projectId">
        /// Unique identifier for the project that the MCP server belongs under
        /// </param>
        /// <param name="name">
        /// Name of the MCP server. Within a project, MCP server names are unique
        /// </param>
        /// <param name="url">
        /// URL of the MCP server endpoint
        /// </param>
        /// <param name="userId">
        /// Identifies the user who created the MCP server
        /// </param>
        /// <param name="created">
        /// Date of MCP server creation
        /// </param>
        /// <param name="deletedAt">
        /// Date of MCP server deletion, or null if the MCP server is still active
        /// </param>
        /// <param name="description">
        /// Textual description of the MCP server
        /// </param>
        public MCPServer(
            global::System.Guid id,
            global::System.Guid projectId,
            string name,
            string url,
            global::System.Guid? userId,
            global::System.DateTime? created,
            global::System.DateTime? deletedAt,
            string? description)
        {
            this.Id = id;
            this.ProjectId = projectId;
            this.UserId = userId;
            this.Created = created;
            this.DeletedAt = deletedAt;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPServer" /> class.
        /// </summary>
        public MCPServer()
        {
        }
    }
}
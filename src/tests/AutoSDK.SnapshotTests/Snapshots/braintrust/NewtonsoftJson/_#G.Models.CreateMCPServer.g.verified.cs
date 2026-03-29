//HintName: G.Models.CreateMCPServer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateMCPServer
    {
        /// <summary>
        /// Unique identifier for the project that the MCP server belongs under
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="CreateMCPServer" /> class.
        /// </summary>
        /// <param name="projectId">
        /// Unique identifier for the project that the MCP server belongs under
        /// </param>
        /// <param name="name">
        /// Name of the MCP server. Within a project, MCP server names are unique
        /// </param>
        /// <param name="url">
        /// URL of the MCP server endpoint
        /// </param>
        /// <param name="description">
        /// Textual description of the MCP server
        /// </param>
        public CreateMCPServer(
            global::System.Guid projectId,
            string name,
            string url,
            string? description)
        {
            this.ProjectId = projectId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMCPServer" /> class.
        /// </summary>
        public CreateMCPServer()
        {
        }
    }
}
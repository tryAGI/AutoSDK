//HintName: G.Models.PatchMCPServer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchMCPServer
    {
        /// <summary>
        /// Name of the MCP server. Within a project, MCP server names are unique
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// URL of the MCP server endpoint
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Textual description of the MCP server
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchMCPServer" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the MCP server. Within a project, MCP server names are unique
        /// </param>
        /// <param name="url">
        /// URL of the MCP server endpoint
        /// </param>
        /// <param name="description">
        /// Textual description of the MCP server
        /// </param>
        public PatchMCPServer(
            string? name,
            string? url,
            string? description)
        {
            this.Name = name;
            this.Url = url;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchMCPServer" /> class.
        /// </summary>
        public PatchMCPServer()
        {
        }
    }
}
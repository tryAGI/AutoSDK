//HintName: G.Models.MCPToolDefinition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MCPToolDefinition
    {
        /// <summary>
        /// Name of the MCP tool.<br/>
        /// Example: search_files
        /// </summary>
        /// <example>search_files</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Description of what the MCP tool does.<br/>
        /// Example: Search for files in the filesystem
        /// </summary>
        /// <example>Search for files in the filesystem</example>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// JSON schema defining the input parameters for the tool.<br/>
        /// Example: {"type":"object","properties":{"query":{"type":"string","description":"Search query"}},"required":["query"]}
        /// </summary>
        /// <example>{"type":"object","properties":{"query":{"type":"string","description":"Search query"}},"required":["query"]}</example>
        [global::Newtonsoft.Json.JsonProperty("inputSchema", Required = global::Newtonsoft.Json.Required.Always)]
        public object InputSchema { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolDefinition" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the MCP tool.<br/>
        /// Example: search_files
        /// </param>
        /// <param name="description">
        /// Description of what the MCP tool does.<br/>
        /// Example: Search for files in the filesystem
        /// </param>
        /// <param name="inputSchema">
        /// JSON schema defining the input parameters for the tool.<br/>
        /// Example: {"type":"object","properties":{"query":{"type":"string","description":"Search query"}},"required":["query"]}
        /// </param>
        public MCPToolDefinition(
            string name,
            string description,
            object inputSchema)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.InputSchema = inputSchema ?? throw new global::System.ArgumentNullException(nameof(inputSchema));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolDefinition" /> class.
        /// </summary>
        public MCPToolDefinition()
        {
        }
    }
}
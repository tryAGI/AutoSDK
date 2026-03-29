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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Description of what the MCP tool does.<br/>
        /// Example: Search for files in the filesystem
        /// </summary>
        /// <example>Search for files in the filesystem</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// JSON schema defining the input parameters for the tool.<br/>
        /// Example: {"type":"object","properties":{"query":{"type":"string","description":"Search query"}},"required":["query"]}
        /// </summary>
        /// <example>{"type":"object","properties":{"query":{"type":"string","description":"Search query"}},"required":["query"]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputSchema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object InputSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
//HintName: G.Models.MCPTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A simple wrapper around MCP's tool definition (to avoid conflict with our own)
    /// </summary>
    public sealed partial class MCPTool
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputSchema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object InputSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputSchema")]
        public object? OutputSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotations")]
        public global::G.ToolAnnotations? Annotations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_meta")]
        public object? Meta { get; set; }

        /// <summary>
        /// Schema health status for OpenAI strict mode
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("health")]
        public global::G.MCPToolHealth2? Health { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPTool" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="inputSchema"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="outputSchema"></param>
        /// <param name="annotations"></param>
        /// <param name="meta"></param>
        /// <param name="health">
        /// Schema health status for OpenAI strict mode
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPTool(
            string name,
            object inputSchema,
            string? title,
            string? description,
            object? outputSchema,
            global::G.ToolAnnotations? annotations,
            object? meta,
            global::G.MCPToolHealth2? health)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Title = title;
            this.Description = description;
            this.InputSchema = inputSchema ?? throw new global::System.ArgumentNullException(nameof(inputSchema));
            this.OutputSchema = outputSchema;
            this.Annotations = annotations;
            this.Meta = meta;
            this.Health = health;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPTool" /> class.
        /// </summary>
        public MCPTool()
        {
        }
    }
}